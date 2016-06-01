/**  版本信息模板在安装目录下，可自行修改。
* tbl_gift_code.cs
*
* 功 能： N/A
* 类 名： tbl_gift_code
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/6/26 14:32:54   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace FengNiao.GMTools.Database.Model
{
    /// <summary>
    /// tbl_gift_code:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tbl_gift_code
    {
        public tbl_gift_code()
        { }
        #region Model
        private string _fld_gift_code;
        private int _fld_gift_package;
        private DateTime _fld_createtime;
        private DateTime _fld_expiretime;
        private string _fld_channel;
        private int? _fld_exchange_svrid;
        private string _fld_exchange_roleid;
        private DateTime _fld_exchange_time;
        private int _fld_multi_use;
        private DateTime _fld_starttime;
        /// <summary>
        /// 
        /// </summary>
        public string fld_gift_code
        {
            set { _fld_gift_code = value; }
            get { return _fld_gift_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int fld_gift_package
        {
            set { _fld_gift_package = value; }
            get { return _fld_gift_package; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime fld_createtime
        {
            set { _fld_createtime = value; }
            get { return _fld_createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime fld_expiretime
        {
            set { _fld_expiretime = value; }
            get { return _fld_expiretime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fld_channel
        {
            set { _fld_channel = value; }
            get { return _fld_channel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? fld_exchange_svrid
        {
            set { _fld_exchange_svrid = value; }
            get { return _fld_exchange_svrid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fld_exchange_roleid
        {
            set { _fld_exchange_roleid = value; }
            get { return _fld_exchange_roleid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime fld_exchange_time
        {
            set { _fld_exchange_time = value; }
            get { return _fld_exchange_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int fld_multi_use
        {
            set { _fld_multi_use = value; }
            get { return _fld_multi_use; }
        }

        public DateTime fld_starttime
        {
            get { return _fld_starttime; }
            set { _fld_starttime = value; }
        }

        #endregion Model

    }
}

