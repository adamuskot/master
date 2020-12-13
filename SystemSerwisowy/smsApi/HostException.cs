
namespace smsApi.Api
{
    public class HostException : smsApi.Api.SmsapiException
    {
        public static readonly string E_JSON_DECODE = "-1";

        public HostException(string message, string code)
            : base(message, code)
        {
        }
    }
}
