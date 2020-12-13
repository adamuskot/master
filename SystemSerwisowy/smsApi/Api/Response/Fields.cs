using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
	[DataContract]
	public class Fields : BasicCollection<Field>
	{
		private Fields() : base() { }
	}
}
