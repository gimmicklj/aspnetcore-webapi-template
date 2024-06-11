namespace WebAPI.Exceptions
{
    /// <summary>
    /// 业务异常
    /// </summary>
    public class BusinessException : Exception
    {
        public int Code { get; set; }

        public BusinessException(string message, int code = 400) : base(message)
        {

        }
    }
}
