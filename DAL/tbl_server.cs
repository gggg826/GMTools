using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
	/// <summary>
	/// 数据访问类:tbl_server
	/// </summary>
	public partial class tbl_server
	{
		public tbl_server()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long fld_record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbl_server");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = fld_record_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FengNiao.GMTools.Database.Model.tbl_server model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbl_server(");
			strSql.Append("fld_create_time,fld_modif_time,fld_deleted,fld_group_id,fld_server_id,fld_server_name,fld_recommend,fld_new,fld_server_ip)");
			strSql.Append(" values (");
			strSql.Append("@fld_create_time,@fld_modif_time,@fld_deleted,@fld_group_id,@fld_server_id,@fld_server_name,@fld_recommend,@fld_new,@fld_server_ip)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@fld_modif_time", MySqlDbType.Timestamp),
					new MySqlParameter("@fld_deleted", MySqlDbType.Int32,4),
					new MySqlParameter("@fld_group_id", MySqlDbType.Int32,11),
					new MySqlParameter("@fld_server_id", MySqlDbType.Int32,11),
					new MySqlParameter("@fld_server_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_recommend", MySqlDbType.Int32,4),
					new MySqlParameter("@fld_new", MySqlDbType.Int32,4),
					new MySqlParameter("@fld_server_ip", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.fld_create_time;
			parameters[1].Value = model.fld_modif_time;
			parameters[2].Value = model.fld_deleted;
			parameters[3].Value = model.fld_group_id;
			parameters[4].Value = model.fld_server_id;
			parameters[5].Value = model.fld_server_name;
			parameters[6].Value = model.fld_recommend;
			parameters[7].Value = model.fld_new;
			parameters[8].Value = model.fld_server_ip;

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
		public bool Update(FengNiao.GMTools.Database.Model.tbl_server model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbl_server set ");
			strSql.Append("fld_create_time=@fld_create_time,");
			strSql.Append("fld_deleted=@fld_deleted,");
			strSql.Append("fld_group_id=@fld_group_id,");
			strSql.Append("fld_server_id=@fld_server_id,");
			strSql.Append("fld_server_name=@fld_server_name,");
			strSql.Append("fld_recommend=@fld_recommend,");
			strSql.Append("fld_new=@fld_new,");
			strSql.Append("fld_server_ip=@fld_server_ip");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@fld_deleted", MySqlDbType.Int32,4),
					new MySqlParameter("@fld_group_id", MySqlDbType.Int32,11),
					new MySqlParameter("@fld_server_id", MySqlDbType.Int32,11),
					new MySqlParameter("@fld_server_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_recommend", MySqlDbType.Int32,4),
					new MySqlParameter("@fld_new", MySqlDbType.Int32,4),
					new MySqlParameter("@fld_server_ip", MySqlDbType.VarChar,255),
					new MySqlParameter("@fld_record_id", MySqlDbType.Int32,20)};
			parameters[0].Value = model.fld_create_time;
			parameters[1].Value = model.fld_deleted;
			parameters[2].Value = model.fld_group_id;
			parameters[3].Value = model.fld_server_id;
			parameters[4].Value = model.fld_server_name;
			parameters[5].Value = model.fld_recommend;
			parameters[6].Value = model.fld_new;
			parameters[7].Value = model.fld_server_ip;
			parameters[8].Value = model.fld_record_id;

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
			strSql.Append("delete from tbl_server ");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_record_id", MySqlDbType.Int32)
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
			strSql.Append("delete from tbl_server ");
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
		public FengNiao.GMTools.Database.Model.tbl_server GetModel(long fld_record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select fld_record_id,fld_create_time,fld_modif_time,fld_deleted,fld_group_id,fld_server_id,fld_server_name,fld_recommend,fld_new,fld_server_ip from tbl_server ");
			strSql.Append(" where fld_record_id=@fld_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@fld_record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = fld_record_id;

			FengNiao.GMTools.Database.Model.tbl_server model=new FengNiao.GMTools.Database.Model.tbl_server();
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
		public FengNiao.GMTools.Database.Model.tbl_server DataRowToModel(DataRow row)
		{
			FengNiao.GMTools.Database.Model.tbl_server model=new FengNiao.GMTools.Database.Model.tbl_server();
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
				if(row["fld_group_id"]!=null && row["fld_group_id"].ToString()!="")
				{
					model.fld_group_id=int.Parse(row["fld_group_id"].ToString());
				}
				if(row["fld_server_id"]!=null && row["fld_server_id"].ToString()!="")
				{
					model.fld_server_id=int.Parse(row["fld_server_id"].ToString());
				}
				if(row["fld_server_name"]!=null)
				{
					model.fld_server_name=row["fld_server_name"].ToString();
				}
				if(row["fld_recommend"]!=null && row["fld_recommend"].ToString()!="")
				{
					model.fld_recommend=int.Parse(row["fld_recommend"].ToString());
				}
				if(row["fld_new"]!=null && row["fld_new"].ToString()!="")
				{
					model.fld_new=int.Parse(row["fld_new"].ToString());
				}
				if(row["fld_server_ip"]!=null)
				{
					model.fld_server_ip=row["fld_server_ip"].ToString();
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
			strSql.Append("select fld_record_id,fld_create_time,fld_modif_time,fld_deleted,fld_group_id,fld_server_id,fld_server_name,fld_recommend,fld_new,fld_server_ip ");
			strSql.Append(" FROM tbl_server ");
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
			strSql.Append("select count(1) FROM tbl_server ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			strSql.Append(")AS Row, T.*  from tbl_server T ");
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
			parameters[0].Value = "tbl_server";
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

