using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references

namespace FengNiao.GMTools.Database.DAL
{
    public partial class tbl_counts_config
    {
        public tbl_counts_config() { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        //public bool Exists(long record_id)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) from tbl_counts_config");
        //    strSql.Append(" where record_id=@record_id");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@record_id", MySqlDbType.Int32)
        //    };
        //    parameters[0].Value = record_id;

        //    return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        //}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_counts_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbl_counts_config(");
            strSql.Append("record_id,item_id,counts,describes,kindofrewards,reward1,count1,reward2,count2,reward3,count3,reward4,count4,serverID)");
            strSql.Append(" values (");
            strSql.Append("@record_id,@item_id,@counts,@describes,@kindofrewards,@reward1,@count1,@reward2,@count2,@reward3,@count3,@reward4,@count4,@serverID)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int32,11),
					new MySqlParameter("@item_id", MySqlDbType.Int32,11),
					new MySqlParameter("@counts", MySqlDbType.Int32,11),
					new MySqlParameter("@describes", MySqlDbType.VarChar,255),
					new MySqlParameter("@kindofrewards", MySqlDbType.Int32,11),
					new MySqlParameter("@reward1", MySqlDbType.Int32,11),
					new MySqlParameter("@count1", MySqlDbType.Int32,11),
					new MySqlParameter("@reward2", MySqlDbType.Int32,11),
					new MySqlParameter("@count2", MySqlDbType.Int32,11),					
                    new MySqlParameter("@reward3", MySqlDbType.Int32,11),
					new MySqlParameter("@count3", MySqlDbType.Int32,11),					
                    new MySqlParameter("@reward4", MySqlDbType.Int32,11),
					new MySqlParameter("@count4", MySqlDbType.Int32,11),
                    new MySqlParameter("@serverID", MySqlDbType.Int32,11)};
            int index = 0;
            parameters[index++].Value = model.record_id;
            parameters[index++].Value = model.item_id;
            parameters[index++].Value = model.count;
            parameters[index++].Value = model.dec;
            parameters[index++].Value = model.kindofrewards;
            parameters[index++].Value = model.reward1;
            parameters[index++].Value = model.count1;
            parameters[index++].Value = model.reward2;
            parameters[index++].Value = model.count2;
            parameters[index++].Value = model.reward3;
            parameters[index++].Value = model.count3;
            parameters[index++].Value = model.reward4;
            parameters[index++].Value = model.count4;
            parameters[index++].Value = model.serverID;

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
        //public bool Update(FengNiao.GMTools.Database.Model.tbl_counts_config model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update tbl_counts_config set ");
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

        //    int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("delete from tbl_counts_config ");
        //    strSql.Append(" where record_id=@record_id");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@record_id", MySqlDbType.Int32)
        //    };
        //    parameters[0].Value = record_id;

        //    int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        public bool Truncate()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("truncate table tbl_counts_config");

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




        public List<FengNiao.GMTools.Database.Model.tbl_counts_config> GetAllModel()
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select record_id,item_id,counts,describes,kindofrewards,reward1,count1,reward2,count2,reward3,count3,reward4,count4,serverID");
            strSql.Append(" FROM tbl_counts_config ");
            List<FengNiao.GMTools.Database.Model.tbl_counts_config> modelList = new List<FengNiao.GMTools.Database.Model.tbl_counts_config>();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    modelList.Add(DataRowToModel(ds.Tables[0].Rows[i]));
                }
            }
            return modelList;
        }




        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByServer(int server_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbl_counts_config ");
            strSql.Append(" where serverID=@serverID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@serverID", MySqlDbType.Int32)
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
        //public bool DeleteList(string record_idlist)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("delete from tbl_counts_config ");
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
        //public FengNiao.GMTools.Database.Model.tbl_counts_config GetModel(int record_id)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select record_id,serverID,date,kindReward,rewardName1,rewardCount1,rewardName2,rewardCount2,rewardName3,rewardCount3,rewardName4,rewardCount4 from tbl_counts_config ");
        //    strSql.Append(" where record_id=@record_id");
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@record_id", MySqlDbType.Int32)
        //    };
        //    parameters[0].Value = record_id;

        //    FengNiao.GMTools.Database.Model.tbl_counts_config model = new FengNiao.GMTools.Database.Model.tbl_counts_config();
        //    DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public List<FengNiao.GMTools.Database.Model.tbl_counts_config> GetALLModel()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select record_id,item_id,counts,describe,kindofrewards,reward1,count1,reward2,count2,reward3,count3,reward4,count4,serverID from tbl_counts_config ");

            List<FengNiao.GMTools.Database.Model.tbl_counts_config> list = new List<FengNiao.GMTools.Database.Model.tbl_counts_config>();
            FengNiao.GMTools.Database.Model.tbl_counts_config model = new FengNiao.GMTools.Database.Model.tbl_counts_config();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                {
                    list.Add(DataRowToModel(ds.Tables[0].Rows[i]));
                }

                return list;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FengNiao.GMTools.Database.Model.tbl_counts_config DataRowToModel(DataRow row)
        {
            FengNiao.GMTools.Database.Model.tbl_counts_config model = new FengNiao.GMTools.Database.Model.tbl_counts_config();
            if (row != null)
            {
                if (row["record_id"] != null && row["record_id"].ToString() != "")
                {
                    model.record_id = int.Parse(row["record_id"].ToString());
                }
                if (row["item_id"] != null && row["item_id"].ToString() != "")
                {
                    model.item_id = int.Parse(row["item_id"].ToString());
                }
                if (row["counts"] != null && row["counts"].ToString() != "")
                {
                    model.count = int.Parse(row["counts"].ToString());
                }
                if (row["describes"] != null && row["describes"].ToString() != "")
                {
                    model.dec = row["describes"].ToString();
                }
                if (row["kindofrewards"] != null && row["kindofrewards"].ToString() != "")
                {
                    model.kindofrewards = int.Parse(row["kindofrewards"].ToString());
                }
                if (row["reward1"] != null && row["reward1"].ToString() != "")
                {
                    model.reward1 = int.Parse(row["reward1"].ToString());
                }
                if (row["count1"] != null && row["count1"].ToString() != "")
                {
                    model.count1 = int.Parse(row["count1"].ToString());
                }
                if (row["reward2"] != null && row["reward2"].ToString() != "")
                {
                    model.reward2 = int.Parse(row["reward2"].ToString());
                }
                if (row["count2"] != null && row["count2"].ToString() != "")
                {
                    model.count2 = int.Parse(row["count2"].ToString());
                }
                if (row["reward3"] != null && row["reward3"].ToString() != "")
                {
                    model.reward3 = int.Parse(row["reward3"].ToString());
                }
                if (row["count3"] != null && row["count3"].ToString() != "")
                {
                    model.count3 = int.Parse(row["count3"].ToString());
                }
                if (row["reward4"] != null && row["reward4"].ToString() != "")
                {
                    model.reward4 = int.Parse(row["reward4"].ToString());
                }
                if (row["count4"] != null && row["count4"].ToString() != "")
                {
                    model.count4 = int.Parse(row["count4"].ToString());
                }
                if (row["serverID"] != null && row["serverID"].ToString() != "")
                {
                    model.serverID = int.Parse(row["serverID"].ToString());
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
            strSql.Append("select record_id,item_id,counts,`describes`,kindofrewards,reward1,count1,reward2,count2,reward3,count3,reward4,count4,serverID");
            strSql.Append(" FROM tbl_counts_config ");
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
            strSql.Append("select count(1) FROM tbl_counts_config ");
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
        //    strSql.Append(")AS Row, T.*  from tbl_counts_config T ");
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
