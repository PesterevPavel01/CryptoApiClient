using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces.Services;
using CryptoClient.UI.Models;

namespace CryptoClient.App
{
    public partial class MainForm : Form
    {

        private readonly ICryptoApiService cryptoApiService;
        private readonly List<ExchangeTask> exchangeTask;

        private const string _defoultSymbol = "BTCUSDT";
        private string _symbol;

        public MainForm(ICryptoApiService cryptoApiService)
        {
            InitializeComponent();

            _symbol = _defoultSymbol;

            this.cryptoApiService = cryptoApiService;

            cryptoApiService.BinanceSubscribeTradeStream(_defoultSymbol);

            cryptoApiService.BybitSubscribeTradeStream(_defoultSymbol);

            exchangeTask = [];

            ComboBoxInit();
        }

        private async void ComboBoxInit()
        {

            //загрузить список в комбобокс и установить активным дефолтное значение
            SymbolComboBox.Items.AddRange(await cryptoApiService.GetSymbols());
            SymbolComboBox.Text = _defoultSymbol;

        }

        private void SymbolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _symbol = SymbolComboBox.Text;

            ChangeSymbol();
        }

        async void ChangeSymbol()
        {

            //переподписаться 
            var result = await cryptoApiService.BinanceStreamChangeSymbol(_symbol);
            result = await cryptoApiService.BybitStreamChangeSymbol(_symbol);
            
            //Если текущая задача не первая, то отменить предыдущую задачу 
            if (exchangeTask.Count> 0)
            {
                exchangeTask[^1].CancellationTokenSource.Cancel();
            }

            //Запустить новую задачу обновления формы
            RunCryptoExchange();
        }

        private void RunCryptoExchange()
        {

            CancellationTokenSource cancellationTokenSource = new();

            CancellationToken cancellationToken= cancellationTokenSource.Token;

            Task.Run(async () =>
            {

                while (true)
                {
                    if (cancellationTokenSource.IsCancellationRequested)
                    {
                        cancellationTokenSource.Dispose();
                        break;
                    }

                    UpdateData();
                    await Task.Delay(5000);
                }

            }, cancellationToken);

            exchangeTask.Add(new ExchangeTask {CancellationToken=cancellationToken,CancellationTokenSource=cancellationTokenSource });
        }

        private async void UpdateData()
        {

            UpdateDataGridView(BybitTable, cryptoApiService.BybitGetStreamResult());

            UpdateDataGridView(BinanceTable, cryptoApiService.BinanceGetStreamResult());

            UpdateDataGridView(KucoinTable, await cryptoApiService.GetKucoinSymbol(_symbol));

            UpdateDataGridView(BitgetTable, await cryptoApiService.GetBitgetSymbol(_symbol));

        }

        private void UpdateDataGridView(DataGridView gridView, List<SymbolItem> sourseList)
        {
            Invoke((MethodInvoker)delegate
            {
                gridView.DataSource = sourseList;
            });
        }

    }
}
