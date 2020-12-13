using System.Collections.Generic;
using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class SenderList : BaseArray<smsApi.Api.Response.Sender>
    {
        protected override string Uri() { return "sender.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("list", "1");

            return collection;
        }
    }
}
