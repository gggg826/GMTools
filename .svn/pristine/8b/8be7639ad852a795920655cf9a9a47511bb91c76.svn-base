using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
    /// <summary>
    /// 数据访问类:tbl_notice_config
    /// </summary>
    public partial class tbl_notice_config
    {
        public tbl_notice_config()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "tbl_notice_config");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_notice_config");
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
        public bool Add(FengNiao.GMTools.Database.Model.tbl_notice_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_notice_config(");
            strSql.Append("title,content,starttime,stoptime,server_id,deleted,createtime,image,rtfcontent,`type`,`interval`)");
            strSql.Append(" values (");
            strSql.Append("@title,@content,@starttime,@stoptime,@server_id,@deleted,@createtime,@image,@rtfcontent,@type,@interval)");
            MySqlParameter[] parameters = new MySqlParameter[] { new MySqlParameter("@title", MySqlDbType.VarChar, 0xff), new MySqlParameter("@content", MySqlDbType.VarChar, 0x3e8), new MySqlParameter("@starttime", MySqlDbType.DateTime), new MySqlParameter("@stoptime", MySqlDbType.DateTime), new MySqlParameter("@server_id", MySqlDbType.Int32, 11), new MySqlParameter("@deleted", MySqlDbType.Int32, 4), new MySqlParameter("@createtime", MySqlDbType.DateTime), new MySqlParameter("@image", MySqlDbType.VarChar, 0xff), new MySqlParameter("@rtfcontent", MySqlDbType.VarChar, 0x5dc), new MySqlParameter("@type", MySqlDbType.Int32), new MySqlParameter("@interval", MySqlDbType.Int32) };
            parameters[0].Value = model.title;
            parameters[1].Value = model.content;
            parameters[2].Value = model.starttime;
            parameters[3].Value = model.stoptime;
            parameters[4].Value = model.server_id;
            parameters[5].Value = model.deleted;
            parameters[6].Value = model.createtime;
            parameters[7].Value = model.image;
            parameters[8].Value = model.rtfcontent;
            parameters[9].Value = model.type;
            parameters[10].Value = model.interval;

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
        public bool Update(FengNiao.GMTools.Database.Model.tbl_notice_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_notice_config set ");
            strSql.Append("title=@title,");
            strSql.Append("content=@content,");
            strSql.Append("starttime=@starttime,");
            strSql.Append("stoptime=@stoptime,");
            strSql.Append("server_id=@server_id,");
            strSql.Append("deleted=@deleted,");
            strSql.Append("createtime=@createtime,");
            strSql.Append("image=@image,");
            strSql.Append("rtfcontent=@rtfcontent,");
            strSql.Append("`type`=@type,");
            strSql.Append("`interval`=@interval");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = new MySqlParameter[] { new MySqlParameter("@title", MySqlDbType.VarChar, 0xff), new MySqlParameter("@content", MySqlDbType.VarChar, 0x3e8), new MySqlParameter("@starttime", MySqlDbType.DateTime), new MySqlParameter("@stoptime", MySqlDbType.DateTime), new MySqlParameter("@server_id", MySqlDbType.Int32, 11), new MySqlParameter("@deleted", MySqlDbType.Int32, 4), new MySqlParameter("@createtime", MySqlDbType.DateTime), new MySqlParameter("@id", MySqlDbType.Int32, 11), new MySqlParameter("@image", MySqlDbType.VarChar, 0xff), new MySqlParameter("@rtfcontent", MySqlDbType.VarChar, 0x5dc), new MySqlParameter("@type", MySqlDbType.Int32), new MySqlParameter("@interval", MySqlDbType.Int32) };
            parameters[0].Value = model.title;
            parameters[1].Value = model.content;
            parameters[2].Value = model.starttime;
            parameters[3].Value = model.stoptime;
            parameters[4].Value = model.server_id;
            parameters[5].Value = model.deleted;
            parameters[6].Value = model.createtime;
            parameters[7].Value = model.id;
            parameters[8].Value = model.image;
            parameters[9].Value = model.rtfcontent;
            parameters[10].Value = model.type;
            parameters[11].Value = model.interval;

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
            strSql.Append("delete from tbl_notice_config ");
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
            strSql.Append("delete from tbl_notice_config ");
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
        public FengNiao.GMTools.Database.Model.tbl_notice_config GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,title,content,starttime,stoptime,server_id,deleted,createtime,image,rtfcontent,`type`,`interval` from tbl_notice_config ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = id;
            tbl_notice_config model = new tbl_notice_config();
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
        public FengNiao.GMTools.Database.Model.tbl_notice_config DataRowToModel(DataRow row)
        {
            FengNiao.GMTools.Database.Model.tbl_notice_config model = new FengNiao.GMTools.Database.Model.tbl_notice_config();
            if (row != null)
            {
                if ((row["id"] != null) && (row["id"].ToString() != ""))
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["content"] != null)
                {
                    model.content = row["content"].ToString();
                }
                if ((row["starttime"] != null) && (row["starttime"].ToString() != ""))
                {
                    model.starttime = new DateTime?(DateTime.Parse(row["starttime"].ToString()));
                }
                if ((row["stoptime"] != null) && (row["stoptime"].ToString() != ""))
                {
                    model.stoptime = new DateTime?(DateTime.Parse(row["stoptime"].ToString()));
                }
                if ((row["server_id"] != null) && (row["server_id"].ToString() != ""))
                {
                    model.server_id = new int?(int.Parse(row["server_id"].ToString()));
                }
                if ((row["deleted"] != null) && (row["deleted"].ToString() != ""))
                {
                    model.deleted = new int?(int.Parse(row["deleted"].ToString()));
                }
                if ((row["createtime"] != null) && (row["createtime"].ToString() != ""))
                {
                    model.createtime = new DateTime?(DateTime.Parse(row["createtime"].ToString()));
                }
                if ((row["image"] != null) && (row["image"].ToString() != ""))
                {
                    model.image = row["image"].ToString();
                }
                if ((row["rtfcontent"] != null) && (row["rtfcontent"].ToString() != ""))
                {
                    model.rtfcontent = row["rtfcontent"].ToString();
                }
                if ((row["type"] != null) && (row["type"].ToString() != ""))
                {
                    model.type = int.Parse(row["type"].ToString());
                }
                if ((row["interval"] != null) && (row["interval"].ToString() != ""))
                {
                    model.interval = new int?(int.Parse(row["interval"].ToString()));
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
            strSql.Append("select id,title,content,starttime,stoptime,server_id,deleted,createtime,image,rtfcontent,`type`,`interval` ");
            strSql.Append(" FROM tbl_notice_config ");
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
            strSql.Append("select count(1) FROM tbl_notice_config ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tbl_notice_config T ");
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
            parameters[0].Value = "tbl_notice_config";
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

