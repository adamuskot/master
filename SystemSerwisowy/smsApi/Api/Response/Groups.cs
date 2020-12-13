using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
    [DataContract]
    public class Groups : BasicCollection<Group>
    {
        private Groups() : base() { }
    }
}
