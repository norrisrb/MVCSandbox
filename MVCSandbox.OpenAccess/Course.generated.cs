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
	public partial class Course
	{
		private int _courseId;
		public virtual int CourseId
		{
			get
			{
				return this._courseId;
			}
			set
			{
				this._courseId = value;
			}
		}
		
		private string _courseName;
		public virtual string CourseName
		{
			get
			{
				return this._courseName;
			}
			set
			{
				this._courseName = value;
			}
		}
		
		private short? _yardage;
		public virtual short? Yardage
		{
			get
			{
				return this._yardage;
			}
			set
			{
				this._yardage = value;
			}
		}
		
		private string _tee;
		public virtual string Tee
		{
			get
			{
				return this._tee;
			}
			set
			{
				this._tee = value;
			}
		}
		
		private byte? _slope;
		public virtual byte? Slope
		{
			get
			{
				return this._slope;
			}
			set
			{
				this._slope = value;
			}
		}
		
		private byte? _rating;
		public virtual byte? Rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				this._rating = value;
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
		
		private string _website;
		public virtual string Website
		{
			get
			{
				return this._website;
			}
			set
			{
				this._website = value;
			}
		}
		
		private string _phone;
		public virtual string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				this._phone = value;
			}
		}
		
		private string _notes;
		public virtual string Notes
		{
			get
			{
				return this._notes;
			}
			set
			{
				this._notes = value;
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
