using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references

namespace FengNiao.GMTools.Database.DAL
{
    /// <summary>
    /// 数据访问类:tbl_activity_config
    /// </summary>
    public partial class tbl_first_recharge_config
    {
        public tbl_first_recharge_config()
		{ }
        #region  BasicMethod
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("record_id", "tbl_first_recharge_config");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int record_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_first_recharge_config");
            strSql.Append(" where record_id=@record_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32)
			};
            parameters[0].Value = record_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_first_recharge_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_first_recharge_config(");
            strSql.Append("id,isopen,starttime,stoptime,server_id)");
            strSql.Append(" values (");
            strSql.Append("@id,@isopen,@starttime,@stoptime,@server_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.VarChar,255),
					new MySqlParameter("@isopen", MySqlDbType.Int32,4),
					new MySqlParameter("@starttime", MySqlDbType.DateTime),
					new MySqlParameter("@stoptime", MySqlDbType.DateTime),
					new MySqlParameter("@server_id", MySqlDbType.Int32,11)};
            int index = 0;
            parameters[index].Value = model.id;
            index++;
            parameters[index].Value = model.isopen;
            index++;
            parameters[index].Value = model.starttime;
            index++;
            parameters[index].Value = model.stoptime;
            index++;
            parameters[index].Value = model.server_id;

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
        public bool Update(FengNiao.GMTools.Database.Model.tbl_first_recharge_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_first_recharge_config set ");
            strSql.Append("id=@id,");
            strSql.Append("isopen=@isopen,");
            strSql.Append("starttime=@starttime,");
            strSql.Append("stoptime=@stoptime,");
            strSql.Append("server_id=@server_id");
            strSql.Append(" where record_id=@record_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.VarChar,255),
					new MySqlParameter("@isopen", MySqlDbType.Int32,4),
					new MySqlParameter("@starttime", MySqlDbType.DateTime),
					new MySqlParameter("@stoptime", MySqlDbType.DateTime),
					new MySqlParameter("@server_id", MySqlDbType.Int32,11),
					new MySqlParameter("@record_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.isopen;
            parameters[2].Value = model.starttime;
            parameters[3].Value = model.stoptime;
            parameters[4].Value = model.server_id;
            parameters[5].Value = model.record_id;

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
        public bool Delete(int record_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_first_recharge_config ");
            strSql.Append(" where record_id=@record_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32)
			};
            parameters[0].Value = record_id;

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
        public bool DeleteByServer(int server_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_first_recharge_config ");
            strSql.Append(" where server_id=@server_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@server_id", MySqlDbType.Int32)
			};
            parameters[0].Value = server_id;

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
        public bool DeleteList(string record_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_first_recharge_config ");
            strSql.Append(" where record_id in (" + record_idlist + ")  ");
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
        public FengNiao.GMTools.Database.Model.tbl_first_recharge_config GetModel(int record_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select record_id,id,isopen,starttime,stoptime,server_id from tbl_first_recharge_config ");
            strSql.Append(" where record_id=@record_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32)
			};
            parameters[0].Value = record_id;

            FengNiao.GMTools.Database.Model.tbl_first_recharge_config model = new FengNiao.GMTools.Database.Model.tbl_first_recharge_config();
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
        public FengNiao.GMTools.Database.Model.tbl_first_recharge_config DataRowToModel(DataRow row)
        {
            FengNiao.GMTools.Database.Model.tbl_first_recharge_config model = new FengNiao.GMTools.Database.Model.tbl_first_recharge_config();
            if (row != null)
            {
                if (row["record_id"] != null && row["record_id"].ToString() != "")
                {
                    model.record_id = int.Parse(row["record_id"].ToString());
                }
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = row["id"].ToString();
                }
                if (row["isopen"] != null && row["isopen"].ToString() != "")
                {
                    model.isopen = int.Parse(row["isopen"].ToString());
                }
                if (row["starttime"] != null && row["starttime"].ToString() != "")
                {
                    model.starttime = DateTime.Parse(row["starttime"].ToString());
                }
                if (row["stoptime"] != null && row["stoptime"].ToString() != "")
                {
                    model.stoptime = DateTime.Parse(row["stoptime"].ToString());
                }
                if (row["server_id"] != null && row["server_id"].ToString() != "")
                {
                    model.server_id = int.Parse(row["server_id"].ToString());
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
            strSql.Append("select record_id,id,isopen,starttime,stoptime,server_id ");
            strSql.Append(" FROM tbl_first_recharge_config ");
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
            strSql.Append("select count(1) FROM tbl_first_recharge_config ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.record_id desc");
            }
            strSql.Append(")AS Row, T.*  from tbl_first_recharge_config T ");
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
            parameters[0].Value = "tbl_activity_config";
            parameters[1].Value = "record_id";
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
