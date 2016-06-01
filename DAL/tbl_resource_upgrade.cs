using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
    /// <summary>
    /// 数据访问类:tbl_resource_upgrade
    /// </summary>
    public partial class tbl_resource_upgrade
    {
        public tbl_resource_upgrade()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long fld_recordid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_resource_upgrade");
            strSql.Append(" where fld_recordid=@fld_recordid");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_recordid", MySqlDbType.Int64)
			};
            parameters[0].Value = fld_recordid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_resource_upgrade model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_resource_upgrade(");
            strSql.Append("fld_package_name,fld_version,fld_resource_type,fld_url_ver,fld_url,fld_test_url_ver,fld_test_url,fld_Description)");
            strSql.Append(" values (");
            strSql.Append("@fld_package_name,@fld_version,@fld_resource_type,@fld_url_ver,@fld_url,@fld_test_url_ver,@fld_test_url,@fld_Description)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_package_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_version", MySqlDbType.VarChar,10),
                    new MySqlParameter("@fld_resource_type",MySqlDbType.VarChar,40), 
                    new MySqlParameter("@fld_url_ver",MySqlDbType.VarChar,50), 
                    new MySqlParameter("@fld_url",MySqlDbType.VarChar,255), 
                    new MySqlParameter("@fld_test_url_ver",MySqlDbType.VarChar,50), 
                    new MySqlParameter("@fld_test_url",MySqlDbType.VarChar,255), 
                    new MySqlParameter("@fld_Description", MySqlDbType.VarChar,2000)};
            parameters[0].Value = model.fld_package_name;
            parameters[1].Value = model.fld_version;
            parameters[2].Value = model.fld_resource_type;
            parameters[3].Value = model.fld_url_ver;
            parameters[4].Value = model.fld_url;
            parameters[5].Value = model.fld_test_url_ver;
            parameters[6].Value = model.fld_test_url;
            parameters[7].Value = model.fld_Description;

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
        public bool Update(FengNiao.GMTools.Database.Model.tbl_resource_upgrade model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_resource_upgrade set ");
            strSql.Append("fld_package_name=@fld_package_name,");
            strSql.Append("fld_version=@fld_version,");
            strSql.Append("fld_resource_type=@fld_resource_type, ");
            strSql.Append("fld_url_ver=@fld_url_ver, ");
            strSql.Append("fld_url=@fld_url, ");
            strSql.Append("fld_test_url_ver=@fld_test_url_ver, ");
            strSql.Append("fld_test_url=@fld_test_url, ");
            strSql.Append("fld_Description=@fld_Description");
            strSql.Append(" where fld_recordid=@fld_recordid");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_package_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_version", MySqlDbType.VarChar,10),
                    new MySqlParameter("@fld_resource_type",MySqlDbType.VarChar,40), 
                    new MySqlParameter("@fld_url_ver",MySqlDbType.VarChar,50), 
                    new MySqlParameter("@fld_url",MySqlDbType.VarChar,255), 
                    new MySqlParameter("@fld_test_url_ver",MySqlDbType.VarChar,50), 
                    new MySqlParameter("@fld_test_url",MySqlDbType.VarChar,255), 
					new MySqlParameter("@fld_Description", MySqlDbType.VarChar,2000),
					new MySqlParameter("@fld_recordid", MySqlDbType.Int64,20)};
            parameters[0].Value = model.fld_package_name;
            parameters[1].Value = model.fld_version;
            parameters[2].Value = model.fld_resource_type;
            parameters[3].Value = model.fld_url_ver;
            parameters[4].Value = model.fld_url;
            parameters[5].Value = model.fld_test_url_ver;
            parameters[6].Value = model.fld_test_url;
            parameters[7].Value = model.fld_Description;
            parameters[8].Value = model.fld_recordid;

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
        public bool Delete(long fld_recordid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_resource_upgrade ");
            strSql.Append(" where fld_recordid=@fld_recordid");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_recordid", MySqlDbType.Int64)
			};
            parameters[0].Value = fld_recordid;

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
        public bool DeleteList(string fld_recordidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_resource_upgrade ");
            strSql.Append(" where fld_recordid in (" + fld_recordidlist + ")  ");
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
        public FengNiao.GMTools.Database.Model.tbl_resource_upgrade GetModel(long fld_recordid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select fld_recordid,fld_package_name,fld_version,fld_resource_type,fld_url_ver,fld_url,fld_test_url_ver,fld_test_url,fld_Description from tbl_resource_upgrade ");
            strSql.Append(" where fld_recordid=@fld_recordid");
            MySqlParameter[] parameters = {
					new MySqlParameter("@fld_recordid", MySqlDbType.Int64)
			};
            parameters[0].Value = fld_recordid;

            FengNiao.GMTools.Database.Model.tbl_resource_upgrade model = new FengNiao.GMTools.Database.Model.tbl_resource_upgrade();
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
        public FengNiao.GMTools.Database.Model.tbl_resource_upgrade DataRowToModel(DataRow row)
        {
            FengNiao.GMTools.Database.Model.tbl_resource_upgrade model = new FengNiao.GMTools.Database.Model.tbl_resource_upgrade();
            if (row != null)
            {
                if (row["fld_recordid"] != null && row["fld_recordid"].ToString() != "")
                {
                    model.fld_recordid = long.Parse(row["fld_recordid"].ToString());
                }
                if (row["fld_package_name"] != null)
                {
                    model.fld_package_name = row["fld_package_name"].ToString();
                }
                if (row["fld_version"] != null)
                {
                    model.fld_version = row["fld_version"].ToString();
                }
                if (row["fld_resource_type"] != null)
                {
                    model.fld_resource_type = row["fld_resource_type"].ToString();
                }
                if (row["fld_url_ver"] != null)
                {
                    model.fld_url_ver = row["fld_url_ver"].ToString();
                }
                if (row["fld_url"] != null)
                {
                    model.fld_url = row["fld_url"].ToString();
                }
                if (row["fld_test_url_ver"] != null)
                {
                    model.fld_test_url_ver = row["fld_test_url_ver"].ToString();
                }
                if (row["fld_test_url"] != null)
                {
                    model.fld_test_url = row["fld_test_url"].ToString();
                }
                if (row["fld_Description"] != null)
                {
                    model.fld_Description = row["fld_Description"].ToString();
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
            strSql.Append("select fld_recordid,fld_package_name,fld_version,fld_resource_type,fld_url_ver,fld_url,fld_test_url_ver,fld_test_url,fld_Description ");
            strSql.Append(" FROM tbl_resource_upgrade ");
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
            strSql.Append("select count(1) FROM tbl_resource_upgrade ");
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
                strSql.Append("order by T.fld_recordid desc");
            }
            strSql.Append(")AS Row, T.*  from tbl_resource_upgrade T ");
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
            parameters[0].Value = "tbl_resource_upgrade";
            parameters[1].Value = "fld_recordid";
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

