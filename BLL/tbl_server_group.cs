using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using FengNiao.GMTools.Database.Model;
namespace FengNiao.GMTools.Database.BLL
{
	/// <summary>
	/// tbl_server_group
	/// </summary>
	public partial class tbl_server_group
	{
		private readonly FengNiao.GMTools.Database.DAL.tbl_server_group dal=new FengNiao.GMTools.Database.DAL.tbl_server_group();
		public tbl_server_group()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long fld_record_id)
		{
			return dal.Exists(fld_record_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FengNiao.GMTools.Database.Model.tbl_server_group model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FengNiao.GMTools.Database.Model.tbl_server_group model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long fld_record_id)
		{
			
			return dal.Delete(fld_record_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string fld_record_idlist )
		{
			return dal.DeleteList(fld_record_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FengNiao.GMTools.Database.Model.tbl_server_group GetModel(long fld_record_id)
		{
			
			return dal.GetModel(fld_record_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public FengNiao.GMTools.Database.Model.tbl_server_group GetModelByCache(long fld_record_id)
		{
			
			string CacheKey = "tbl_server_groupModel-" + fld_record_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(fld_record_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (FengNiao.GMTools.Database.Model.tbl_server_group)objModel;
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
		public List<FengNiao.GMTools.Database.Model.tbl_server_group> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FengNiao.GMTools.Database.Model.tbl_server_group> DataTableToList(DataTable dt)
		{
			List<FengNiao.GMTools.Database.Model.tbl_server_group> modelList = new List<FengNiao.GMTools.Database.Model.tbl_server_group>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				FengNiao.GMTools.Database.Model.tbl_server_group model;
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

