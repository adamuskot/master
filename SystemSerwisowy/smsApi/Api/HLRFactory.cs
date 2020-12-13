﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smsApi.Api
{
    public class HLRFactory : Factory
    {
        public HLRFactory(ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(address) 
        { 
        }

        public HLRFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
            : base(client, address) 
        { 
        }

        public HLRFactory(IClient client, Proxy proxy) 
            : base(client, proxy)
        {
        }

        public smsApi.Api.Action.HLRCheckNumber ActionCheckNumber(string number = null)
        {
            var action = new smsApi.Api.Action.HLRCheckNumber();

            action.Client(client);
            action.Proxy(proxy);

            action.SetNumber(number);

            return action;
        }
    }
}
