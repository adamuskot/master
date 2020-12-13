using System;
using System.Collections.Specialized;

namespace smsApi.Api.Action
{
	public class ListFields : Rest<smsApi.Api.Response.Fields>
	{
		public ListFields ()
			: base()
		{
		}

		protected override string Resource { get { return "contacts/fields"; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }
	}
}
