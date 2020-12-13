using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class SenderAdd : BaseSimple<smsApi.Api.Response.Base>
    {
        private string name;

        protected override string Uri() { return "sender.do"; }

        public SenderAdd SetName(string name)
        {
            this.name = name;
            return this;
        }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("add", name);

            return collection;
        }
    }
}
