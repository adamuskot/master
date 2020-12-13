
namespace smsApi.Api
{
    public class MMSFactory : Factory
    {
        public MMSFactory(ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(address) 
        { 
        }

        public MMSFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(client, address) 
        { 
        }

        public MMSFactory(IClient client, Proxy proxy) 
            : base(client, proxy) 
        { 
        }

        public smsApi.Api.Action.MMSDelete ActionDelete(string id = null)
        {
            smsApi.Api.Action.MMSDelete action = new smsApi.Api.Action.MMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public smsApi.Api.Action.MMSGet ActionGet(string id = null)
        {
            smsApi.Api.Action.MMSGet action = new smsApi.Api.Action.MMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public smsApi.Api.Action.MMSGet ActionGet(string[] id)
        {
            smsApi.Api.Action.MMSGet action = new smsApi.Api.Action.MMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public smsApi.Api.Action.MMSSend ActionSend(string to = null)
        {
            string[] tos = ( to == null ? null : new string[] { to } );
            return ActionSend(tos);
        }

        public smsApi.Api.Action.MMSSend ActionSend(string[] to)
        {
            smsApi.Api.Action.MMSSend action = new smsApi.Api.Action.MMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);

            return action;
        }
    }
}
