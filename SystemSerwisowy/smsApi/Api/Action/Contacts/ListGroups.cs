using System;
using System.Collections.Specialized;

namespace smsApi.Api.Action
{
	public class ListGroups : Rest<smsApi.Api.Response.Groups>
	{
		public ListGroups ()
			: base()
		{
		}

		protected override string Resource { get { return "contacts/groups"; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }

		protected override NameValueCollection Parameters
		{
			get
			{
				NameValueCollection parameters = base.Parameters;
				parameters.Add("with", "contacts_count");
				if (Id   != null) parameters.Add("id",   Id);
				if (Name != null) parameters.Add("name", Name);
				return parameters;
			}
		}

		public string Id;
		public ListGroups SetId(string id)
		{
			Id = id;
			return this;
		}

		public string Name;
		public ListGroups SetName(string name)
		{
			Name = name;
			return this;
		}
	}
}
