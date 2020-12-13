using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
	[DataContract]
	public class FieldOptions : BasicCollection<FieldOption>
	{
		private FieldOptions() : base() { }
	}
}
