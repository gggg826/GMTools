using System;
using System.Collections.Generic;
using System.Text;

namespace FengNiao.GMTools.Database.Model
{
    /// <summary>
    /// tbl_activity_config:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial  class tbl_first_recharge_config
    {
        public tbl_first_recharge_config()
		{ }
        #region Model
        private int _record_id;
        private string _id;
        private int? _isopen;
        private DateTime? _starttime;
        private DateTime? _stoptime;
        private int? _server_id;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int record_id
        {
            set { _record_id = value; }
            get { return _record_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isopen
        {
            set { _isopen = value; }
            get { return _isopen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? starttime
        {
            set { _starttime = value; }
            get { return _starttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? stoptime
        {
            set { _stoptime = value; }
            get { return _stoptime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? server_id
        {
            set { _server_id = value; }
            get { return _server_id; }
        }
        #endregion Model
    }
}
