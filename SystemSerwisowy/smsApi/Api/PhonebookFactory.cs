using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smsApi.Api
{
    [Obsolete("use ContactsFactory instead")]
    public class PhonebookFactory : Factory
    {
        public PhonebookFactory(ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(address) 
        { 
        }

        public PhonebookFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(client, address) 
        { 
        }

        public PhonebookFactory(IClient client, Proxy proxy) 
            : base(client, proxy) 
        { 
        }

        public smsApi.Api.Action.PhonebookContactAdd ActionContactAdd(string number = null)
        {
            var action = new smsApi.Api.Action.PhonebookContactAdd();

            action.Client(client);
            action.Proxy(proxy);

            action.SetNumber(number);

            return action;
        }

        public smsApi.Api.Action.PhonebookContactGet ActionContactGet(string number = null)
        {
            var action = new smsApi.Api.Action.PhonebookContactGet();

            action.Client(client);
            action.Proxy(proxy);

            action.Number(number);

            return action;
        }

        public smsApi.Api.Action.PhonebookContactEdit ActionContactEdit(string number = null)
        {
            var action = new smsApi.Api.Action.PhonebookContactEdit();

            action.Client(client);
            action.Proxy(proxy);

            action.Number(number);

            return action;
        }

        public smsApi.Api.Action.PhonebookContactDelete ActionContactDelete(string number = null)
        {
            var action = new smsApi.Api.Action.PhonebookContactDelete();

            action.Client(client);
            action.Proxy(proxy);

            action.Number(number);

            return action;
        }

        public smsApi.Api.Action.PhonebookContactList ActionContactList()
        {
            var action = new smsApi.Api.Action.PhonebookContactList();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }

        public smsApi.Api.Action.PhonebookGroupAdd ActionGroupAdd(string name = null)
        {
            var action = new smsApi.Api.Action.PhonebookGroupAdd();

            action.Client(client);
            action.Proxy(proxy);

            action.SetName(name);

            return action;
        }

        public smsApi.Api.Action.PhonebookGroupEdit ActionGroupEdit(string name = null)
        {
            var action = new smsApi.Api.Action.PhonebookGroupEdit();

            action.Client(client);
            action.Proxy(proxy);

            action.Name(name);

            return action;
        }

        public smsApi.Api.Action.PhonebookGroupGet ActionGroupGet(string name = null)
        {
            var action = new smsApi.Api.Action.PhonebookGroupGet();

            action.Client(client);
            action.Proxy(proxy);

            action.Name(name);

            return action;
        }

        public smsApi.Api.Action.PhonebookGroupDelete ActionGroupDelete(string name = null)
        {
            var action = new smsApi.Api.Action.PhonebookGroupDelete();

            action.Client(client);
            action.Proxy(proxy);

            action.Name(name);

            return action;
        }

        public smsApi.Api.Action.PhonebookGroupList ActionGroupList()
        {
            var action = new smsApi.Api.Action.PhonebookGroupList();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }
    }
}
