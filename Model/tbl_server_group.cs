using System;
namespace FengNiao.GMTools.Database.Model
{
	/// <summary>
	/// tbl_server_group:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tbl_server_group
	{
		public tbl_server_group()
		{}
		#region Model
		private long _fld_record_id;
		private DateTime _fld_create_time;
		private DateTime _fld_modif_time;
		private int _fld_deleted=0;
		private int _fld_group_id;
		private string _fld_group_name;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long fld_record_id
		{
			set{ _fld_record_id=value;}
			get{return _fld_record_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime fld_create_time
		{
			set{ _fld_create_time=value;}
			get{return _fld_create_time;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime fld_modif_time
		{
			set{ _fld_modif_time=value;}
			get{return _fld_modif_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fld_deleted
		{
			set{ _fld_deleted=value;}
			get{return _fld_deleted;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fld_group_id
		{
			set{ _fld_group_id=value;}
			get{return _fld_group_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_group_name
		{
			set{ _fld_group_name=value;}
			get{return _fld_group_name;}
		}
		#endregion Model

	}
}

