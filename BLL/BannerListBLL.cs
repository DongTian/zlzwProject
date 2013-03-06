using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
    /// <summary>
    /// BannerListBLL
    /// </summary>
    public partial class BannerListBLL
    {
        private readonly zlzw.DAL.BannerListDAL dal = new zlzw.DAL.BannerListDAL();
        public BannerListBLL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int BannerID)
        {
            return dal.Exists(BannerID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(zlzw.Model.BannerListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(zlzw.Model.BannerListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int BannerID)
        {

            return dal.Delete(BannerID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string BannerIDlist)
        {
            return dal.DeleteList(BannerIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public zlzw.Model.BannerListModel GetModel(int BannerID)
        {

            return dal.GetModel(BannerID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public zlzw.Model.BannerListModel GetModelByCache(int BannerID)
        {

            string CacheKey = "BannerListModelModel-" + BannerID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(BannerID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (zlzw.Model.BannerListModel)objModel;
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<zlzw.Model.BannerListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<zlzw.Model.BannerListModel> DataTableToList(DataTable dt)
        {
            List<zlzw.Model.BannerListModel> modelList = new List<zlzw.Model.BannerListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                zlzw.Model.BannerListModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new zlzw.Model.BannerListModel();
                    if (dt.Rows[n]["BannerID"] != null && dt.Rows[n]["BannerID"].ToString() != "")
                    {
                        model.BannerID = int.Parse(dt.Rows[n]["BannerID"].ToString());
                    }
                    if (dt.Rows[n]["BannerGUID"] != null && dt.Rows[n]["BannerGUID"].ToString() != "")
                    {
                        model.BannerGUID = new Guid(dt.Rows[n]["BannerGUID"].ToString());
                    }
                    if (dt.Rows[n]["BannerType"] != null && dt.Rows[n]["BannerType"].ToString() != "")
                    {
                        model.BannerType = int.Parse(dt.Rows[n]["BannerType"].ToString());
                    }
                    if (dt.Rows[n]["BannerTitle"] != null && dt.Rows[n]["BannerTitle"].ToString() != "")
                    {
                        model.BannerTitle = dt.Rows[n]["BannerTitle"].ToString();
                    }
                    if (dt.Rows[n]["BannerContent"] != null && dt.Rows[n]["BannerContent"].ToString() != "")
                    {
                        model.BannerContent = dt.Rows[n]["BannerContent"].ToString();
                    }
                    if (dt.Rows[n]["BannerImage"] != null && dt.Rows[n]["BannerImage"].ToString() != "")
                    {
                        model.BannerImage = dt.Rows[n]["BannerImage"].ToString();
                    }
                    if (dt.Rows[n]["BannerLinks"] != null && dt.Rows[n]["BannerLinks"].ToString() != "")
                    {
                        model.BannerLinks = dt.Rows[n]["BannerLinks"].ToString();
                    }
                    if (dt.Rows[n]["IsEnable"] != null && dt.Rows[n]["IsEnable"].ToString() != "")
                    {
                        model.IsEnable = int.Parse(dt.Rows[n]["IsEnable"].ToString());
                    }
                    if (dt.Rows[n]["IsHot"] != null && dt.Rows[n]["IsHot"].ToString() != "")
                    {
                        model.IsHot = int.Parse(dt.Rows[n]["IsHot"].ToString());
                    }
                    if (dt.Rows[n]["PublishDate"] != null && dt.Rows[n]["PublishDate"].ToString() != "")
                    {
                        model.PublishDate = DateTime.Parse(dt.Rows[n]["PublishDate"].ToString());
                    }
                    if (dt.Rows[n]["Other01"] != null && dt.Rows[n]["Other01"].ToString() != "")
                    {
                        model.Other01 = dt.Rows[n]["Other01"].ToString();
                    }
                    if (dt.Rows[n]["Other02"] != null && dt.Rows[n]["Other02"].ToString() != "")
                    {
                        model.Other02 = dt.Rows[n]["Other02"].ToString();
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