using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
    [DataContract]
    public class Base
    {
        public Base()
        {
            ErrorCode = 0;
            ErrorMessage = "";
        }

        [DataMember(Name = "error", IsRequired = false)]
        public readonly int ErrorCode;

        [DataMember(Name = "message", IsRequired = false)]
        public readonly string ErrorMessage;

        public bool isError()
        {
            return (ErrorCode != 0);
        }
    }
}
