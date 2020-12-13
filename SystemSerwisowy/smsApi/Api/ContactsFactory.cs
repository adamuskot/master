using System;

namespace smsApi.Api
{
	public class ContactsFactory : Factory
	{
		public ContactsFactory(ProxyAddress address = ProxyAddress.SmsApiPl)
			: base(address)
		{
		}

		public ContactsFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiPl) 
			: base(client, address)
		{
		}

        public ContactsFactory(IClient client, Proxy proxy) : base(client, proxy)
        {
        }

        public smsApi.Api.Action.ListContacts ListContacts()
		{
			smsApi.Api.Action.ListContacts action = new smsApi.Api.Action.ListContacts();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.CreateContact CreateContact()
		{
			smsApi.Api.Action.CreateContact action = new smsApi.Api.Action.CreateContact();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.DeleteContact DeleteContact(string contactId)
		{
			smsApi.Api.Action.DeleteContact action = new smsApi.Api.Action.DeleteContact(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.GetContact GetContact(string contactId)
		{
			smsApi.Api.Action.GetContact action = new smsApi.Api.Action.GetContact(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.EditContact EditContact(string contactId)
		{
			smsApi.Api.Action.EditContact action = new smsApi.Api.Action.EditContact(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.ListGroups ListGroups()
		{
			smsApi.Api.Action.ListGroups action = new smsApi.Api.Action.ListGroups();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.CreateGroup CreateGroup()
		{
			smsApi.Api.Action.CreateGroup action = new smsApi.Api.Action.CreateGroup();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.DeleteGroup DeleteGroup(string groupId)
		{
			smsApi.Api.Action.DeleteGroup action = new smsApi.Api.Action.DeleteGroup(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.GetGroup GetGroup(string groupId)
		{
			smsApi.Api.Action.GetGroup action = new smsApi.Api.Action.GetGroup(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.EditGroup EditGroup(string groupId)
		{
			smsApi.Api.Action.EditGroup action = new smsApi.Api.Action.EditGroup(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}
	
		public smsApi.Api.Action.ListGroupPermissions ListGroupPermissions(string groupId)
		{
			smsApi.Api.Action.ListGroupPermissions action = new smsApi.Api.Action.ListGroupPermissions(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.ListFields ListFields()
		{
			smsApi.Api.Action.ListFields action = new smsApi.Api.Action.ListFields();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.CreateField CreateField()
		{
			smsApi.Api.Action.CreateField action = new smsApi.Api.Action.CreateField();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.DeleteField DeleteField(string fieldId)
		{
			smsApi.Api.Action.DeleteField action = new smsApi.Api.Action.DeleteField(fieldId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.EditField EditField(string fieldId)
		{
			smsApi.Api.Action.EditField action = new smsApi.Api.Action.EditField(fieldId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.ListFieldOptions ListFieldOptions(string fieldId)
		{
			smsApi.Api.Action.ListFieldOptions action = new smsApi.Api.Action.ListFieldOptions(fieldId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.BindContactToGroup BindContactToGroup(string contactId, string groupId)
		{
			smsApi.Api.Action.BindContactToGroup action = new smsApi.Api.Action.BindContactToGroup(contactId, groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.UnbindContactFromGroup UnbindContactFromGroup(string contactId, string groupId)
		{
			smsApi.Api.Action.UnbindContactFromGroup action = new smsApi.Api.Action.UnbindContactFromGroup(contactId, groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.ListContactGroups ListContactGroups(string contactId)
		{
			smsApi.Api.Action.ListContactGroups action = new smsApi.Api.Action.ListContactGroups(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.GetContactGroup GetContactGroup(string contactId, string groupId)
		{
			smsApi.Api.Action.GetContactGroup action = new smsApi.Api.Action.GetContactGroup(contactId, groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.CreateGroupPermission CreateGroupPermission(string groupId)
		{
			smsApi.Api.Action.CreateGroupPermission action = new smsApi.Api.Action.CreateGroupPermission(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.DeleteGroupPermission DeleteGroupPermission(string groupId, string username)
		{
			smsApi.Api.Action.DeleteGroupPermission action = new smsApi.Api.Action.DeleteGroupPermission(groupId, username);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.GetGroupPermission GetGroupPermission(string groupId, string username)
		{
			smsApi.Api.Action.GetGroupPermission action = new smsApi.Api.Action.GetGroupPermission(groupId, username);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public smsApi.Api.Action.EditGroupPermission EditGroupPermission(string groupId, string username)
		{
			smsApi.Api.Action.EditGroupPermission action = new smsApi.Api.Action.EditGroupPermission(groupId, username);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}
	}
}

