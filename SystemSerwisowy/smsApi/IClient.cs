using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smsApi.Api
{
    public interface IClient
    {
        string GetAuthenticationHeader();
        string GetClientAgentHeader();
    }
}
