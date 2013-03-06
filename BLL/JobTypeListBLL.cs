using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
	/// <summary>
	/// JobTypeListBLL
	/// </summary>
	public partial class JobTypeListBLL
	{
		private readonly zlzw.DAL.JobTypeListDAL dal=new zlzw.DAL.JobTypeListDAL();
		public JobTypeListBLL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JobTypeID)
		{
			return dal.Exists(JobTypeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zlzw.Model.JobTypeListModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.JobTypeListModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JobTypeID)
		{
			
			return dal.Delete(JobTypeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JobTypeIDlist )
		{
			return dal.DeleteList(JobTypeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zlzw.Model.JobTypeListModel GetModel(int JobTypeID)
		{
			
			return dal.GetModel(JobTypeID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zlzw.Model.JobTypeListModel GetModelByCache(int JobTypeID)
		{
			
			string CacheKey = "JobTypeListModelModel-" + JobTypeID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JobTypeID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (zlzw.Model.JobTypeListModel)objModel;
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
		public List<zlzw.Model.JobTypeListModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zlzw.Model.JobTypeListModel> DataTableToList(DataTable dt)
		{
			List<zlzw.Model.JobTypeListModel> modelList = new List<zlzw.Model.JobTypeListModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zlzw.Model.JobTypeListModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zlzw.Model.JobTypeListModel();
					if(dt.Rows[n]["JobTypeID"]!=null && dt.Rows[n]["JobTypeID"].ToString()!="")
					{
						model.JobTypeID=int.Parse(dt.Rows[n]["JobTypeID"].ToString());
					}
					if(dt.Rows[n]["JobTypeName"]!=null && dt.Rows[n]["JobTypeName"].ToString()!="")
					{
					model.JobTypeName=dt.Rows[n]["JobTypeName"].ToString();
					}
					if(dt.Rows[n]["PublishDate"]!=null && dt.Rows[n]["PublishDate"].ToString()!="")
					{
						model.PublishDate=DateTime.Parse(dt.Rows[n]["PublishDate"].ToString());
					}
					if(dt.Rows[n]["IsEnable"]!=null && dt.Rows[n]["IsEnable"].ToString()!="")
					{
						model.IsEnable=int.Parse(dt.Rows[n]["IsEnable"].ToString());
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