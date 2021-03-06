using System;
using System.Collections.Specialized;

namespace smsApi.Api.Action
{
	public class DeleteContact : Rest<smsApi.Api.Response.Base>
	{
		public DeleteContact(string contactId)
			: base()
		{
			ContactId = contactId;
		}

		protected override string Resource { get { return "contacts/" + ContactId; } }

		protected override RequestMethod Method { get { return RequestMethod.DELETE; } }

		private string contactId;
		public string ContactId { get { return contactId; } private set { contactId = value; } }
	}
}
