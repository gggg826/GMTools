using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
    /// <summary>
    /// 数据访问类:tbl_mail
    /// </summary>
    public partial class tbl_mail
    {
        public tbl_mail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "tbl_mail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_mail");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_mail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_mail(");
            strSql.Append("mail_id,mail_type,server_id,role_id,retention,starttime,stoptime,items,craetetime,title,content,optype,channel,minversion,maxversion,minlevel,maxlevel,mindatetime,maxdatetime)");
            strSql.Append(" values (");
            strSql.Append("@mail_id,@mail_type,@server_id,@role_id,@retention,@starttime,@stoptime,@items,@craetetime,@title,@content,@optype,@channel,@minversion,@maxversion,@minlevel,@maxlevel,@mindatetime,@maxdatetime)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mail_id", MySqlDbType.UInt64,20),
					new MySqlParameter("@mail_type", MySqlDbType.Int32,4),
					new MySqlParameter("@server_id", MySqlDbType.Int32,11),
					new MySqlParameter("@role_id", MySqlDbType.VarChar,255),
					new MySqlParameter("@retention", MySqlDbType.Int32,11),
					new MySqlParameter("@starttime", MySqlDbType.DateTime),
					new MySqlParameter("@stoptime", MySqlDbType.DateTime),
					new MySqlParameter("@items", MySqlDbType.VarChar,255),
					new MySqlParameter("@craetetime", MySqlDbType.DateTime),
					new MySqlParameter("@title", MySqlDbType.VarChar,255),
					new MySqlParameter("@content", MySqlDbType.VarChar,255),
					new MySqlParameter("@optype", MySqlDbType.Int32,11),
					new MySqlParameter("@channel", MySqlDbType.VarChar,255),
					new MySqlParameter("@minversion", MySqlDbType.VarChar,255),
					new MySqlParameter("@maxversion", MySqlDbType.VarChar,255),
					new MySqlParameter("@minlevel", MySqlDbType.Int32,11),
					new MySqlParameter("@maxlevel", MySqlDbType.Int32,11),
					new MySqlParameter("@mindatetime", MySqlDbType.DateTime),
					new MySqlParameter("@maxdatetime", MySqlDbType.DateTime)
                                          };
            parameters[0].Value = model.mail_id;
            parameters[1].Value = model.mail_type;
            parameters[2].Value = model.server_id;
            parameters[3].Value = model.role_id;
            parameters[4].Value = model.retention;
            parameters[5].Value = model.starttime;
            parameters[6].Value = model.stoptime;
            parameters[7].Value = model.items;
            parameters[8].Value = model.craetetime;
            parameters[9].Value = model.title;
            parameters[10].Value = model.content;
            parameters[11].Value = model.optype;
            parameters[12].Value = model.channel;
            parameters[13].Value = model.minversion;
            parameters[14].Value = model.maxversion;
            parameters[15].Value = model.minlevel;
            parameters[16].Value = model.maxlevel;
            parameters[17].Value = model.mindatetime;
            parameters[18].Value = model.maxdatetime;

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
        public bool Update(FengNiao.GMTools.Database.Model.tbl_mail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_mail set ");
            strSql.Append("mail_id=@mail_id,");
            strSql.Append("mail_type=@mail_type,");
            strSql.Append("server_id=@server_id,");
            strSql.Append("role_id=@role_id,");
            strSql.Append("retention=@retention,");
            strSql.Append("starttime=@starttime,");
            strSql.Append("stoptime=@stoptime,");
            strSql.Append("items=@items,");
            strSql.Append("craetetime=@craetetime,");
            strSql.Append("title=@title,");
            strSql.Append("content=@content,");
            strSql.Append("optype=@optype");
            strSql.Append("channel=@channel");
            strSql.Append("minversion=@minversion");
            strSql.Append("maxversion=@maxversion");
            strSql.Append("minlevel=@minlevel");
            strSql.Append("maxlevel=@maxlevel");
            strSql.Append("mindatetime=@mindatetime");
            strSql.Append("maxdatetime=@maxdatetime");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mail_id", MySqlDbType.UInt64,20),
					new MySqlParameter("@mail_type", MySqlDbType.Int32,4),
					new MySqlParameter("@server_id", MySqlDbType.Int32,11),
					new MySqlParameter("@role_id", MySqlDbType.VarChar,255),
					new MySqlParameter("@retention", MySqlDbType.Int32,11),
					new MySqlParameter("@starttime", MySqlDbType.DateTime),
					new MySqlParameter("@stoptime", MySqlDbType.DateTime),
					new MySqlParameter("@items", MySqlDbType.VarChar,255),
					new MySqlParameter("@craetetime", MySqlDbType.DateTime),
					new MySqlParameter("@title", MySqlDbType.VarChar,255),
					new MySqlParameter("@content", MySqlDbType.VarChar,255),
					new MySqlParameter("@optype", MySqlDbType.Int32,11),
					new MySqlParameter("@channel", MySqlDbType.VarChar,255),
					new MySqlParameter("@minversion", MySqlDbType.VarChar,255),
					new MySqlParameter("@maxversion", MySqlDbType.VarChar,255),
					new MySqlParameter("@minlevel", MySqlDbType.Int32,11),
					new MySqlParameter("@maxlevel", MySqlDbType.Int32,11),
					new MySqlParameter("@mindatetime", MySqlDbType.DateTime),
					new MySqlParameter("@maxdatetime", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.mail_id;
            parameters[1].Value = model.mail_type;
            parameters[2].Value = model.server_id;
            parameters[3].Value = model.role_id;
            parameters[4].Value = model.retention;
            parameters[5].Value = model.starttime;
            parameters[6].Value = model.stoptime;
            parameters[7].Value = model.items;
            parameters[8].Value = model.craetetime;
            parameters[9].Value = model.title;
            parameters[10].Value = model.content;
            parameters[11].Value = model.optype;
            parameters[12].Value = model.channel;
            parameters[13].Value = model.minversion;
            parameters[14].Value = model.maxversion;
            parameters[15].Value = model.minlevel;
            parameters[16].Value = model.maxlevel;
            parameters[17].Value = model.mindatetime;
            parameters[18].Value = model.maxdatetime;
            parameters[19].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_mail ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_mail ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public FengNiao.GMTools.Database.Model.tbl_mail GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,mail_id,mail_type,server_id,role_id,retention,starttime,stoptime,items,craetetime,title,content,optype,channel,minversion,maxversion,minlevel,maxlevel,mindatetime,maxdatetime from tbl_mail ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            FengNiao.GMTools.Database.Model.tbl_mail model = new FengNiao.GMTools.Database.Model.tbl_mail();
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
        public FengNiao.GMTools.Database.Model.tbl_mail DataRowToModel(DataRow row)
        {
            FengNiao.GMTools.Database.Model.tbl_mail model = new FengNiao.GMTools.Database.Model.tbl_mail();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["mail_id"] != null && row["mail_id"].ToString() != "")
                {
                    model.mail_id = long.Parse(row["mail_id"].ToString());
                }
                if (row["mail_type"] != null && row["mail_type"].ToString() != "")
                {
                    model.mail_type = int.Parse(row["mail_type"].ToString());
                }
                if (row["server_id"] != null && row["server_id"].ToString() != "")
                {
                    model.server_id = int.Parse(row["server_id"].ToString());
                }
                if (row["role_id"] != null)
                {
                    model.role_id = row["role_id"].ToString();
                }
                if (row["retention"] != null && row["retention"].ToString() != "")
                {
                    model.retention = int.Parse(row["retention"].ToString());
                }
                if (row["starttime"] != null && row["starttime"].ToString() != "")
                {
                    model.starttime = DateTime.Parse(row["starttime"].ToString());
                }
                if (row["stoptime"] != null && row["stoptime"].ToString() != "")
                {
                    model.stoptime = DateTime.Parse(row["stoptime"].ToString());
                }
                if (row["items"] != null)
                {
                    model.items = row["items"].ToString();
                }
                if (row["craetetime"] != null && row["craetetime"].ToString() != "")
                {
                    model.craetetime = DateTime.Parse(row["craetetime"].ToString());
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["content"] != null)
                {
                    model.content = row["content"].ToString();
                }
                if (row["optype"] != null && row["optype"].ToString() != "")
                {
                    model.optype = int.Parse(row["optype"].ToString());
                }
                if (row["channel"] != null)
                {
                    model.channel = row["channel"].ToString();
                }
                if (row["minversion"] != null)
                {
                    model.minversion = row["minversion"].ToString();
                }
                if (row["maxversion"] != null)
                {
                    model.maxversion = row["maxversion"].ToString();
                }
                if (row["minlevel"] != null && row["minlevel"].ToString() != "")
                {
                    model.minlevel = int.Parse(row["minlevel"].ToString());
                }
                if (row["maxlevel"] != null && row["maxlevel"].ToString() != "")
                {
                    model.maxlevel = int.Parse(row["maxlevel"].ToString());
                }
                if (row["mindatetime"] != null && row["mindatetime"].ToString() != "")
                {
                    model.mindatetime = DateTime.Parse(row["mindatetime"].ToString());
                }
                if (row["maxdatetime"] != null && row["maxdatetime"].ToString() != "")
                {
                    model.maxdatetime = DateTime.Parse(row["maxdatetime"].ToString());
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
            strSql.Append("select id,mail_id,mail_type,server_id,role_id,retention,starttime,stoptime,items,craetetime,title,content,optype,channel,minversion,maxversion,minlevel,maxlevel,mindatetime,maxdatetime ");
            strSql.Append(" FROM tbl_mail ");
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
            strSql.Append("select count(1) FROM tbl_mail ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tbl_mail T ");
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
            parameters[0].Value = "tbl_mail";
            parameters[1].Value = "id";
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

