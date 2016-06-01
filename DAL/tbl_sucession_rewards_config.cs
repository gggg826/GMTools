using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references

namespace FengNiao.GMTools.Database.DAL
{
    public partial class tbl_sucession_rewards_config
    {
        public tbl_sucession_rewards_config()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbl_sucession_rewards_config");
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
		public bool Add(FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_sucession_rewards_config(");
            strSql.Append("record_id,serverID,date,kindReward,rewardName1,rewardCount1,rewardName2,rewardCount2,rewardName3,rewardCount3,rewardName4,rewardCount4)");
            strSql.Append(" values (");
            strSql.Append("default,@serverID,@date,@kindReward,@rewardName1,@rewardCount1,@rewardName2,@rewardCount2,@rewardName3,@rewardCount3,@rewardName4,@rewardCount4)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@serverID", MySqlDbType.Int32,11),
					new MySqlParameter("@date", MySqlDbType.Int32,11),
					new MySqlParameter("@kindReward", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardName1", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount1", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardName2", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount2", MySqlDbType.Int32,11),					
                    new MySqlParameter("@rewardName3", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount3", MySqlDbType.Int32,11),					
                    new MySqlParameter("@rewardName4", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount4", MySqlDbType.Int32,11),};
            int index = 0;
            parameters[index++].Value = model.serverID;
            parameters[index++].Value = model.date;
            parameters[index++].Value = model.kindReward;
            parameters[index++].Value = model.rewardName1;
            parameters[index++].Value = model.rewardCount1;
            parameters[index++].Value = model.rewardName2;
            parameters[index++].Value = model.rewardCount2;
            parameters[index++].Value = model.rewardName3;
            parameters[index++].Value = model.rewardCount3;
            parameters[index++].Value = model.rewardName4;
            parameters[index++].Value = model.rewardCount4;

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
		public bool Update(FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update tbl_sucession_rewards_config set ");
            strSql.Append("kindReward=@kindReward,");
            strSql.Append("rewardName1=@rewardName1,");
            strSql.Append("rewardCount1=@rewardCount1,");
            strSql.Append("rewardName2=@rewardName2,");
            strSql.Append("rewardCount2=@rewardCount2,");
            strSql.Append("rewardName3=@rewardName3,");
            strSql.Append("rewardCount3=@rewardCount3,");
            strSql.Append("rewardName4=@rewardName4,");
            strSql.Append("rewardCount4=@rewardCount4");
            strSql.Append(" where date=@date");
            MySqlParameter[] parameters = {
					new MySqlParameter("@kindReward", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardName1", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount1", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardName2", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount2", MySqlDbType.Int32,11),					
                    new MySqlParameter("@rewardName3", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount3", MySqlDbType.Int32,11),					
                    new MySqlParameter("@rewardName4", MySqlDbType.Int32,11),
					new MySqlParameter("@rewardCount4", MySqlDbType.Int32,11),
					new MySqlParameter("@date", MySqlDbType.Int32,11)};
            int index = 0;
            parameters[index++].Value = model.kindReward;
            parameters[index++].Value = model.rewardName1;
            parameters[index++].Value = model.rewardCount1;
            parameters[index++].Value = model.rewardName2;
            parameters[index++].Value = model.rewardCount2;
            parameters[index++].Value = model.rewardName3;
            parameters[index++].Value = model.rewardCount3;
            parameters[index++].Value = model.rewardName4;
            parameters[index++].Value = model.rewardCount4;
            parameters[index++].Value = model.date;

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
		public bool Delete(int record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_sucession_rewards_config ");
			strSql.Append(" where record_id=@record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = record_id;

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
        public bool DeleteByServer(int server_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_sucession_rewards_config ");
            strSql.Append(" where serverID=@serverID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@serverID", MySqlDbType.Int32)
			};
            parameters[0].Value = server_id;

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
		public bool DeleteList(string record_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbl_sucession_rewards_config ");
			strSql.Append(" where record_id in ("+record_idlist + ")  ");
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
		public FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config GetModel(int record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select record_id,serverID,date,kindReward,rewardName1,rewardCount1,rewardName2,rewardCount2,rewardName3,rewardCount3,rewardName4,rewardCount4 from tbl_sucession_rewards_config ");
			strSql.Append(" where record_id=@record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32)
			};
			parameters[0].Value = record_id;

			FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config model=new FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config();
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
		public FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config DataRowToModel(DataRow row)
		{
			FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config model=new FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config();
			if (row != null)
			{
                if (row["record_id"] != null && row["record_id"].ToString() != "")
				{
                    model.record_id = int.Parse(row["record_id"].ToString());
				}
                if (row["serverID"] != null && row["serverID"].ToString() != "")
				{
                    model.serverID = int.Parse(row["serverID"].ToString());
				}
                if (row["date"] != null && row["date"].ToString() != "")
				{
                    model.date = int.Parse(row["date"].ToString());
				}
                if (row["kindReward"] != null && row["kindReward"].ToString() != "")
				{
                    model.kindReward = int.Parse(row["kindReward"].ToString());
				}
                if (row["rewardName1"] != null && row["rewardName1"].ToString() != "")
				{
                    model.rewardName1 = int.Parse(row["rewardName1"].ToString());
				}
                if (row["rewardCount1"] != null && row["rewardCount1"].ToString() != "")
				{
                    model.rewardCount1 = int.Parse(row["rewardCount1"].ToString());
				}
                if (row["rewardName2"] != null && row["rewardName2"].ToString() != "")
                {
                    model.rewardName2 = int.Parse(row["rewardName2"].ToString());
                }
                if (row["rewardCount2"] != null && row["rewardCount2"].ToString() != "")
                {
                    model.rewardCount2 = int.Parse(row["rewardCount2"].ToString());
                }
                if (row["rewardName3"] != null && row["rewardName3"].ToString() != "")
                {
                    model.rewardName3 = int.Parse(row["rewardName3"].ToString());
                }
                if (row["rewardCount3"] != null && row["rewardCount3"].ToString() != "")
                {
                    model.rewardCount3 = int.Parse(row["rewardCount3"].ToString());
                }
                if (row["rewardName4"] != null && row["rewardName4"].ToString() != "")
                {
                    model.rewardName4 = int.Parse(row["rewardName4"].ToString());
                }
                if (row["rewardCount4"] != null && row["rewardCount4"].ToString() != "")
                {
                    model.rewardCount4 = int.Parse(row["rewardCount4"].ToString());
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
            strSql.Append("select record_id,serverID,date,kindReward,rewardName1,rewardCount1,rewardName2,rewardCount2,rewardName3,rewardCount3,rewardName4,rewardCount4");
            strSql.Append(" FROM tbl_sucession_rewards_config ");
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
			strSql.Append("select count(1) FROM tbl_sucession_rewards_config ");
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
        //    strSql.Append(")AS Row, T.*  from tbl_sucession_rewards_config T ");
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
