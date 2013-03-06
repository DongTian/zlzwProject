using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
    /// <summary>
    /// 数据访问类:CareersTypeListDAL
    /// </summary>
    public partial class CareersTypeListDAL
    {
        public CareersTypeListDAL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CareersTypeID)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@CareersTypeID", SqlDbType.Int,4)
};
            parameters[0].Value = CareersTypeID;

            int result = DbHelperSQL.RunProcedure("CareersTypeList_Exists", parameters, out rowsAffected);
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
        public int Add(zlzw.Model.CareersTypeListModel model)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@CareersTypeID", SqlDbType.Int,4),
					new SqlParameter("@CareersTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = model.CareersTypeName;
            parameters[2].Value = model.IsEnable;
            parameters[3].Value = model.PublishDate;
            parameters[4].Value = model.Other01;
            parameters[5].Value = model.Other02;

            DbHelperSQL.RunProcedure("CareersTypeList_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        /// <summary>
        ///  更新一条数据
        /// </summary>
        public bool Update(zlzw.Model.CareersTypeListModel model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@CareersTypeID", SqlDbType.Int,4),
					new SqlParameter("@CareersTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.CareersTypeID;
            parameters[1].Value = model.CareersTypeName;
            parameters[2].Value = model.IsEnable;
            parameters[3].Value = model.PublishDate;
            parameters[4].Value = model.Other01;
            parameters[5].Value = model.Other02;

            DbHelperSQL.RunProcedure("CareersTypeList_Update", parameters, out rowsAffected);
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
        public bool Delete(int CareersTypeID)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@CareersTypeID", SqlDbType.Int,4)
};
            parameters[0].Value = CareersTypeID;

            DbHelperSQL.RunProcedure("CareersTypeList_Delete", parameters, out rowsAffected);
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
        public bool DeleteList(string CareersTypeIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CareersTypeList ");
            strSql.Append(" where CareersTypeID in (" + CareersTypeIDlist + ")  ");
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
        public zlzw.Model.CareersTypeListModel GetModel(int CareersTypeID)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@CareersTypeID", SqlDbType.Int,4)
};
            parameters[0].Value = CareersTypeID;

            zlzw.Model.CareersTypeListModel model = new zlzw.Model.CareersTypeListModel();
            DataSet ds = DbHelperSQL.RunProcedure("CareersTypeList_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["CareersTypeID"] != null && ds.Tables[0].Rows[0]["CareersTypeID"].ToString() != "")
                {
                    model.CareersTypeID = int.Parse(ds.Tables[0].Rows[0]["CareersTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CareersTypeName"] != null && ds.Tables[0].Rows[0]["CareersTypeName"].ToString() != "")
                {
                    model.CareersTypeName = ds.Tables[0].Rows[0]["CareersTypeName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["IsEnable"] != null && ds.Tables[0].Rows[0]["IsEnable"].ToString() != "")
                {
                    model.IsEnable = int.Parse(ds.Tables[0].Rows[0]["IsEnable"].ToString());
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
            strSql.Append("select CareersTypeID,CareersTypeName,IsEnable,PublishDate,Other01,Other02 ");
            strSql.Append(" FROM CareersTypeList ");
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
            strSql.Append(" CareersTypeID,CareersTypeName,IsEnable,PublishDate,Other01,Other02 ");
            strSql.Append(" FROM CareersTypeList ");
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
            parameters[0].Value = "CareersTypeList";
            parameters[1].Value = "CareersTypeID";
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
            parameters[0].Value = "CareersTypeList";
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