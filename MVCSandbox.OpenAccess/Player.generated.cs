#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace MVCSandbox.OpenAccess	
{
	public partial class Player
	{
		private int _playerId;
		public virtual int PlayerId
		{
			get
			{
				return this._playerId;
			}
			set
			{
				this._playerId = value;
			}
		}
		
		private string _firstName;
		public virtual string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				this._firstName = value;
			}
		}
		
		private string _middleName;
		public virtual string MiddleName
		{
			get
			{
				return this._middleName;
			}
			set
			{
				this._middleName = value;
			}
		}
		
		private string _lastName;
		public virtual string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				this._lastName = value;
			}
		}
		
		private string _email;
		public virtual string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
			}
		}
		
		private string _address1;
		public virtual string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				this._address1 = value;
			}
		}
		
		private string _address2;
		public virtual string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				this._address2 = value;
			}
		}
		
		private string _city;
		public virtual string City
		{
			get
			{
				return this._city;
			}
			set
			{
				this._city = value;
			}
		}
		
		private string _state;
		public virtual string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		
		private string _zip;
		public virtual string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				this._zip = value;
			}
		}
		
		private string _homePhone;
		public virtual string HomePhone
		{
			get
			{
				return this._homePhone;
			}
			set
			{
				this._homePhone = value;
			}
		}
		
		private string _mobilePhone;
		public virtual string MobilePhone
		{
			get
			{
				return this._mobilePhone;
			}
			set
			{
				this._mobilePhone = value;
			}
		}
		
		private byte _handicap;
		public virtual byte Handicap
		{
			get
			{
				return this._handicap;
			}
			set
			{
				this._handicap = value;
			}
		}
		
		private bool _active;
		public virtual bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		
		private DateTime _created;
		public virtual DateTime Created
		{
			get
			{
				return this._created;
			}
			set
			{
				this._created = value;
			}
		}
		
		private DateTime _modified;
		public virtual DateTime Modified
		{
			get
			{
				return this._modified;
			}
			set
			{
				this._modified = value;
			}
		}
		
	}
}
#pragma warning restore 1591