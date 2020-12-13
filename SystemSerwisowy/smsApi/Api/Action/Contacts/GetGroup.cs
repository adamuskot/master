using System;
using System.Collections.Specialized;

namespace smsApi.Api.Action
{
	public class GetGroup : Rest<smsApi.Api.Response.Group>
	{
		public GetGroup(string groupId)
			: base()
		{
			GroupId = groupId;
		}

		protected override string Resource { get { return "contacts/groups/" + GroupId; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }

		private string groupId;
		public string GroupId { get { return groupId; } private set { groupId = value; } }
	}
}
