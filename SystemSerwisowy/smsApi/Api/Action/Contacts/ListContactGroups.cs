using System;
using System.Collections.Specialized;

namespace smsApi.Api.Action
{
	public class ListContactGroups : Rest<smsApi.Api.Response.Groups>
	{
		public ListContactGroups(string contactId)
			: base()
		{
			ContactId = contactId;
		}

		protected override string Resource { get { return "contacts/" + ContactId + "/groups"; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }

		private string contactId;
		public string ContactId { get { return contactId; } private set { contactId = value; } }
	}
}
