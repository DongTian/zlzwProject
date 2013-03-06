using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
	/// <summary>
	/// JobListBLL
	/// </summary>
	public partial class JobListBLL
	{
		private readonly zlzw.DAL.JobListDAL dal=new zlzw.DAL.JobListDAL();
		public JobListBLL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JobID)
		{
			return dal.Exists(JobID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zlzw.Model.JobListModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.JobListModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JobID)
		{
			
			return dal.Delete(JobID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JobIDlist )
		{
			return dal.DeleteList(JobIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zlzw.Model.JobListModel GetModel(int JobID)
		{
			
			return dal.GetModel(JobID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zlzw.Model.JobListModel GetModelByCache(int JobID)
		{
			
			string CacheKey = "JobListModelModel-" + JobID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JobID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (zlzw.Model.JobListModel)objModel;
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
		public List<zlzw.Model.JobListModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zlzw.Model.JobListModel> DataTableToList(DataTable dt)
		{
			List<zlzw.Model.JobListModel> modelList = new List<zlzw.Model.JobListModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zlzw.Model.JobListModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zlzw.Model.JobListModel();
					if(dt.Rows[n]["JobID"]!=null && dt.Rows[n]["JobID"].ToString()!="")
					{
						model.JobID=int.Parse(dt.Rows[n]["JobID"].ToString());
					}
					if(dt.Rows[n]["JobTypeID"]!=null && dt.Rows[n]["JobTypeID"].ToString()!="")
					{
						model.JobTypeID=int.Parse(dt.Rows[n]["JobTypeID"].ToString());
					}
					if(dt.Rows[n]["JobName"]!=null && dt.Rows[n]["JobName"].ToString()!="")
					{
					model.JobName=dt.Rows[n]["JobName"].ToString();
					}
					if(dt.Rows[n]["IsHot"]!=null && dt.Rows[n]["IsHot"].ToString()!="")
					{
						model.IsHot=int.Parse(dt.Rows[n]["IsHot"].ToString());
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

		#endregion  Method
	}
}