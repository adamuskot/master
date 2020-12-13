using System;
using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
	[DataContract]
	public class Contacts : BasicCollection<Contact>
	{
		[Obsolete("")]
		[DataMember(Name = "total", IsRequired = false)]
		public readonly int Total;
	}
}
