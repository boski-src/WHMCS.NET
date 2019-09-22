namespace WHMCS.NET
{
    public class BaseResponse
    {
        public string Result { get; set; }
        public string Message { get; set; }
        public bool IsSucceed { get; set; }
        public bool IsFailed { get; set; }
    }
}