using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class PhonebookContactDelete : BaseSimple<smsApi.Api.Response.Base>
    {
        public PhonebookContactDelete() : base() { }

        protected override string Uri() { return "phonebook.do"; }

        protected string number;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("delete_contact", number);

            return collection;
        }

        public PhonebookContactDelete Number(string number)
        {
            this.number = number;
            return this;
        }
    }
}
