using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class SMSDelete : BaseSimple<smsApi.Api.Response.Countable>
    {
        public SMSDelete() : base() { }

        protected override string Uri() { return "sms.do"; }

        protected string id;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("sch_del", id);

            return collection;
        }

        public SMSDelete Id(string id)
        {
            this.id = id;
            return this;
        }
    }
}
