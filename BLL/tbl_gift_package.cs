/**  版本信息模板在安装目录下，可自行修改。
* tbl_gift_package.cs
*
* 功 能： N/A
* 类 名： tbl_gift_package
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/6/26 14:32:57   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using FengNiao.GMTools.Database.Model;
namespace FengNiao.GMTools.Database.BLL
{
	/// <summary>
	/// tbl_gift_package
	/// </summary>
	public partial class tbl_gift_package
	{
		private readonly FengNiao.GMTools.Database.DAL.tbl_gift_package dal=new FengNiao.GMTools.Database.DAL.tbl_gift_package();
		public tbl_gift_package()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int fld_id)
		{
			return dal.Exists(fld_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FengNiao.GMTools.Database.Model.tbl_gift_package model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FengNiao.GMTools.Database.Model.tbl_gift_package model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int fld_id)
		{
			
			return dal.Delete(fld_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string fld_idlist )
		{
			return dal.DeleteList(fld_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FengNiao.GMTools.Database.Model.tbl_gift_package GetModel(int fld_id)
		{
			
			return dal.GetModel(fld_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public FengNiao.GMTools.Database.Model.tbl_gift_package GetModelByCache(int fld_id)
		{
			
			string CacheKey = "tbl_gift_packageModel-" + fld_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(fld_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (FengNiao.GMTools.Database.Model.tbl_gift_package)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FengNiao.GMTools.Database.Model.tbl_gift_package> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FengNiao.GMTools.Database.Model.tbl_gift_package> DataTableToList(DataTable dt)
		{
			List<FengNiao.GMTools.Database.Model.tbl_gift_package> modelList = new List<FengNiao.GMTools.Database.Model.tbl_gift_package>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				FengNiao.GMTools.Database.Model.tbl_gift_package model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

