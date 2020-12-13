using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class PhonebookContactGet : BaseSimple<smsApi.Api.Response.Contact>
    {
        public PhonebookContactGet() : base() { }

        protected override string Uri() { return "phonebook.do"; }

        protected string number;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("get_contact", number);

            return collection;
        }

        public PhonebookContactGet Number(string number)
        {
            this.number = number;
            return this;
        }
    }
}
