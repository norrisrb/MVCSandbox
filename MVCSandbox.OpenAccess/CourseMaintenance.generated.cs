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
	public partial class CourseMaintenance
	{
		private int _courseMaintId;
		public virtual int CourseMaintId
		{
			get
			{
				return this._courseMaintId;
			}
			set
			{
				this._courseMaintId = value;
			}
		}
		
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
		
		private DateTime _maintenanceDate;
		public virtual DateTime MaintenanceDate
		{
			get
			{
				return this._maintenanceDate;
			}
			set
			{
				this._maintenanceDate = value;
			}
		}
		
		private int? _maintenanceType;
		public virtual int? MaintenanceType
		{
			get
			{
				return this._maintenanceType;
			}
			set
			{
				this._maintenanceType = value;
			}
		}
		
		private bool _firmDate;
		public virtual bool FirmDate
		{
			get
			{
				return this._firmDate;
			}
			set
			{
				this._firmDate = value;
			}
		}
		
	}
}
#pragma warning restore 1591
