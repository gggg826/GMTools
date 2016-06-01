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
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
    /// <summary>
    /// 数据访问类:tbl_gift_code
    /// </summary>
    public partial class tbl_gift_code
    {
        public tbl_gift_code()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string fld_gift_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_gift_code");
            strSql.Append(" where fld_gift_code=@fld_gift_code ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_gift_code", MySqlDbType.VarChar,40)			};
            parameters[0].Value = fld_gift_code;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_gift_code model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_gift_code(");
            strSql.Append("fld_gift_code,fld_gift_package,fld_createtime,fld_expiretime,fld_channel,fld_exchange_svrid,fld_exchange_roleid,fld_exchange_time,fld_multi_use,fld_starttime)");
            strSql.Append(" values (");
            strSql.Append("@fld_gift_code,@fld_gift_package,@fld_createtime,@fld_expiretime,@fld_channel,@fld_exchange_svrid,@fld_exchange_roleid,@fld_exchange_time,@fld_multi_use,@fld_starttime)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_gift_code", MySqlDbType.VarChar,40),
					new MySqlParameter("@fld_gift_package", MySqlDbType.Int32,11),
					new MySqlParameter("@fld_createtime", MySqlDbType.DateTime),
					new MySqlParameter("@fld_expiretime", MySqlDbType.DateTime),
					new MySqlParameter("@fld_channel", MySqlDbType.VarChar,50),
					new MySqlParameter("@fld_exchange_svrid", MySqlDbType.Int32,255),
					new MySqlParameter("@fld_exchange_roleid", MySqlDbType.VarChar,40),
					new MySqlParameter("@fld_exchange_time", MySqlDbType.DateTime),
                    new MySqlParameter("@fld_multi_use",MySqlDbType.Int16),
					new MySqlParameter("@fld_starttime", MySqlDbType.DateTime)
                                          };
            parameters[0].Value = model.fld_gift_code;
            parameters[1].Value = model.fld_gift_package;
            parameters[2].Value = model.fld_createtime;
            parameters[3].Value = model.fld_expiretime;
            parameters[4].Value = model.fld_channel;
            parameters[5].Value = model.fld_exchange_svrid;
            parameters[6].Value = model.fld_exchange_roleid;
            parameters[7].Value = model.fld_exchange_time;
            parameters[8].Value = model.fld_multi_use;
            parameters[9].Value = model.fld_starttime;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FengNiao.GMTools.Database.Model.tbl_gift_code model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_gift_code set ");
            strSql.Append("fld_gift_package=@fld_gift_package,");
            strSql.Append("fld_createtime=@fld_createtime,");
            strSql.Append("fld_expiretime=@fld_expiretime,");
            strSql.Append("fld_channel=@fld_channel,");
            strSql.Append("fld_exchange_svrid=@fld_exchange_svrid,");
            strSql.Append("fld_exchange_roleid=@fld_exchange_roleid,");
            strSql.Append("fld_exchange_time=@fld_exchange_time,");
            strSql.Append("fld_multi_use=@fld_multi_use ");
            strSql.Append("fld_starttime=@fld_starttime,");
            strSql.Append(" where fld_gift_code=@fld_gift_code ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_gift_package", MySqlDbType.Int32,11),
					new MySqlParameter("@fld_createtime", MySqlDbType.DateTime),
					new MySqlParameter("@fld_expiretime", MySqlDbType.DateTime),
					new MySqlParameter("@fld_channel", MySqlDbType.VarChar,50),
					new MySqlParameter("@fld_exchange_svrid", MySqlDbType.Int32,255),
					new MySqlParameter("@fld_exchange_roleid", MySqlDbType.VarChar,40),
					new MySqlParameter("@fld_exchange_time", MySqlDbType.DateTime),
					new MySqlParameter("@fld_gift_code", MySqlDbType.VarChar,40),
                    new MySqlParameter("@fld_multi_use",MySqlDbType.Int16),
					new MySqlParameter("@fld_starttime", MySqlDbType.DateTime)};
            parameters[0].Value = model.fld_gift_package;
            parameters[1].Value = model.fld_createtime;
            parameters[2].Value = model.fld_expiretime;
            parameters[3].Value = model.fld_channel;
            parameters[4].Value = model.fld_exchange_svrid;
            parameters[5].Value = model.fld_exchange_roleid;
            parameters[6].Value = model.fld_exchange_time;
            parameters[7].Value = model.fld_gift_code;
            parameters[8].Value = model.fld_multi_use;
            parameters[9].Value = model.fld_starttime;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string fld_gift_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_gift_code ");
            strSql.Append(" where fld_gift_code=@fld_gift_code ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_gift_code", MySqlDbType.VarChar,40)			};
            parameters[0].Value = fld_gift_code;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string fld_gift_codelist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_gift_code ");
            strSql.Append(" where fld_gift_code in (" + fld_gift_codelist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FengNiao.GMTools.Database.Model.tbl_gift_code GetModel(string fld_gift_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select fld_gift_code,fld_gift_package,fld_createtime,fld_expiretime,fld_channel,fld_exchange_svrid,fld_exchange_roleid,fld_exchange_time,fld_multi_use,fld_starttime from tbl_gift_code ");
            strSql.Append(" where fld_gift_code=@fld_gift_code ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_gift_code", MySqlDbType.VarChar,40)			};
            parameters[0].Value = fld_gift_code;

            FengNiao.GMTools.Database.Model.tbl_gift_code model = new FengNiao.GMTools.Database.Model.tbl_gift_code();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FengNiao.GMTools.Database.Model.tbl_gift_code DataRowToModel(DataRow row)
        {
            FengNiao.GMTools.Database.Model.tbl_gift_code model = new FengNiao.GMTools.Database.Model.tbl_gift_code();
            if (row != null)
            {
                if (row["fld_gift_code"] != null)
                {
                    model.fld_gift_code = row["fld_gift_code"].ToString();
                }
                if (row["fld_gift_package"] != null && row["fld_gift_package"].ToString() != "")
                {
                    model.fld_gift_package = int.Parse(row["fld_gift_package"].ToString());
                }
                if (row["fld_createtime"] != null && row["fld_createtime"].ToString() != "")
                {
                    model.fld_createtime = DateTime.Parse(row["fld_createtime"].ToString());
                }
                if (row["fld_expiretime"] != null && row["fld_expiretime"].ToString() != "")
                {
                    model.fld_expiretime = DateTime.Parse(row["fld_expiretime"].ToString());
                }
                if (row["fld_channel"] != null)
                {
                    model.fld_channel = row["fld_channel"].ToString();
                }
                if (row["fld_exchange_svrid"] != null && row["fld_exchange_svrid"].ToString() != "")
                {
                    model.fld_exchange_svrid = int.Parse(row["fld_exchange_svrid"].ToString());
                }
                if (row["fld_exchange_roleid"] != null)
                {
                    model.fld_exchange_roleid = row["fld_exchange_roleid"].ToString();
                }
                if (row["fld_exchange_time"] != null && row["fld_exchange_time"].ToString() != "")
                {
                    model.fld_exchange_time = DateTime.Parse(row["fld_exchange_time"].ToString());
                }
                if (row["fld_multi_use"] != null && row["fld_multi_use"].ToString() != "")
                {
                    model.fld_multi_use = int.Parse(row["fld_multi_use"].ToString());
                }
                if (row["fld_starttime"] != null && row["fld_starttime"].ToString() != "")
                {
                    model.fld_starttime = DateTime.Parse(row["fld_starttime"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select fld_gift_code,fld_gift_package,fld_createtime,fld_expiretime,fld_channel,fld_exchange_svrid,fld_exchange_roleid,fld_exchange_time,fld_multi_use,fld_starttime ");
            strSql.Append(" FROM tbl_gift_code ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tbl_gift_code ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.fld_gift_code desc");
            }
            strSql.Append(")AS Row, T.*  from tbl_gift_code T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "tbl_gift_code";
            parameters[1].Value = "fld_gift_code";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

