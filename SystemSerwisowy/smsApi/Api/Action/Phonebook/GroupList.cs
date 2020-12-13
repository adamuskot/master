using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class PhonebookGroupList : BaseSimple<smsApi.Api.Response.Groups>
    {
        public PhonebookGroupList()
            : base()
        {
        }

        protected override string Uri() { return "phonebook.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("list_groups", "");

            return collection;
        }
    }
}
