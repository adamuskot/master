using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smsApi.Api
{
    public class SmsapiException : smsApi.Api.Exception
    {
        private string Code;

        public SmsapiException(string message, string code)
            : base(message)
        {
            Code = code;
        }

        public string GetCode()
        {
            return Code;
        }
    }
}
