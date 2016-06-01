using System;
namespace FengNiao.GMTools.Database.Model
{
    /// <summary>
    /// tbl_notice_config:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tbl_notice_config
    {
        public tbl_notice_config()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _content;
        private string _rtfcontent;
        private DateTime? _starttime;
        private DateTime? _stoptime;
        private int? _server_id;
        private int? _deleted;
        private DateTime? _createtime;
        private int _type;
        private int? _interval;

        private string _image;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }

        public string rtfcontent
        {
            set { _rtfcontent = value; }
            get { return _rtfcontent; }
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
        /// <summary>
        /// 
        /// </summary>
        public int? deleted
        {
            set { _deleted = value; }
            get { return _deleted; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        public string image
        {
            set { _image = value; }
            get { return _image; }
        }

        public int type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int? interval
        {
            get { return _interval; }
            set { _interval = value; }
        }
        #endregion Model

    }
}

