using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces.Services;
using CryptoClient.App.Models;
using CryptoClient.App.Models.Result;
using CryptoClient.App.Services;

namespace CryptoClient.App
{
    public partial class MainForm : Form
    {

        private readonly ICryptoApiService cryptoApiService;
        private Dictionary<int, CancellationTokenSource> dictionaryCancelTokenSource;
        private Dictionary<int, CancellationToken> dictionaryToken;

        private int _tokenNumber = 0;
        private const string _defoultSymbol = "BTCUSDT";
        private string _symbol;

        public MainForm(ICryptoApiService cryptoApiService)
        {
            InitializeComponent();

            _symbol = _defoultSymbol;

            this.cryptoApiService = cryptoApiService;

            dictionaryCancelTokenSource = [];
            dictionaryToken = [];

            ComboBoxInit();
            StartProcess();
        }

        private async void ComboBoxInit(){

            await LoadSymbolComboBoxItemsAsync();

        }

        private void StartProcess() {

            _tokenNumber++;

            CancellationTokenSource cancelTokenSource = new();

            CancellationToken token = cancelTokenSource.Token;

            dictionaryCancelTokenSource.Add(_tokenNumber, cancelTokenSource);

            dictionaryToken.Add(_tokenNumber, token);


            Task.Run(async () => {
                
                int number = _tokenNumber;

                while (true)
                {

                    if (dictionaryToken[number].IsCancellationRequested)
                    {
                        dictionaryCancelTokenSource[number].Dispose();
                        dictionaryCancelTokenSource.Remove(number);
                        dictionaryToken.Remove(number);
                        return;
                    }
                    
                    UpdateTable(BybitTable, await cryptoApiService.GetBybitSymbol(_symbol));

                    UpdateTable(BinanceTable, await cryptoApiService.GetBinanceSymbol(_symbol));

                    UpdateTable(KucoinTable, await cryptoApiService.GetKucoinSymbol(_symbol));

                    UpdateTable(BitgetTable, await cryptoApiService.GetBitgetSymbol(_symbol));

                    await Task.Delay(5000);
                }

            },token);

        }

        private void UpdateTable(DataGridView gridView, List<SymbolItem> sourseList) {

            Invoke((MethodInvoker)delegate
            {
                gridView.DataSource = sourseList;
            });

        }

        private async Task LoadSymbolComboBoxItemsAsync() {

            SymbolComboBox.Items.AddRange(await cryptoApiService.GetSymbols());

            SymbolComboBox.Text = _defoultSymbol;

        }

        private void SymbolComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            _symbol= SymbolComboBox.Text;

            dictionaryCancelTokenSource[_tokenNumber].Cancel();

            StartProcess();
        }
    }
}
