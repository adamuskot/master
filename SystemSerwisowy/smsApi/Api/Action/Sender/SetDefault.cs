using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class SenderSetDefault : BaseSimple<smsApi.Api.Response.Base>
    {
        protected override string Uri() { return "sender.do"; }

        private string name;

        public SenderSetDefault Name(string name)
        {
            this.name = name;
            return this;
        }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("default", this.name);

            return collection;
        }
    }
}
