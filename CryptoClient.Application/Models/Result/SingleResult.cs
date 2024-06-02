namespace CryptoClient.App.Models.Result
{
    public class SingleResult
    {
        public bool IsSuccess => ErrorMessage == null;
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }

    }

    public class SingleResult<T> : SingleResult
    {
        public SingleResult(string errorMessage, int errorCode, T data)
        {
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
            Data = data;
        }

        public T Data { get; set; }

        public SingleResult() { }
    }
}
