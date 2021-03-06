﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
    /// <summary>
    /// 数据访问类:PartnersJobListDAL
    /// </summary>
    public partial class PartnersJobListDAL
    {
        public PartnersJobListDAL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PartnersJobID)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@PartnersJobID", SqlDbType.Int,4)
			};
            parameters[0].Value = PartnersJobID;

            int result = DbHelperSQL.RunProcedure("PartnersJobList_Exists", parameters, out rowsAffected);
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
        public int Add(zlzw.Model.PartnersJobListModel model)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@PartnersJobID", SqlDbType.Int,4),
					new SqlParameter("@PartnerGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@WorkAdd", SqlDbType.NVarChar,200),
					new SqlParameter("@RecruitmentNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@PostInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@PostDemand", SqlDbType.NVarChar,-1),
					new SqlParameter("@TreatmentInfo", SqlDbType.NVarChar,-1),
					new SqlParameter("@OtherInfo", SqlDbType.NVarChar,-1),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,200)};
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = model.PartnerGUID;
            parameters[2].Value = model.WorkAdd;
            parameters[3].Value = model.RecruitmentNumber;
            parameters[4].Value = model.PostInfo;
            parameters[5].Value = model.PostDemand;
            parameters[6].Value = model.TreatmentInfo;
            parameters[7].Value = model.OtherInfo;
            parameters[8].Value = model.IsEnable;
            parameters[9].Value = model.IsHot;
            parameters[10].Value = model.PublishDate;
            parameters[11].Value = model.Other01;
            parameters[12].Value = model.Other02;

            DbHelperSQL.RunProcedure("PartnersJobList_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        /// <summary>
        ///  更新一条数据
        /// </summary>
        public bool Update(zlzw.Model.PartnersJobListModel model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@PartnersJobID", SqlDbType.Int,4),
					new SqlParameter("@PartnerGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@WorkAdd", SqlDbType.NVarChar,200),
					new SqlParameter("@RecruitmentNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@PostInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@PostDemand", SqlDbType.NVarChar,-1),
					new SqlParameter("@TreatmentInfo", SqlDbType.NVarChar,-1),
					new SqlParameter("@OtherInfo", SqlDbType.NVarChar,-1),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.PartnersJobID;
            parameters[1].Value = model.PartnerGUID;
            parameters[2].Value = model.WorkAdd;
            parameters[3].Value = model.RecruitmentNumber;
            parameters[4].Value = model.PostInfo;
            parameters[5].Value = model.PostDemand;
            parameters[6].Value = model.TreatmentInfo;
            parameters[7].Value = model.OtherInfo;
            parameters[8].Value = model.IsEnable;
            parameters[9].Value = model.IsHot;
            parameters[10].Value = model.PublishDate;
            parameters[11].Value = model.Other01;
            parameters[12].Value = model.Other02;

            DbHelperSQL.RunProcedure("PartnersJobList_Update", parameters, out rowsAffected);
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
        public bool Delete(int PartnersJobID)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@PartnersJobID", SqlDbType.Int,4)
			};
            parameters[0].Value = PartnersJobID;

            DbHelperSQL.RunProcedure("PartnersJobList_Delete", parameters, out rowsAffected);
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
        public bool DeleteList(string PartnersJobIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PartnersJobList ");
            strSql.Append(" where PartnersJobID in (" + PartnersJobIDlist + ")  ");
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
        public zlzw.Model.PartnersJobListModel GetModel(int PartnersJobID)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@PartnersJobID", SqlDbType.Int,4)
			};
            parameters[0].Value = PartnersJobID;

            zlzw.Model.PartnersJobListModel model = new zlzw.Model.PartnersJobListModel();
            DataSet ds = DbHelperSQL.RunProcedure("PartnersJobList_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public zlzw.Model.PartnersJobListModel DataRowToModel(DataRow row)
        {
            zlzw.Model.PartnersJobListModel model = new zlzw.Model.PartnersJobListModel();
            if (row != null)
            {
                if (row["PartnersJobID"] != null && row["PartnersJobID"].ToString() != "")
                {
                    model.PartnersJobID = int.Parse(row["PartnersJobID"].ToString());
                }
                if (row["PartnerGUID"] != null && row["PartnerGUID"].ToString() != "")
                {
                    model.PartnerGUID = new Guid(row["PartnerGUID"].ToString());
                }
                if (row["WorkAdd"] != null)
                {
                    model.WorkAdd = row["WorkAdd"].ToString();
                }
                if (row["RecruitmentNumber"] != null)
                {
                    model.RecruitmentNumber = row["RecruitmentNumber"].ToString();
                }
                if (row["PostInfo"] != null)
                {
                    model.PostInfo = row["PostInfo"].ToString();
                }
                if (row["PostDemand"] != null)
                {
                    model.PostDemand = row["PostDemand"].ToString();
                }
                if (row["TreatmentInfo"] != null)
                {
                    model.TreatmentInfo = row["TreatmentInfo"].ToString();
                }
                if (row["OtherInfo"] != null)
                {
                    model.OtherInfo = row["OtherInfo"].ToString();
                }
                if (row["IsEnable"] != null && row["IsEnable"].ToString() != "")
                {
                    model.IsEnable = int.Parse(row["IsEnable"].ToString());
                }
                if (row["IsHot"] != null && row["IsHot"].ToString() != "")
                {
                    model.IsHot = int.Parse(row["IsHot"].ToString());
                }
                if (row["PublishDate"] != null && row["PublishDate"].ToString() != "")
                {
                    model.PublishDate = DateTime.Parse(row["PublishDate"].ToString());
                }
                if (row["Other01"] != null)
                {
                    model.Other01 = row["Other01"].ToString();
                }
                if (row["Other02"] != null)
                {
                    model.Other02 = row["Other02"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PartnersJobID,PartnerGUID,WorkAdd,RecruitmentNumber,PostInfo,PostDemand,TreatmentInfo,OtherInfo,IsEnable,IsHot,PublishDate,Other01,Other02 ");
            strSql.Append(" FROM PartnersJobList ");
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
            strSql.Append(" PartnersJobID,PartnerGUID,WorkAdd,RecruitmentNumber,PostInfo,PostDemand,TreatmentInfo,OtherInfo,IsEnable,IsHot,PublishDate,Other01,Other02 ");
            strSql.Append(" FROM PartnersJobList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM PartnersJobList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.PartnersJobID desc");
            }
            strSql.Append(")AS Row, T.*  from PartnersJobList T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
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
            parameters[0].Value = "PartnersJobList";
            parameters[1].Value = "PartnersJobID";
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
            parameters[0].Value = "PartnersJobList";
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