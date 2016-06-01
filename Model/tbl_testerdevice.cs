using System;
namespace FengNiao.GMTools.Database.Model
{
	/// <summary>
	/// tbl_testerdevice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tbl_testerdevice
	{
		public tbl_testerdevice()
		{}
		#region Model
		private long _fld_record_id;
		private DateTime _fld_create_time;
		private DateTime _fld_modif_time;
		private int _fld_deleted=0;
		private string _fld_name;
		private string _fld_value;
		private string _fld_declare;
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
		public string fld_name
		{
			set{ _fld_name=value;}
			get{return _fld_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_value
		{
			set{ _fld_value=value;}
			get{return _fld_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_declare
		{
			set{ _fld_declare=value;}
			get{return _fld_declare;}
		}
		#endregion Model

	}
}

