using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zlzw.Model;
namespace zlzw.BLL
{
    /// <summary>
    /// DictionaryListBLL
    /// </summary>
    public partial class DictionaryListBLL
    {
        private readonly zlzw.DAL.DictionaryListDAL dal = new zlzw.DAL.DictionaryListDAL();
        public DictionaryListBLL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DictionaryListID)
        {
            return dal.Exists(DictionaryListID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(zlzw.Model.DictionaryListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(zlzw.Model.DictionaryListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DictionaryListID)
        {

            return dal.Delete(DictionaryListID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string DictionaryListIDlist)
        {
            return dal.DeleteList(DictionaryListIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public zlzw.Model.DictionaryListModel GetModel(int DictionaryListID)
        {

            return dal.GetModel(DictionaryListID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public zlzw.Model.DictionaryListModel GetModelByCache(int DictionaryListID)
        {

            string CacheKey = "DictionaryListModelModel-" + DictionaryListID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DictionaryListID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (zlzw.Model.DictionaryListModel)objModel;
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
        public List<zlzw.Model.DictionaryListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<zlzw.Model.DictionaryListModel> DataTableToList(DataTable dt)
        {
            List<zlzw.Model.DictionaryListModel> modelList = new List<zlzw.Model.DictionaryListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                zlzw.Model.DictionaryListModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new zlzw.Model.DictionaryListModel();
                    if (dt.Rows[n]["DictionaryListID"] != null && dt.Rows[n]["DictionaryListID"].ToString() != "")
                    {
                        model.DictionaryListID = int.Parse(dt.Rows[n]["DictionaryListID"].ToString());
                    }
                    if (dt.Rows[n]["DictionaryKey"] != null && dt.Rows[n]["DictionaryKey"].ToString() != "")
                    {
                        model.DictionaryKey = dt.Rows[n]["DictionaryKey"].ToString();
                    }
                    if (dt.Rows[n]["DictionaryValue"] != null && dt.Rows[n]["DictionaryValue"].ToString() != "")
                    {
                        model.DictionaryValue = dt.Rows[n]["DictionaryValue"].ToString();
                    }
                    if (dt.Rows[n]["DictionaryCategory"] != null && dt.Rows[n]["DictionaryCategory"].ToString() != "")
                    {
                        model.DictionaryCategory = dt.Rows[n]["DictionaryCategory"].ToString();
                    }
                    if (dt.Rows[n]["DictionaryDesc"] != null && dt.Rows[n]["DictionaryDesc"].ToString() != "")
                    {
                        model.DictionaryDesc = dt.Rows[n]["DictionaryDesc"].ToString();
                    }
                    if (dt.Rows[n]["OrderNumber"] != null && dt.Rows[n]["OrderNumber"].ToString() != "")
                    {
                        model.OrderNumber = int.Parse(dt.Rows[n]["OrderNumber"].ToString());
                    }
                    if (dt.Rows[n]["IsInner"] != null && dt.Rows[n]["IsInner"].ToString() != "")
                    {
                        model.IsInner = int.Parse(dt.Rows[n]["IsInner"].ToString());
                    }
                    if (dt.Rows[n]["IsEnable"] != null && dt.Rows[n]["IsEnable"].ToString() != "")
                    {
                        model.IsEnable = int.Parse(dt.Rows[n]["IsEnable"].ToString());
                    }
                    if (dt.Rows[n]["PublishDate"] != null && dt.Rows[n]["PublishDate"].ToString() != "")
                    {
                        model.PublishDate = DateTime.Parse(dt.Rows[n]["PublishDate"].ToString());
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