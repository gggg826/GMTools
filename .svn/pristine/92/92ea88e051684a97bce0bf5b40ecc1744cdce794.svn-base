using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
	/// <summary>
	/// 数据访问类:tbl_user
	/// </summary>
	public partial class tbl_user
	{
		public tbl_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("user_id", "tbl_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbl_user");
			strSql.Append(" where user_id=@user_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
			parameters[0].Value = user_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FengNiao.GMTools.Database.Model.tbl_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbl_user(");
			strSql.Append("user_name,password,authority,is_enabled)");
			strSql.Append(" values (");
			strSql.Append("@user_name,@password,@authority,@is_enabled)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@user_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@password", MySqlDbType.VarChar,255),
					new MySqlParameter("@authority", MySqlDbType.Int32,32),
					new MySqlParameter("@is_enabled", MySqlDbType.Int32,4)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.password;
			parameters[2].Value = model.authority;
			parameters[3].Value = model.is_enabled;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(FengNiao.GMTools.Database.Model.tbl_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbl_user set ");
			strSql.Append("user_name=@user_name,");
			strSql.Append("password=@password,");
			strSql.Append("authority=@authority,");
			strSql.Append("is_enabled=@is_enabled");
			strSql.Append(" where user_id=@user_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@user_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@password", MySqlDbType.VarChar,255),
					new MySqlParameter("@authority", MySqlDbType.Int32,32),
					new MySqlParameter("@is_enabled", MySqlDbType.Int32,4),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.password;
			parameters[2].Value = model.authority;
			parameters[3].Value = model.is_enabled;
			parameters[4].Value = model.user_id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_user ");
			strSql.Append(" where user_id=@user_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
			parameters[0].Value = user_id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string user_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_user ");
			strSql.Append(" where user_id in ("+user_idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public FengNiao.GMTools.Database.Model.tbl_user GetModel(int user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select user_id,user_name,password,authority,is_enabled from tbl_user ");
			strSql.Append(" where user_id=@user_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
			parameters[0].Value = user_id;

			FengNiao.GMTools.Database.Model.tbl_user model=new FengNiao.GMTools.Database.Model.tbl_user();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public FengNiao.GMTools.Database.Model.tbl_user DataRowToModel(DataRow row)
		{
			FengNiao.GMTools.Database.Model.tbl_user model=new FengNiao.GMTools.Database.Model.tbl_user();
			if (row != null)
			{
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(row["user_id"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["authority"]!=null && row["authority"].ToString()!="")
				{
					model.authority=int.Parse(row["authority"].ToString());
				}
				if(row["is_enabled"]!=null && row["is_enabled"].ToString()!="")
				{
					model.is_enabled=int.Parse(row["is_enabled"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select user_id,user_name,password,authority,is_enabled ");
			strSql.Append(" FROM tbl_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tbl_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.user_id desc");
			}
			strSql.Append(")AS Row, T.*  from tbl_user T ");
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
			parameters[0].Value = "tbl_user";
			parameters[1].Value = "user_id";
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

