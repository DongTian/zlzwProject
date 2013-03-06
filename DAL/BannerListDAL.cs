using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
    /// <summary>
    /// 数据访问类:BannerListDAL
    /// </summary>
    public partial class BannerListDAL
    {
        public BannerListDAL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int BannerID)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@BannerID", SqlDbType.Int,4)
};
            parameters[0].Value = BannerID;

            int result = DbHelperSQL.RunProcedure("BannerList_Exists", parameters, out rowsAffected);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  增加一条数据
        /// </summary>
        public int Add(zlzw.Model.BannerListModel model)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@BannerID", SqlDbType.Int,4),
					new SqlParameter("@BannerGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@BannerType", SqlDbType.Int,4),
					new SqlParameter("@BannerTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@BannerContent", SqlDbType.NVarChar),
					new SqlParameter("@BannerImage", SqlDbType.NVarChar,200),
					new SqlParameter("@BannerLinks", SqlDbType.NVarChar,200),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = Guid.NewGuid();
            parameters[2].Value = model.BannerType;
            parameters[3].Value = model.BannerTitle;
            parameters[4].Value = model.BannerContent;
            parameters[5].Value = model.BannerImage;
            parameters[6].Value = model.BannerLinks;
            parameters[7].Value = model.IsEnable;
            parameters[8].Value = model.IsHot;
            parameters[9].Value = model.PublishDate;
            parameters[10].Value = model.Other01;
            parameters[11].Value = model.Other02;

            DbHelperSQL.RunProcedure("BannerList_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        /// <summary>
        ///  更新一条数据
        /// </summary>
        public bool Update(zlzw.Model.BannerListModel model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@BannerID", SqlDbType.Int,4),
					new SqlParameter("@BannerGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@BannerType", SqlDbType.Int,4),
					new SqlParameter("@BannerTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@BannerContent", SqlDbType.NVarChar),
					new SqlParameter("@BannerImage", SqlDbType.NVarChar,200),
					new SqlParameter("@BannerLinks", SqlDbType.NVarChar,200),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.BannerID;
            parameters[1].Value = model.BannerGUID;
            parameters[2].Value = model.BannerType;
            parameters[3].Value = model.BannerTitle;
            parameters[4].Value = model.BannerContent;
            parameters[5].Value = model.BannerImage;
            parameters[6].Value = model.BannerLinks;
            parameters[7].Value = model.IsEnable;
            parameters[8].Value = model.IsHot;
            parameters[9].Value = model.PublishDate;
            parameters[10].Value = model.Other01;
            parameters[11].Value = model.Other02;

            DbHelperSQL.RunProcedure("BannerList_Update", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int BannerID)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@BannerID", SqlDbType.Int,4)
};
            parameters[0].Value = BannerID;

            DbHelperSQL.RunProcedure("BannerList_Delete", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string BannerIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from BannerList ");
            strSql.Append(" where BannerID in (" + BannerIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public zlzw.Model.BannerListModel GetModel(int BannerID)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@BannerID", SqlDbType.Int,4)
};
            parameters[0].Value = BannerID;

            zlzw.Model.BannerListModel model = new zlzw.Model.BannerListModel();
            DataSet ds = DbHelperSQL.RunProcedure("BannerList_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["BannerID"] != null && ds.Tables[0].Rows[0]["BannerID"].ToString() != "")
                {
                    model.BannerID = int.Parse(ds.Tables[0].Rows[0]["BannerID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BannerGUID"] != null && ds.Tables[0].Rows[0]["BannerGUID"].ToString() != "")
                {
                    model.BannerGUID = new Guid(ds.Tables[0].Rows[0]["BannerGUID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BannerType"] != null && ds.Tables[0].Rows[0]["BannerType"].ToString() != "")
                {
                    model.BannerType = int.Parse(ds.Tables[0].Rows[0]["BannerType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BannerTitle"] != null && ds.Tables[0].Rows[0]["BannerTitle"].ToString() != "")
                {
                    model.BannerTitle = ds.Tables[0].Rows[0]["BannerTitle"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BannerContent"] != null && ds.Tables[0].Rows[0]["BannerContent"].ToString() != "")
                {
                    model.BannerContent = ds.Tables[0].Rows[0]["BannerContent"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BannerImage"] != null && ds.Tables[0].Rows[0]["BannerImage"].ToString() != "")
                {
                    model.BannerImage = ds.Tables[0].Rows[0]["BannerImage"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BannerLinks"] != null && ds.Tables[0].Rows[0]["BannerLinks"].ToString() != "")
                {
                    model.BannerLinks = ds.Tables[0].Rows[0]["BannerLinks"].ToString();
                }
                if (ds.Tables[0].Rows[0]["IsEnable"] != null && ds.Tables[0].Rows[0]["IsEnable"].ToString() != "")
                {
                    model.IsEnable = int.Parse(ds.Tables[0].Rows[0]["IsEnable"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsHot"] != null && ds.Tables[0].Rows[0]["IsHot"].ToString() != "")
                {
                    model.IsHot = int.Parse(ds.Tables[0].Rows[0]["IsHot"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PublishDate"] != null && ds.Tables[0].Rows[0]["PublishDate"].ToString() != "")
                {
                    model.PublishDate = DateTime.Parse(ds.Tables[0].Rows[0]["PublishDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Other01"] != null && ds.Tables[0].Rows[0]["Other01"].ToString() != "")
                {
                    model.Other01 = ds.Tables[0].Rows[0]["Other01"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Other02"] != null && ds.Tables[0].Rows[0]["Other02"].ToString() != "")
                {
                    model.Other02 = ds.Tables[0].Rows[0]["Other02"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BannerID,BannerGUID,BannerType,BannerTitle,BannerContent,BannerImage,BannerLinks,IsEnable,IsHot,PublishDate,Other01,Other02 ");
            strSql.Append(" FROM BannerList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" BannerID,BannerGUID,BannerType,BannerTitle,BannerContent,BannerImage,BannerLinks,IsEnable,IsHot,PublishDate,Other01,Other02 ");
            strSql.Append(" FROM BannerList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "BannerList";
            parameters[1].Value = "BannerID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  Method

        #region  MethodEx

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
            SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),//表名
					new SqlParameter("@RetColumns", SqlDbType.VarChar, 1000),//需要显示的列名
					new SqlParameter("@Orderfld", SqlDbType.VarChar,255),//需要排序的字段名
					new SqlParameter("@PageSize", SqlDbType.Int),//总每页显示的行数
					new SqlParameter("@PageIndex", SqlDbType.Int),//当前页
					new SqlParameter("@IsCount", SqlDbType.Bit),//返回的记录总数。非0是返回
					new SqlParameter("@OrderType", SqlDbType.VarChar,50),//排序类型
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),//查询条件
					};
            parameters[0].Value = "BannerList";
            parameters[1].Value = strColumns;
            parameters[2].Value = strOrderColumn;
            parameters[3].Value = PageSize;
            parameters[4].Value = PageIndex;
            parameters[5].Value = nIsCount;
            parameters[6].Value = strOrderType;
            parameters[7].Value = strWhere;
            return DbHelperSQL.RunProcedure("GetRecordFromPage", parameters, "ds");
        }

        #endregion  MethodEx
    }
}