
namespace smsApi.Api
{
    public class ClientException : smsApi.Api.SmsapiException
    {
        public ClientException(string message, string code)
            : base(message, code)
        {
        }
    }
}
