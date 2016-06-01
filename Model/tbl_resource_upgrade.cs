using System;
namespace FengNiao.GMTools.Database.Model
{
    /// <summary>
    /// tbl_resource_upgrade:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tbl_resource_upgrade
    {
        public tbl_resource_upgrade()
        { }
        #region Model
        private long _fld_recordid;
        private string _fld_package_name;
        private string _fld_version;
        private string _fld_resource_type;
        private string _fld_url_ver;
        private string _fld_url;
        private string _fld_test_url_ver;
        private string _fld_test_url;
        private string _fld_description;

        /// <summary>
        /// auto_increment
        /// </summary>
        public long fld_recordid
        {
            set { _fld_recordid = value; }
            get { return _fld_recordid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fld_package_name
        {
            set { _fld_package_name = value; }
            get { return _fld_package_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fld_version
        {
            set { _fld_version = value; }
            get { return _fld_version; }
        }

        public string fld_resource_type
        {
            get { return _fld_resource_type; }
            set { _fld_resource_type = value; }
        }

        public string fld_url_ver
        {
            get { return _fld_url_ver; }
            set { _fld_url_ver = value; }
        }

        public string fld_url
        {
            get { return _fld_url; }
            set { _fld_url = value; }
        }

        public string fld_test_url_ver
        {
            get { return _fld_test_url_ver; }
            set { _fld_test_url_ver = value; }
        }

        public string fld_test_url
        {
            get { return _fld_test_url; }
            set { _fld_test_url = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string fld_Description
        {
            set { _fld_description = value; }
            get { return _fld_description; }
        }

        #endregion Model

    }
}

