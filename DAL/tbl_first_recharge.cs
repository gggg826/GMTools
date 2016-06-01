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
	public partial class tbl_first_recharge
	{
        public tbl_first_recharge()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(long record_id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from tbl_first_recharge");
            strSql.Append(" where record_id=@record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int64)
			};
            parameters[0].Value = record_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public bool Add(FengNiao.GMTools.Database.Model.tbl_first_recharge model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into tbl_first_recharge");

            /*strSql.Append("(");
            strSql.Append("itemid,index,name,dec,icon,RMBprice,");
            strSql.Append("IsOnlyOnce,diamonds,giveDiamonds,normalGiveDiamonds,");
            strSql.Append("activeGiveDiamonds,activeStartTime,activeEndTime,isWeekCard,");
            strSql.Append("isMonthCard,channel,sellStatc,FirstRechargeItem1,Num1,");
            strSql.Append("FirstRechargeItem2,Num2,FirstRechargeItem3,Num3,FirstRechargeItem4,");
            strSql.Append("Num4,FirstRechargeItem5,Num5,FirstRechargeItem6,Num6");
            strSql.Append(")");*/

			strSql.Append(" values ");
            strSql.Append("(default, @itemid,@index,@name,@dec,@icon,@RMBprice,@IsOnlyOnce,@diamonds,@giveDiamonds,@normalGiveDiamonds,@activeGiveDiamonds,@activeStartTime,@activeEndTime,@isWeekCard,@isMonthCard,@channel,@sellStatc,@FirstRechargeItem1,@Num1,@FirstRechargeItem2,@Num2,@FirstRechargeItem3,@Num3,@FirstRechargeItem4,@Num4,@FirstRechargeItem5,@Num5,@FirstRechargeItem6,@Num6)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@itemid", MySqlDbType.VarChar,255),
                    new MySqlParameter("@index", MySqlDbType.Int32),
                    new MySqlParameter("@name", MySqlDbType.VarChar,255),
                    new MySqlParameter("@dec", MySqlDbType.VarChar,255),
                    new MySqlParameter("@icon", MySqlDbType.Int32),
                    new MySqlParameter("@RMBprice", MySqlDbType.Int32),
                    new MySqlParameter("@IsOnlyOnce", MySqlDbType.Int32),
                    new MySqlParameter("@diamonds", MySqlDbType.Int32),
                    new MySqlParameter("@giveDiamonds", MySqlDbType.Int32),
                    new MySqlParameter("@normalGiveDiamonds", MySqlDbType.Int32),
                    new MySqlParameter("@activeGiveDiamonds", MySqlDbType.Int32),
                    new MySqlParameter("@activeStartTime", MySqlDbType.DateTime),
                    new MySqlParameter("@activeEndTime", MySqlDbType.DateTime),
                    new MySqlParameter("@isWeekCard", MySqlDbType.Int32),
                    new MySqlParameter("@isMonthCard", MySqlDbType.Int32),
                    new MySqlParameter("@channel", MySqlDbType.VarChar,255),
                    new MySqlParameter("@sellStatc", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem1", MySqlDbType.Int32),
                    new MySqlParameter("@Num1", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem2", MySqlDbType.Int32),
                    new MySqlParameter("@Num2", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem3", MySqlDbType.Int32),
                    new MySqlParameter("@Num3", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem4", MySqlDbType.Int32),
                    new MySqlParameter("@Num4", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem5", MySqlDbType.Int32),
                    new MySqlParameter("@Num5", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem6", MySqlDbType.Int32),
                    new MySqlParameter("@Num6", MySqlDbType.Int32),
                                          
                                          };
            int index = 0;
            //parameters[index++].Value = model.record_id;
            //parameters[index++].Value = model.serverid;
            parameters[index++].Value = model.itemid;
            parameters[index++].Value = model.index;
            parameters[index++].Value = model.name;
            parameters[index++].Value = model.dec;
            parameters[index++].Value = model.icon;
            parameters[index++].Value = model.RMBprice;
            parameters[index++].Value = model.IsOnlyOnce;
            parameters[index++].Value = model.diamonds;
            parameters[index++].Value = model.giveDiamonds;
            parameters[index++].Value = model.normalGiveDiamonds;
            parameters[index++].Value = model.activeGiveDiamonds;
            parameters[index++].Value = model.activeStartTime;
            parameters[index++].Value = model.activeEndTime;
            parameters[index++].Value = model.isWeekCard;
            parameters[index++].Value = model.isMonthCard;
            parameters[index++].Value = model.channel;
            parameters[index++].Value = model.sellStatc;
            parameters[index++].Value = model.FirstRechargeItem1;
            parameters[index++].Value = model.Num1;
            parameters[index++].Value = model.FirstRechargeItem2;
            parameters[index++].Value = model.Num2;
            parameters[index++].Value = model.FirstRechargeItem3;
            parameters[index++].Value = model.Num3;
            parameters[index++].Value = model.FirstRechargeItem4;
            parameters[index++].Value = model.Num4;
            parameters[index++].Value = model.FirstRechargeItem5;
            parameters[index++].Value = model.Num5;
            parameters[index++].Value = model.FirstRechargeItem6;
            parameters[index++].Value = model.Num6;

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
        public bool Update(FengNiao.GMTools.Database.Model.tbl_first_recharge model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update tbl_first_recharge set ");
            strSql.Append("`itemid`=@itemid,");
            strSql.Append("`index`=@index,");
            strSql.Append("`name`=@name,");
            strSql.Append("`dec`=@dec,");
            strSql.Append("`icon`=@icon,");
            strSql.Append("`RMBprice`=@RMBprice,");
            strSql.Append("`IsOnlyOnce`=@IsOnlyOnce,");
            strSql.Append("`diamonds`=@diamonds,");
            strSql.Append("`giveDiamonds`=@giveDiamonds,");
            strSql.Append("`normalGiveDiamonds`=@normalGiveDiamonds,");
            strSql.Append("`activeGiveDiamonds`=@activeGiveDiamonds,");
            strSql.Append("`activeStartTime`=@activeStartTime,");
            strSql.Append("`activeEndTime`=@activeEndTime,");
            strSql.Append("`isWeekCard`=@isWeekCard,");
            strSql.Append("`isMonthCard`=@isMonthCard,");
            strSql.Append("`channel`=@channel,");
            strSql.Append("`sellStatc`=@sellStatc,");
            strSql.Append("`FirstRechargeItem1`=@FirstRechargeItem1,");
            strSql.Append("`Num1`=@Num1,");
            strSql.Append("`FirstRechargeItem2`=@FirstRechargeItem2,");
            strSql.Append("`Num2`=@Num2,");
            strSql.Append("`FirstRechargeItem3`=@FirstRechargeItem3,");
            strSql.Append("`Num3`=@Num3,");
            strSql.Append("`FirstRechargeItem4`=@FirstRechargeItem4,");
            strSql.Append("`Num4`=@Num4,");
            strSql.Append("`FirstRechargeItem5`=@FirstRechargeItem5,");
            strSql.Append("`Num5`=@Num5,");
            strSql.Append("`FirstRechargeItem6`=@FirstRechargeItem6,");
            strSql.Append("`Num6`=@Num6");
            strSql.Append(" where `record_id`=@record_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@itemid", MySqlDbType.VarChar,255),
                    new MySqlParameter("@index", MySqlDbType.Int32),
                    new MySqlParameter("@name", MySqlDbType.VarChar,255),
                    new MySqlParameter("@dec", MySqlDbType.VarChar,255),
                    new MySqlParameter("@icon", MySqlDbType.Int32),
                    new MySqlParameter("@RMBprice", MySqlDbType.Int32),
                    new MySqlParameter("@IsOnlyOnce", MySqlDbType.Int32),
                    new MySqlParameter("@diamonds", MySqlDbType.Int32),
                    new MySqlParameter("@giveDiamonds", MySqlDbType.Int32),
                    new MySqlParameter("@normalGiveDiamonds", MySqlDbType.Int32),
                    new MySqlParameter("@activeGiveDiamonds", MySqlDbType.Int32),
                    new MySqlParameter("@activeStartTime", MySqlDbType.DateTime),
                    new MySqlParameter("@activeEndTime", MySqlDbType.DateTime),
                    new MySqlParameter("@isWeekCard", MySqlDbType.Int32),
                    new MySqlParameter("@isMonthCard", MySqlDbType.Int32),
                    new MySqlParameter("@channel", MySqlDbType.VarChar,255),
                    new MySqlParameter("@sellStatc", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem1", MySqlDbType.Int32),
                    new MySqlParameter("@Num1", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem2", MySqlDbType.Int32),
                    new MySqlParameter("@Num2", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem3", MySqlDbType.Int32),
                    new MySqlParameter("@Num3", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem4", MySqlDbType.Int32),
                    new MySqlParameter("@Num4", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem5", MySqlDbType.Int32),
                    new MySqlParameter("@Num5", MySqlDbType.Int32),
                    new MySqlParameter("@FirstRechargeItem6", MySqlDbType.Int32),
                    new MySqlParameter("@Num6", MySqlDbType.Int32),
                    new MySqlParameter("@record_id", MySqlDbType.Int64,20)
                                          
                                          };
            int index = 0;
            //
           // parameters[index++].Value = model.serverid;
            parameters[index++].Value = model.itemid;
            parameters[index++].Value = model.index;
            parameters[index++].Value = model.name;
            parameters[index++].Value = model.dec;
            parameters[index++].Value = model.icon;
            parameters[index++].Value = model.RMBprice;
            parameters[index++].Value = model.IsOnlyOnce;
            parameters[index++].Value = model.diamonds;
            parameters[index++].Value = model.giveDiamonds;
            parameters[index++].Value = model.normalGiveDiamonds;
            parameters[index++].Value = model.activeGiveDiamonds;
            parameters[index++].Value = model.activeStartTime;
            parameters[index++].Value = model.activeEndTime;
            parameters[index++].Value = model.isWeekCard;
            parameters[index++].Value = model.isMonthCard;
            parameters[index++].Value = model.channel;
            parameters[index++].Value = model.sellStatc;
            parameters[index++].Value = model.FirstRechargeItem1;
            parameters[index++].Value = model.Num1;
            parameters[index++].Value = model.FirstRechargeItem2;
            parameters[index++].Value = model.Num2;
            parameters[index++].Value = model.FirstRechargeItem3;
            parameters[index++].Value = model.Num3;
            parameters[index++].Value = model.FirstRechargeItem4;
            parameters[index++].Value = model.Num4;
            parameters[index++].Value = model.FirstRechargeItem5;
            parameters[index++].Value = model.Num5;
            parameters[index++].Value = model.FirstRechargeItem6;
            parameters[index++].Value = model.Num6;
            parameters[index++].Value = model.record_id;

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
		public bool Delete(long record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from tbl_first_recharge ");
            strSql.Append(" where record_id=@record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int64)
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
		/// 批量删除数据
		/// </summary>
        public bool DeleteList(string record_idlist)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from tbl_first_recharge ");
            strSql.Append(" where record_id in (" + record_idlist + ")  ");
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
        public FengNiao.GMTools.Database.Model.tbl_first_recharge GetModel(long record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select record_id,itemid,index,name,dec,icon,RMBprice,IsOnlyOnce,diamonds,giveDiamonds,normalGiveDiamonds,activeGiveDiamonds,activeStartTime,activeEndTime,isWeekCard,isMonthCard,channel,sellStatc,FirstRechargeItem1,Num1,FirstRechargeItem2,Num2,FirstRechargeItem3,Num3,FirstRechargeItem4,Num4,FirstRechargeItem5,Num5,FirstRechargeItem6,Num6 from tbl_first_recharge ");
            strSql.Append(" where record_id=@record_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@record_id", MySqlDbType.Int64)
			};
            parameters[0].Value = record_id;

            FengNiao.GMTools.Database.Model.tbl_first_recharge model = new FengNiao.GMTools.Database.Model.tbl_first_recharge();
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
        public FengNiao.GMTools.Database.Model.tbl_first_recharge DataRowToModel(DataRow row)
		{
            FengNiao.GMTools.Database.Model.tbl_first_recharge model = new FengNiao.GMTools.Database.Model.tbl_first_recharge();
			if (row != null)
			{
                if (row["record_id"] != null && row["record_id"].ToString() != "")
			   {
                    model.record_id = long.Parse(row["record_id"].ToString());
			   }
              //  if (row["serverid"] != null && row["serverid"].ToString() != "")
				//{
                 //   model.serverid = int.Parse(row["serverid"].ToString());
				//}
                if (row["itemid"] != null && row["itemid"].ToString() != "")
				{
                    model.itemid = row["itemid"].ToString();
				}
                if (row["index"] != null && row["index"].ToString() != "")
				{
                    model.index = int.Parse(row["index"].ToString());
				}
                if (row["name"] != null)
				{
                    model.name = row["name"].ToString();
				}
                if (row["dec"] != null)
				{
                    model.dec = row["dec"].ToString();
				}
                if (row["icon"] != null)
				{
                    model.icon = int.Parse(row["icon"].ToString());
				}
                if (row["RMBprice"] != null)
                {
                    model.RMBprice = int.Parse(row["RMBprice"].ToString());
                }
                if (row["IsOnlyOnce"] != null)
                {
                    model.IsOnlyOnce = int.Parse(row["IsOnlyOnce"].ToString());
                }
                if (row["diamonds"] != null)
                {
                    model.diamonds = int.Parse(row["diamonds"].ToString());
                }
                if (row["giveDiamonds"] != null)
                {
                    model.giveDiamonds = int.Parse(row["giveDiamonds"].ToString());
                }
                if (row["normalGiveDiamonds"] != null)
                {
                    model.normalGiveDiamonds = int.Parse(row["normalGiveDiamonds"].ToString());
                }

                if (row["activeGiveDiamonds"] != null)
                {
                    model.activeGiveDiamonds = int.Parse(row["activeGiveDiamonds"].ToString());
                }
                if (row["activeStartTime"] != null)
                {
                    model.activeStartTime = DateTime.Parse(row["activeStartTime"].ToString());
                }
                if (row["activeEndTime"] != null)
                {
                    model.activeEndTime = DateTime.Parse(row["activeEndTime"].ToString());
                }
                if (row["isWeekCard"] != null)
                {
                    model.isWeekCard = int.Parse(row["isWeekCard"].ToString());
                }
                if (row["isMonthCard"] != null)
                {
                    model.isMonthCard = int.Parse(row["isMonthCard"].ToString());
                }
                if (row["channel"] != null)
                {
                    model.channel = row["channel"].ToString();
                }
                if (row["sellStatc"] != null)
                {
                    model.sellStatc = int.Parse(row["sellStatc"].ToString());
                }
                if (row["FirstRechargeItem1"] != null)
                {
                    model.FirstRechargeItem1 = int.Parse(row["FirstRechargeItem1"].ToString());
                }
                if (row["Num1"] != null)
                {
                    model.Num1 = int.Parse(row["Num1"].ToString());
                }


                if (row["FirstRechargeItem2"] != null)
                {
                    model.FirstRechargeItem2 = int.Parse(row["FirstRechargeItem2"].ToString());
                }
                if (row["Num2"] != null)
                {
                    model.Num2 = int.Parse(row["Num2"].ToString());
                }


                if (row["FirstRechargeItem3"] != null)
                {
                    model.FirstRechargeItem3 = int.Parse(row["FirstRechargeItem3"].ToString());
                }
                if (row["Num3"] != null)
                {
                    model.Num3 = int.Parse(row["Num3"].ToString());
                }


                if (row["FirstRechargeItem4"] != null)
                {
                    model.FirstRechargeItem4 = int.Parse(row["FirstRechargeItem4"].ToString());
                }
                if (row["Num4"] != null)
                {
                    model.Num4 = int.Parse(row["Num4"].ToString());
                }


                if (row["FirstRechargeItem5"] != null)
                {
                    model.FirstRechargeItem5 = int.Parse(row["FirstRechargeItem5"].ToString());
                }
                if (row["Num5"] != null)
                {
                    model.Num5 = int.Parse(row["Num5"].ToString());
                }

                if (row["FirstRechargeItem6"] != null)
                {
                    model.FirstRechargeItem6 = int.Parse(row["FirstRechargeItem6"].ToString());
                }
                if (row["Num6"] != null)
                {
                    model.Num6 = int.Parse(row["Num6"].ToString());
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
            strSql.Append("select `record_id`,`itemid`,`index`,`name`,`dec`,`icon`,`RMBprice`,`IsOnlyOnce`,`diamonds`,`giveDiamonds`,`normalGiveDiamonds`,`activeGiveDiamonds`,`activeStartTime`,`activeEndTime`,`isWeekCard`,`isMonthCard`,`channel`,`sellStatc`,`FirstRechargeItem1`,`Num1`,`FirstRechargeItem2`,`Num2`,`FirstRechargeItem3`,`Num3`,`FirstRechargeItem4`,`Num4`,`FirstRechargeItem5`,`Num5`,`FirstRechargeItem6`,`Num6`");
            strSql.Append(" FROM tbl_first_recharge ");
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
            strSql.Append("select count(1) FROM tbl_first_recharge ");
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
				strSql.Append("order by T.record_id desc");
			}
            strSql.Append(")AS Row, T.*  from tbl_first_recharge T ");
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

