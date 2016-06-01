using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
	/// <summary>
	/// 数据访问类:tbl_notice
	/// </summary>
	public partial class tbl_notice
	{
		public tbl_notice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long fld_record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbl_notice");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_record_id", MySqlDbType.Int64)
			};
			parameters[0].Value = fld_record_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FengNiao.GMTools.Database.Model.tbl_notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbl_notice(");
			strSql.Append("fld_create_time,fld_modif_time,fld_deleted,fld_package_name,fld_version,fld_tester_notice,fld_notice)");
			strSql.Append(" values (");
			strSql.Append("@fld_create_time,@fld_modif_time,@fld_deleted,@fld_package_name,@fld_version,@fld_tester_notice,@fld_notice)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@fld_modif_time", MySqlDbType.Timestamp),
					new MySqlParameter("@fld_deleted", MySqlDbType.Byte,4),
					new MySqlParameter("@fld_package_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_version", MySqlDbType.VarChar,10),
					new MySqlParameter("@fld_tester_notice", MySqlDbType.VarChar,2000),
					new MySqlParameter("@fld_notice", MySqlDbType.VarChar,2000)};
			parameters[0].Value = model.fld_create_time;
			parameters[1].Value = model.fld_modif_time;
			parameters[2].Value = model.fld_deleted;
			parameters[3].Value = model.fld_package_name;
			parameters[4].Value = model.fld_version;
			parameters[5].Value = model.fld_tester_notice;
			parameters[6].Value = model.fld_notice;

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
		public bool Update(FengNiao.GMTools.Database.Model.tbl_notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbl_notice set ");
			strSql.Append("fld_create_time=@fld_create_time,");
			strSql.Append("fld_deleted=@fld_deleted,");
			strSql.Append("fld_package_name=@fld_package_name,");
			strSql.Append("fld_version=@fld_version,");
			strSql.Append("fld_tester_notice=@fld_tester_notice,");
			strSql.Append("fld_notice=@fld_notice");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@fld_deleted", MySqlDbType.Byte,4),
					new MySqlParameter("@fld_package_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_version", MySqlDbType.VarChar,10),
					new MySqlParameter("@fld_tester_notice", MySqlDbType.VarChar,2000),
					new MySqlParameter("@fld_notice", MySqlDbType.VarChar,2000),
					new MySqlParameter("@fld_record_id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.fld_create_time;
			parameters[1].Value = model.fld_deleted;
			parameters[2].Value = model.fld_package_name;
			parameters[3].Value = model.fld_version;
			parameters[4].Value = model.fld_tester_notice;
			parameters[5].Value = model.fld_notice;
			parameters[6].Value = model.fld_record_id;

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
		public bool Delete(long fld_record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_notice ");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_record_id", MySqlDbType.Int64)
			};
			parameters[0].Value = fld_record_id;

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
		public bool DeleteList(string fld_record_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_notice ");
			strSql.Append(" where fld_record_id in ("+fld_record_idlist + ")  ");
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
		public FengNiao.GMTools.Database.Model.tbl_notice GetModel(long fld_record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select fld_record_id,fld_create_time,fld_modif_time,fld_deleted,fld_package_name,fld_version,fld_tester_notice,fld_notice from tbl_notice ");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_record_id", MySqlDbType.Int64)
			};
			parameters[0].Value = fld_record_id;

			FengNiao.GMTools.Database.Model.tbl_notice model=new FengNiao.GMTools.Database.Model.tbl_notice();
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
		public FengNiao.GMTools.Database.Model.tbl_notice DataRowToModel(DataRow row)
		{
			FengNiao.GMTools.Database.Model.tbl_notice model=new FengNiao.GMTools.Database.Model.tbl_notice();
			if (row != null)
			{
				if(row["fld_record_id"]!=null && row["fld_record_id"].ToString()!="")
				{
					model.fld_record_id=long.Parse(row["fld_record_id"].ToString());
				}
				if(row["fld_create_time"]!=null && row["fld_create_time"].ToString()!="")
				{
					model.fld_create_time=DateTime.Parse(row["fld_create_time"].ToString());
				}
				if(row["fld_modif_time"]!=null && row["fld_modif_time"].ToString()!="")
				{
					model.fld_modif_time=DateTime.Parse(row["fld_modif_time"].ToString());
				}
				if(row["fld_deleted"]!=null && row["fld_deleted"].ToString()!="")
				{
					model.fld_deleted=int.Parse(row["fld_deleted"].ToString());
				}
				if(row["fld_package_name"]!=null)
				{
					model.fld_package_name=row["fld_package_name"].ToString();
				}
				if(row["fld_version"]!=null)
				{
					model.fld_version=row["fld_version"].ToString();
				}
				if(row["fld_tester_notice"]!=null)
				{
					model.fld_tester_notice=row["fld_tester_notice"].ToString();
				}
				if(row["fld_notice"]!=null)
				{
					model.fld_notice=row["fld_notice"].ToString();
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
			strSql.Append("select fld_record_id,fld_create_time,fld_modif_time,fld_deleted,fld_package_name,fld_version,fld_tester_notice,fld_notice ");
			strSql.Append(" FROM tbl_notice ");
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
			strSql.Append("select count(1) FROM tbl_notice ");
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
				strSql.Append("order by T.fld_record_id desc");
			}
			strSql.Append(")AS Row, T.*  from tbl_notice T ");
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
			parameters[0].Value = "tbl_notice";
			parameters[1].Value = "fld_record_id";
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

