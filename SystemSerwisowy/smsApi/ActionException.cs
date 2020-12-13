
namespace smsApi.Api
{
    public class ActionException : smsApi.Api.SmsapiException
    {
        public ActionException(string message, string code)
            : base(message, code)
        {
        }
    }
}
