using System;
namespace FengNiao.GMTools.Database.Model
{
	/// <summary>
	/// tbl_listserver:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tbl_listserver
	{
		public tbl_listserver()
		{}
		#region Model
		private long _fld_record_id;
		private DateTime _fld_create_time;
		private DateTime _fld_modif_time;
		private int _fld_deleted=0;
		private string _fld_package_name;
		private string _fld_version;
		private string _fld_list_server_addr;
		private int _fld_list_server_port;
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
		public string fld_package_name
		{
			set{ _fld_package_name=value;}
			get{return _fld_package_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_version
		{
			set{ _fld_version=value;}
			get{return _fld_version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_list_server_addr
		{
			set{ _fld_list_server_addr=value;}
			get{return _fld_list_server_addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fld_list_server_port
		{
			set{ _fld_list_server_port=value;}
			get{return _fld_list_server_port;}
		}
		#endregion Model

	}
}

