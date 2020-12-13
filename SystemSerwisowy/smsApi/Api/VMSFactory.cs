
namespace smsApi.Api
{
    public class VMSFactory : Factory
    {
        public VMSFactory(ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(address) 
        { 
        }

        public VMSFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(client, address) 
        { 
        }

        public VMSFactory(IClient client, Proxy proxy) 
            : base(client, proxy)
        {
        }

        public smsApi.Api.Action.VMSDelete ActionDelete(string id = null)
        {
            smsApi.Api.Action.VMSDelete action = new smsApi.Api.Action.VMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public smsApi.Api.Action.VMSGet ActionGet(string id = null)
        {
            smsApi.Api.Action.VMSGet action = new smsApi.Api.Action.VMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public smsApi.Api.Action.VMSGet ActionGet(string[] id)
        {
            smsApi.Api.Action.VMSGet action = new smsApi.Api.Action.VMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public smsApi.Api.Action.VMSSend ActionSend(string to = null)
        {
            string[] tos = ( to == null ? null : new string[] { to } );
            return ActionSend(tos);
        }

        public smsApi.Api.Action.VMSSend ActionSend(string[] to)
        {
            smsApi.Api.Action.VMSSend action = new smsApi.Api.Action.VMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);

            return action;
        }
    }
}
