using System.Collections.Specialized;

namespace smsApi.Api.Action
{
    public class UserGetCredits : BaseSimple<smsApi.Api.Response.Credits>
    {
        public UserGetCredits() : base() { }

        protected override string Uri() { return "user.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");
            collection.Add("credits", "1");
            collection.Add("details", "1");

            return collection;
        }
    }
}
