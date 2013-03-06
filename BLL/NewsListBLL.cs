using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
	/// <summary>
	/// NewsListBLL
	/// </summary>
	public partial class NewsListBLL
	{
		private readonly zlzw.DAL.NewsListDAL dal=new zlzw.DAL.NewsListDAL();
		public NewsListBLL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NewsID)
		{
			return dal.Exists(NewsID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zlzw.Model.NewsListModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.NewsListModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NewsID)
		{
			
			return dal.Delete(NewsID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NewsIDlist )
		{
			return dal.DeleteList(NewsIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zlzw.Model.NewsListModel GetModel(int NewsID)
		{
			
			return dal.GetModel(NewsID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zlzw.Model.NewsListModel GetModelByCache(int NewsID)
		{
			
			string CacheKey = "NewsListModelModel-" + NewsID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NewsID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (zlzw.Model.NewsListModel)objModel;
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
		public List<zlzw.Model.NewsListModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zlzw.Model.NewsListModel> DataTableToList(DataTable dt)
		{
			List<zlzw.Model.NewsListModel> modelList = new List<zlzw.Model.NewsListModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zlzw.Model.NewsListModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zlzw.Model.NewsListModel();
					if(dt.Rows[n]["NewsID"]!=null && dt.Rows[n]["NewsID"].ToString()!="")
					{
						model.NewsID=int.Parse(dt.Rows[n]["NewsID"].ToString());
					}
					if(dt.Rows[n]["NewsGUID"]!=null && dt.Rows[n]["NewsGUID"].ToString()!="")
					{
						model.NewsGUID=new Guid(dt.Rows[n]["NewsGUID"].ToString());
					}
					if(dt.Rows[n]["DictionaryKey"]!=null && dt.Rows[n]["DictionaryKey"].ToString()!="")
					{
					model.DictionaryKey=dt.Rows[n]["DictionaryKey"].ToString();
					}
					if(dt.Rows[n]["NewsTitle"]!=null && dt.Rows[n]["NewsTitle"].ToString()!="")
					{
					model.NewsTitle=dt.Rows[n]["NewsTitle"].ToString();
					}
					if(dt.Rows[n]["NewsTag"]!=null && dt.Rows[n]["NewsTag"].ToString()!="")
					{
					model.NewsTag=dt.Rows[n]["NewsTag"].ToString();
					}
					if(dt.Rows[n]["NewsSummary"]!=null && dt.Rows[n]["NewsSummary"].ToString()!="")
					{
					model.NewsSummary=dt.Rows[n]["NewsSummary"].ToString();
					}
					if(dt.Rows[n]["NewsContent"]!=null && dt.Rows[n]["NewsContent"].ToString()!="")
					{
					model.NewsContent=dt.Rows[n]["NewsContent"].ToString();
					}
					if(dt.Rows[n]["NewsSource"]!=null && dt.Rows[n]["NewsSource"].ToString()!="")
					{
					model.NewsSource=dt.Rows[n]["NewsSource"].ToString();
					}
					if(dt.Rows[n]["NewsSourceLink"]!=null && dt.Rows[n]["NewsSourceLink"].ToString()!="")
					{
					model.NewsSourceLink=dt.Rows[n]["NewsSourceLink"].ToString();
					}
					if(dt.Rows[n]["PublishUserGUID"]!=null && dt.Rows[n]["PublishUserGUID"].ToString()!="")
					{
						model.PublishUserGUID=new Guid(dt.Rows[n]["PublishUserGUID"].ToString());
					}
					if(dt.Rows[n]["PublishDate"]!=null && dt.Rows[n]["PublishDate"].ToString()!="")
					{
						model.PublishDate=DateTime.Parse(dt.Rows[n]["PublishDate"].ToString());
					}
					if(dt.Rows[n]["IsEnable"]!=null && dt.Rows[n]["IsEnable"].ToString()!="")
					{
						model.IsEnable=int.Parse(dt.Rows[n]["IsEnable"].ToString());
					}
					if(dt.Rows[n]["IsHot"]!=null && dt.Rows[n]["IsHot"].ToString()!="")
					{
						model.IsHot=int.Parse(dt.Rows[n]["IsHot"].ToString());
					}
					if(dt.Rows[n]["ViewCount"]!=null && dt.Rows[n]["ViewCount"].ToString()!="")
					{
						model.ViewCount=int.Parse(dt.Rows[n]["ViewCount"].ToString());
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
					model.Other03=dt.Rows[n]["Other03"].ToString();
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