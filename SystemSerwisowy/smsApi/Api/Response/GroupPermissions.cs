using System;
using System.Runtime.Serialization;

namespace smsApi.Api.Response
{
	[DataContract]
	public class GroupPermissions : BasicCollection<GroupPermission>
	{
		private GroupPermissions() : base() { }
	}
}
