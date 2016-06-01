using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Maticsoft.DBUtility;//Please add references

namespace FengNiao.GMTools.Database.DAL
{
    public partial class tbl_proto_cout
    {
        public tbl_proto_cout()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbl_proto_cout");
			strSql.Append(" where record_id=@record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = record_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_proto_cout model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_proto_cout(");
            strSql.Append("record_id,proto_id,button_name)");
            strSql.Append(" values (");
            strSql.Append("default,@proto_id,@button_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@proto_id", MySqlDbType.Int32,11),
					new MySqlParameter("@button_name", MySqlDbType.VarChar,255)
                                          };
            int index = 0;
            parameters[index++].Value = model.proteo_id;
            parameters[index++].Value = model.button_name;

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
        //public bool Update(FengNiao.GMTools.Database.Model.tbl_proto_cout model)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("update tbl_proto_cout set ");
        //    strSql.Append("kindReward=@kindReward,");
        //    strSql.Append("rewardName1=@rewardName1,");
        //    strSql.Append("rewardCount1=@rewardCount1,");
        //    strSql.Append("rewardName2=@rewardName2,");
        //    strSql.Append("rewardCount2=@rewardCount2,");
        //    strSql.Append("rewardName3=@rewardName3,");
        //    strSql.Append("rewardCount3=@rewardCount3,");
        //    strSql.Append("rewardName4=@rewardName4,");
        //    strSql.Append("rewardCount4=@rewardCount4");
        //    strSql.Append(" where date=@date");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@kindReward", MySqlDbType.Int32,11),
        //            new MySqlParameter("@rewardName1", MySqlDbType.Int32,11),
        //            new MySqlParameter("@rewardCount1", MySqlDbType.Int32,11),
        //            new MySqlParameter("@rewardName2", MySqlDbType.Int32,11),
        //            new MySqlParameter("@rewardCount2", MySqlDbType.Int32,11),					
        //            new MySqlParameter("@rewardName3", MySqlDbType.Int32,11),
        //            new MySqlParameter("@rewardCount3", MySqlDbType.Int32,11),					
        //            new MySqlParameter("@rewardName4", MySqlDbType.Int32,11),
        //            new MySqlParameter("@rewardCount4", MySqlDbType.Int32,11),
        //            new MySqlParameter("@date", MySqlDbType.Int32,11)};
        //    int index = 0;
        //    parameters[index++].Value = model.kindReward;
        //    parameters[index++].Value = model.rewardName1;
        //    parameters[index++].Value = model.rewardCount1;
        //    parameters[index++].Value = model.rewardName2;
        //    parameters[index++].Value = model.rewardCount2;
        //    parameters[index++].Value = model.rewardName3;
        //    parameters[index++].Value = model.rewardCount3;
        //    parameters[index++].Value = model.rewardName4;
        //    parameters[index++].Value = model.rewardCount4;
        //    parameters[index++].Value = model.date;

        //    int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        //public bool Delete(int record_id)
        //{
			
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("delete from tbl_proto_cout ");
        //    strSql.Append(" where record_id=@record_id");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@record_id", MySqlDbType.Int32)
        //    };
        //    parameters[0].Value = record_id;

        //    int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        



		/// <summary>
		/// 删除一条数据
		/// </summary>
        //public bool DeleteByServer(int server_id)
        //{
			
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("delete from tbl_proto_cout ");
        //    strSql.Append(" where serverID=@serverID");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@serverID", MySqlDbType.Int32)
        //    };
        //    parameters[0].Value = server_id;

        //    int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

		/// <summary>
		/// 批量删除数据
		/// </summary>
        //public bool DeleteList(string record_idlist)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("delete from tbl_proto_cout ");
        //    strSql.Append(" where record_id in (" + record_idlist + ")  ");
        //    int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        //public FengNiao.GMTools.Database.Model.tbl_proto_cout GetModel(int record_id)
        //{
			
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select record_id,serverID,date,kindReward,rewardName1,rewardCount1,rewardName2,rewardCount2,rewardName3,rewardCount3,rewardName4,rewardCount4 from tbl_proto_cout ");
        //    strSql.Append(" where record_id=@record_id");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@record_id", MySqlDbType.Int32)
        //    };
        //    parameters[0].Value = record_id;

        //    FengNiao.GMTools.Database.Model.tbl_proto_cout model=new FengNiao.GMTools.Database.Model.tbl_proto_cout();
        //    DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
        //    if(ds.Tables[0].Rows.Count>0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}


        public List<FengNiao.GMTools.Database.Model.tbl_proto_cout> GetAllModel()
        {

            StringBuilder strSql = new StringBuilder();

            strSql.Append("select record_id,proto_id,fld_modif_time,button_name");

            List<FengNiao.GMTools.Database.Model.tbl_proto_cout> modelList = new List<FengNiao.GMTools.Database.Model.tbl_proto_cout>();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    modelList.Add(DataRowToModel(ds.Tables[0].Rows[i]));
                }
                return modelList;
            }
            else
            {
                return null;
            }
        }



		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FengNiao.GMTools.Database.Model.tbl_proto_cout DataRowToModel(DataRow row)
		{
			FengNiao.GMTools.Database.Model.tbl_proto_cout model=new FengNiao.GMTools.Database.Model.tbl_proto_cout();
			if (row != null)
			{
                if (row["record_id"] != null && row["record_id"].ToString() != "")
				{
                    model.record_id = int.Parse(row["record_id"].ToString());
				}
                if (row["proto_id"] != null && row["proto_id"].ToString() != "")
				{
                    model.proteo_id = int.Parse(row["proto_id"].ToString());
				}
                if (row["button_name"] != null && row["button_name"].ToString() != "")
				{
                    model.button_name = row["button_name"].ToString();
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
            strSql.Append("select record_id,proto_id,button_name");
            strSql.Append(" FROM tbl_proto_cout ");
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tbl_proto_cout ");
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
        //public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("SELECT * FROM ( ");
        //    strSql.Append(" SELECT ROW_NUMBER() OVER (");
        //    if (!string.IsNullOrEmpty(orderby.Trim()))
        //    {
        //        strSql.Append("order by T." + orderby );
        //    }
        //    else
        //    {
        //        strSql.Append("order by T.fld_record_id desc");
        //    }
        //    strSql.Append(")AS Row, T.*  from tbl_proto_cout T ");
        //    if (!string.IsNullOrEmpty(strWhere.Trim()))
        //    {
        //        strSql.Append(" WHERE " + strWhere);
        //    }
        //    strSql.Append(" ) TT");
        //    strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}
        #endregion
    }
}
