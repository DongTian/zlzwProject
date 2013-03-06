using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:JobListDAL
	/// </summary>
	public partial class JobListDAL
	{
		public JobListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JobID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4)
};
			parameters[0].Value = JobID;

			int result= DbHelperSQL.RunProcedure("JobList_Exists",parameters,out rowsAffected);
			if(result==1)
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
		public int Add(zlzw.Model.JobListModel model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4),
					new SqlParameter("@JobTypeID", SqlDbType.Int,4),
					new SqlParameter("@JobName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.Int,4)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.JobTypeID;
			parameters[2].Value = model.JobName;
			parameters[3].Value = model.IsHot;
			parameters[4].Value = model.IsEnable;
			parameters[5].Value = model.PublishDate;
			parameters[6].Value = model.Other01;
			parameters[7].Value = model.Other02;
			parameters[8].Value = model.Other03;

			DbHelperSQL.RunProcedure("JobList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.JobListModel model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4),
					new SqlParameter("@JobTypeID", SqlDbType.Int,4),
					new SqlParameter("@JobName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.Int,4)};
			parameters[0].Value = model.JobID;
			parameters[1].Value = model.JobTypeID;
			parameters[2].Value = model.JobName;
			parameters[3].Value = model.IsHot;
			parameters[4].Value = model.IsEnable;
			parameters[5].Value = model.PublishDate;
			parameters[6].Value = model.Other01;
			parameters[7].Value = model.Other02;
			parameters[8].Value = model.Other03;

			DbHelperSQL.RunProcedure("JobList_Update",parameters,out rowsAffected);
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
		public bool Delete(int JobID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4)
};
			parameters[0].Value = JobID;

			DbHelperSQL.RunProcedure("JobList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string JobIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobList ");
			strSql.Append(" where JobID in ("+JobIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public zlzw.Model.JobListModel GetModel(int JobID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4)
};
			parameters[0].Value = JobID;

			zlzw.Model.JobListModel model=new zlzw.Model.JobListModel();
			DataSet ds= DbHelperSQL.RunProcedure("JobList_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["JobID"]!=null && ds.Tables[0].Rows[0]["JobID"].ToString()!="")
				{
					model.JobID=int.Parse(ds.Tables[0].Rows[0]["JobID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JobTypeID"]!=null && ds.Tables[0].Rows[0]["JobTypeID"].ToString()!="")
				{
					model.JobTypeID=int.Parse(ds.Tables[0].Rows[0]["JobTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JobName"]!=null && ds.Tables[0].Rows[0]["JobName"].ToString()!="")
				{
					model.JobName=ds.Tables[0].Rows[0]["JobName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IsHot"]!=null && ds.Tables[0].Rows[0]["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(ds.Tables[0].Rows[0]["IsHot"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsEnable"]!=null && ds.Tables[0].Rows[0]["IsEnable"].ToString()!="")
				{
					model.IsEnable=int.Parse(ds.Tables[0].Rows[0]["IsEnable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PublishDate"]!=null && ds.Tables[0].Rows[0]["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(ds.Tables[0].Rows[0]["PublishDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Other01"]!=null && ds.Tables[0].Rows[0]["Other01"].ToString()!="")
				{
					model.Other01=ds.Tables[0].Rows[0]["Other01"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Other02"]!=null && ds.Tables[0].Rows[0]["Other02"].ToString()!="")
				{
					model.Other02=ds.Tables[0].Rows[0]["Other02"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Other03"]!=null && ds.Tables[0].Rows[0]["Other03"].ToString()!="")
				{
					model.Other03=int.Parse(ds.Tables[0].Rows[0]["Other03"].ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select JobID,JobTypeID,JobName,IsHot,IsEnable,PublishDate,Other01,Other02,Other03 ");
			strSql.Append(" FROM JobList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" JobID,JobTypeID,JobName,IsHot,IsEnable,PublishDate,Other01,Other02,Other03 ");
			strSql.Append(" FROM JobList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			parameters[0].Value = "JobList";
			parameters[1].Value = "JobID";
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
            parameters[0].Value = "JobList";
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