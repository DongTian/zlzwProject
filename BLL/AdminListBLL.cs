using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
	/// <summary>
	/// AdminListBLL
	/// </summary>
	public partial class AdminListBLL
	{
		private readonly zlzw.DAL.AdminListDAL dal=new zlzw.DAL.AdminListDAL();
		public AdminListBLL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AdminID)
		{
			return dal.Exists(AdminID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zlzw.Model.AdminListModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.AdminListModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int AdminID)
		{
			
			return dal.Delete(AdminID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AdminIDlist )
		{
			return dal.DeleteList(AdminIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zlzw.Model.AdminListModel GetModel(int AdminID)
		{
			
			return dal.GetModel(AdminID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zlzw.Model.AdminListModel GetModelByCache(int AdminID)
		{
			
			string CacheKey = "AdminListModelModel-" + AdminID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(AdminID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (zlzw.Model.AdminListModel)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zlzw.Model.AdminListModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zlzw.Model.AdminListModel> DataTableToList(DataTable dt)
		{
			List<zlzw.Model.AdminListModel> modelList = new List<zlzw.Model.AdminListModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zlzw.Model.AdminListModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zlzw.Model.AdminListModel();
					if(dt.Rows[n]["AdminID"]!=null && dt.Rows[n]["AdminID"].ToString()!="")
					{
						model.AdminID=int.Parse(dt.Rows[n]["AdminID"].ToString());
					}
					if(dt.Rows[n]["AdminGUID"]!=null && dt.Rows[n]["AdminGUID"].ToString()!="")
					{
						model.AdminGUID=new Guid(dt.Rows[n]["AdminGUID"].ToString());
					}
					if(dt.Rows[n]["AdminName"]!=null && dt.Rows[n]["AdminName"].ToString()!="")
					{
					model.AdminName=dt.Rows[n]["AdminName"].ToString();
					}
					if(dt.Rows[n]["AdminPassword"]!=null && dt.Rows[n]["AdminPassword"].ToString()!="")
					{
					model.AdminPassword=dt.Rows[n]["AdminPassword"].ToString();
					}
					if(dt.Rows[n]["IsEnable"]!=null && dt.Rows[n]["IsEnable"].ToString()!="")
					{
						model.IsEnable=int.Parse(dt.Rows[n]["IsEnable"].ToString());
					}
					if(dt.Rows[n]["PublishDate"]!=null && dt.Rows[n]["PublishDate"].ToString()!="")
					{
						model.PublishDate=DateTime.Parse(dt.Rows[n]["PublishDate"].ToString());
					}
					if(dt.Rows[n]["Other01"]!=null && dt.Rows[n]["Other01"].ToString()!="")
					{
					model.Other01=dt.Rows[n]["Other01"].ToString();
					}
					if(dt.Rows[n]["Other02"]!=null && dt.Rows[n]["Other02"].ToString()!="")
					{
					model.Other02=dt.Rows[n]["Other02"].ToString();
					}
					modelList.Add(model);
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PageSize">每页显示的行数</param>
        /// <param name="PageIndex">当前页数</param>
        /// <param name="strColumnsm">需要显示的列名</param>
        /// <param name="strOrderColumn">需要排序的列</param>
        /// <param name="nIsCount">是否返回记录总数</param>
        /// <param name="strOrderType">排序类型desc & asc</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strColumns, string strOrderColumn, int nIsCount, string strOrderType, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strColumns, strOrderColumn, nIsCount, strOrderType, strWhere);
        }

		#endregion  Method
	}
}