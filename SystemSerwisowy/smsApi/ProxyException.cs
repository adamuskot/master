
namespace smsApi.Api
{
    public class ProxyException : smsApi.Api.Exception
    {
        public ProxyException(string message) : base(message) { }
        public ProxyException(string message, System.Exception inner) : base(message, inner) { }
    }
}
