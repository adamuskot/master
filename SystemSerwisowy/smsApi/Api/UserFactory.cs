using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smsApi.Api
{
    public class UserFactory : Factory
    {
        public UserFactory(ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(address) 
        { 
        }

        public UserFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(client, address) 
        { 
        }

        public UserFactory(IClient client, Proxy proxy) 
            : base(client, proxy) 
        { 
        }

        public smsApi.Api.Action.UserGetCredits ActionGetCredits()
        {
            var action = new smsApi.Api.Action.UserGetCredits();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }

        public smsApi.Api.Action.UserAdd ActionAdd()
        {
            var action = new smsApi.Api.Action.UserAdd();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }

        public smsApi.Api.Action.UserEdit ActionEdit(string username = null)
        {
            var action = new smsApi.Api.Action.UserEdit();

            action.Client(client);
            action.Proxy(proxy);

            action.Username(username);

            return action;
        }

        public smsApi.Api.Action.UserGet ActionGet(string username = null)
        {
            var action = new smsApi.Api.Action.UserGet();

            action.Client(client);
            action.Proxy(proxy);

            action.Username(username);

            return action;
        }

        public smsApi.Api.Action.UserList ActionList()
        {
            var action = new smsApi.Api.Action.UserList();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }
    }
}
