using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
	[DataContract]
	public class FieldOption
	{
		[DataMember(Name = "name", IsRequired = false)]
		public readonly string Name;

		[DataMember(Name = "value", IsRequired = false)]
		public readonly string Value;
	}
}
