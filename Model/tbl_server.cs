using System;
namespace FengNiao.GMTools.Database.Model
{
	/// <summary>
	/// tbl_server:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tbl_server
	{
		public tbl_server()
		{}
		#region Model
		private long _fld_record_id;
		private DateTime _fld_create_time;
		private DateTime _fld_modif_time;
		private int _fld_deleted=0;
		private int _fld_group_id;
		private int _fld_server_id;
		private string _fld_server_name;
		private int _fld_recommend=0;
		private int _fld_new=0;
		private string _fld_server_ip;
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
		public int fld_server_id
		{
			set{ _fld_server_id=value;}
			get{return _fld_server_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_server_name
		{
			set{ _fld_server_name=value;}
			get{return _fld_server_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fld_recommend
		{
			set{ _fld_recommend=value;}
			get{return _fld_recommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fld_new
		{
			set{ _fld_new=value;}
			get{return _fld_new;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_server_ip
		{
			set{ _fld_server_ip=value;}
			get{return _fld_server_ip;}
		}
		#endregion Model

	}
}

