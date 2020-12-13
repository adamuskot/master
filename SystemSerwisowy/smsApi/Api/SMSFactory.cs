
namespace smsApi.Api
{
    public class SMSFactory : Factory
    {
        public SMSFactory(ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(address) 
        { 
        }

        public SMSFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(client, address) 
        { 
        }

        public SMSFactory(IClient client, Proxy proxy) 
            : base(client, proxy) 
        { 
        }

        public smsApi.Api.Action.SMSDelete ActionDelete(string id = null)
        {
            smsApi.Api.Action.SMSDelete action = new smsApi.Api.Action.SMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public smsApi.Api.Action.SMSGet ActionGet(string id = null)
        {
            smsApi.Api.Action.SMSGet action = new smsApi.Api.Action.SMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public smsApi.Api.Action.SMSGet ActionGet(string[] id)
        {
            smsApi.Api.Action.SMSGet action = new smsApi.Api.Action.SMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public smsApi.Api.Action.SMSSend ActionSend(string to = null, string text = null)
        {
            string[] tos = ( to == null ? null : new string[] { to } );
            return ActionSend(tos, text);
        }

        public smsApi.Api.Action.SMSSend ActionSend(string[] to, string text = null)
        {
            smsApi.Api.Action.SMSSend action = new smsApi.Api.Action.SMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);
            action.SetText(text);

            return action;
        }
    }
}
