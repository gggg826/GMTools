using System;
namespace FengNiao.GMTools.Database.Model
{
	/// <summary>
	/// tbl_package_upgrade:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tbl_package_upgrade
	{
		public tbl_package_upgrade()
		{}
		#region Model
		private long _fld_recordid;
		private string _fld_package_name;
		private string _fld_version;
		private int _fld_tester=1;
		private int _fld_force=0;
		private string _fld_url;
		private string _fld_description;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long fld_recordid
		{
			set{ _fld_recordid=value;}
			get{return _fld_recordid;}
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
		public int fld_tester
		{
			set{ _fld_tester=value;}
			get{return _fld_tester;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fld_force
		{
			set{ _fld_force=value;}
			get{return _fld_force;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_url
		{
			set{ _fld_url=value;}
			get{return _fld_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fld_Description
		{
			set{ _fld_description=value;}
			get{return _fld_description;}
		}
		#endregion Model

	}
}

