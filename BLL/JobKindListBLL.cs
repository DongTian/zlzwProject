using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
	/// <summary>
	/// JobKindListBLL
	/// </summary>
	public partial class JobKindListBLL
	{
		private readonly zlzw.DAL.JobKindListDAL dal=new zlzw.DAL.JobKindListDAL();
		public JobKindListBLL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JobKindID)
		{
			return dal.Exists(JobKindID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zlzw.Model.JobKindListModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.JobKindListModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JobKindID)
		{
			
			return dal.Delete(JobKindID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JobKindIDlist )
		{
			return dal.DeleteList(JobKindIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zlzw.Model.JobKindListModel GetModel(int JobKindID)
		{
			
			return dal.GetModel(JobKindID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zlzw.Model.JobKindListModel GetModelByCache(int JobKindID)
		{
			
			string CacheKey = "JobKindListModelModel-" + JobKindID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JobKindID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (zlzw.Model.JobKindListModel)objModel;
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
		public List<zlzw.Model.JobKindListModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zlzw.Model.JobKindListModel> DataTableToList(DataTable dt)
		{
			List<zlzw.Model.JobKindListModel> modelList = new List<zlzw.Model.JobKindListModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zlzw.Model.JobKindListModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zlzw.Model.JobKindListModel();
					if(dt.Rows[n]["JobKindID"]!=null && dt.Rows[n]["JobKindID"].ToString()!="")
					{
						model.JobKindID=int.Parse(dt.Rows[n]["JobKindID"].ToString());
					}
					if(dt.Rows[n]["JobCategoryGUID"]!=null && dt.Rows[n]["JobCategoryGUID"].ToString()!="")
					{
						model.JobCategoryGUID=new Guid(dt.Rows[n]["JobCategoryGUID"].ToString());
					}
					if(dt.Rows[n]["JobKindGUID"]!=null && dt.Rows[n]["JobKindGUID"].ToString()!="")
					{
						model.JobKindGUID=new Guid(dt.Rows[n]["JobKindGUID"].ToString());
					}
					if(dt.Rows[n]["JobKindName"]!=null && dt.Rows[n]["JobKindName"].ToString()!="")
					{
					model.JobKindName=dt.Rows[n]["JobKindName"].ToString();
					}
					if(dt.Rows[n]["JobCount"]!=null && dt.Rows[n]["JobCount"].ToString()!="")
					{
						model.JobCount=int.Parse(dt.Rows[n]["JobCount"].ToString());
					}
					if(dt.Rows[n]["IsHot"]!=null && dt.Rows[n]["IsHot"].ToString()!="")
					{
						model.IsHot=int.Parse(dt.Rows[n]["IsHot"].ToString());
					}
					if(dt.Rows[n]["IsEnable"]!=null && dt.Rows[n]["IsEnable"].ToString()!="")
					{
						model.IsEnable=int.Parse(dt.Rows[n]["IsEnable"].ToString());
					}
					if(dt.Rows[n]["IsShowDefaultPage"]!=null && dt.Rows[n]["IsShowDefaultPage"].ToString()!="")
					{
						model.IsShowDefaultPage=int.Parse(dt.Rows[n]["IsShowDefaultPage"].ToString());
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
					if(dt.Rows[n]["Other03"]!=null && dt.Rows[n]["Other03"].ToString()!="")
					{
						model.Other03=int.Parse(dt.Rows[n]["Other03"].ToString());
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

		#endregion  Method

        #region  ExtensionMethod

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

        #endregion  ExtensionMethod
	}
}