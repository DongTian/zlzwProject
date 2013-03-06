using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
    /// <summary>
    /// CareersTypeListBLL
    /// </summary>
    public partial class CareersTypeListBLL
    {
        private readonly zlzw.DAL.CareersTypeListDAL dal = new zlzw.DAL.CareersTypeListDAL();
        public CareersTypeListBLL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CareersTypeID)
        {
            return dal.Exists(CareersTypeID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(zlzw.Model.CareersTypeListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(zlzw.Model.CareersTypeListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int CareersTypeID)
        {

            return dal.Delete(CareersTypeID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string CareersTypeIDlist)
        {
            return dal.DeleteList(CareersTypeIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public zlzw.Model.CareersTypeListModel GetModel(int CareersTypeID)
        {

            return dal.GetModel(CareersTypeID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public zlzw.Model.CareersTypeListModel GetModelByCache(int CareersTypeID)
        {

            string CacheKey = "CareersTypeListModelModel-" + CareersTypeID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(CareersTypeID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (zlzw.Model.CareersTypeListModel)objModel;
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
        public List<zlzw.Model.CareersTypeListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<zlzw.Model.CareersTypeListModel> DataTableToList(DataTable dt)
        {
            List<zlzw.Model.CareersTypeListModel> modelList = new List<zlzw.Model.CareersTypeListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                zlzw.Model.CareersTypeListModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new zlzw.Model.CareersTypeListModel();
                    if (dt.Rows[n]["CareersTypeID"] != null && dt.Rows[n]["CareersTypeID"].ToString() != "")
                    {
                        model.CareersTypeID = int.Parse(dt.Rows[n]["CareersTypeID"].ToString());
                    }
                    if (dt.Rows[n]["CareersTypeName"] != null && dt.Rows[n]["CareersTypeName"].ToString() != "")
                    {
                        model.CareersTypeName = dt.Rows[n]["CareersTypeName"].ToString();
                    }
                    if (dt.Rows[n]["IsEnable"] != null && dt.Rows[n]["IsEnable"].ToString() != "")
                    {
                        model.IsEnable = int.Parse(dt.Rows[n]["IsEnable"].ToString());
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