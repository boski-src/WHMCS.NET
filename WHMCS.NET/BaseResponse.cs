namespace WHMCS.NET
{
    public class BaseResponse
    {
        public string Result { get; set; }
        public string Message { get; set; }
        public bool Succeed { get; set; }
    }
}