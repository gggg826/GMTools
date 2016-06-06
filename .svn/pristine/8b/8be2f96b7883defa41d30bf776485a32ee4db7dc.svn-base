using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FengNiao.GMTools.Database.DAL
{
	/// <summary>
	/// 数据访问类:tbl_item
	/// </summary>
	public partial class tbl_item
	{
		public tbl_item()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("item_record_id", "tbl_item"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int item_record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbl_item");
			strSql.Append(" where item_record_id=@item_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@item_record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = item_record_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FengNiao.GMTools.Database.Model.tbl_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbl_item(");
            strSql.Append("item_id,`name`,`describe`)");
			strSql.Append(" values (");
			strSql.Append("@item_id,@name,@describe)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@item_id", MySqlDbType.Int32,11),
					new MySqlParameter("@name", MySqlDbType.VarChar,255),
					new MySqlParameter("@describe", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.item_id;
			parameters[1].Value = model.name;
			parameters[2].Value = model.describe;

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
		public bool Update(FengNiao.GMTools.Database.Model.tbl_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbl_item set ");
			strSql.Append("item_id=@item_id,");
			strSql.Append("name=@name,");
			strSql.Append("describe=@describe");
			strSql.Append(" where item_record_id=@item_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@item_id", MySqlDbType.Int32,11),
					new MySqlParameter("@name", MySqlDbType.VarChar,255),
					new MySqlParameter("@describe", MySqlDbType.VarChar,255),
					new MySqlParameter("@item_record_id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.item_id;
			parameters[1].Value = model.name;
			parameters[2].Value = model.describe;
			parameters[3].Value = model.item_record_id;

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
		public bool Delete(int item_record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_item ");
			strSql.Append(" where item_record_id=@item_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@item_record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = item_record_id;

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
		public bool DeleteList(string item_record_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_item ");
			strSql.Append(" where item_record_id in ("+item_record_idlist + ")  ");
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

        public bool Clear()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_item ");
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
		public FengNiao.GMTools.Database.Model.tbl_item GetModel(int item_record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select item_record_id,item_id,name,describe from tbl_item ");
			strSql.Append(" where item_record_id=@item_record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@item_record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = item_record_id;

			FengNiao.GMTools.Database.Model.tbl_item model=new FengNiao.GMTools.Database.Model.tbl_item();
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
		public FengNiao.GMTools.Database.Model.tbl_item DataRowToModel(DataRow row)
		{
			FengNiao.GMTools.Database.Model.tbl_item model=new FengNiao.GMTools.Database.Model.tbl_item();
			if (row != null)
			{
				if(row["item_record_id"]!=null && row["item_record_id"].ToString()!="")
				{
					model.item_record_id=int.Parse(row["item_record_id"].ToString());
				}
				if(row["item_id"]!=null && row["item_id"].ToString()!="")
				{
					model.item_id=int.Parse(row["item_id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["describe"]!=null)
				{
					model.describe=row["describe"].ToString();
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
			strSql.Append("select item_record_id,item_id,`name`,`describe` ");
			strSql.Append(" FROM tbl_item ");
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
			strSql.Append("select count(1) FROM tbl_item ");
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
				strSql.Append("order by T.item_record_id desc");
			}
			strSql.Append(")AS Row, T.*  from tbl_item T ");
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
			parameters[0].Value = "tbl_item";
			parameters[1].Value = "item_record_id";
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

