namespace CryptoClient.UI.Models
{
    public class ExchangeTask
    {
        public CancellationTokenSource? CancellationTokenSource { get; set; }
        public CancellationToken CancellationToken { get; set; }
        public Task? Task { get; set; }
    }
}
