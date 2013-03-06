using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:AdminListDAL
	/// </summary>
	public partial class AdminListDAL
	{
		public AdminListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AdminID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@AdminID", SqlDbType.Int,4)
};
			parameters[0].Value = AdminID;

			int result= DbHelperSQL.RunProcedure("AdminList_Exists",parameters,out rowsAffected);
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
		public int Add(zlzw.Model.AdminListModel model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@AdminGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@AdminName", SqlDbType.NVarChar,50),
					new SqlParameter("@AdminPassword", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.AdminName;
			parameters[3].Value = model.AdminPassword;
			parameters[4].Value = model.IsEnable;
			parameters[5].Value = model.PublishDate;
			parameters[6].Value = model.Other01;
			parameters[7].Value = model.Other02;

			DbHelperSQL.RunProcedure("AdminList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.AdminListModel model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@AdminGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@AdminName", SqlDbType.NVarChar,50),
					new SqlParameter("@AdminPassword", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.AdminID;
			parameters[1].Value = model.AdminGUID;
			parameters[2].Value = model.AdminName;
			parameters[3].Value = model.AdminPassword;
			parameters[4].Value = model.IsEnable;
			parameters[5].Value = model.PublishDate;
			parameters[6].Value = model.Other01;
			parameters[7].Value = model.Other02;

			DbHelperSQL.RunProcedure("AdminList_Update",parameters,out rowsAffected);
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
		public bool Delete(int AdminID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@AdminID", SqlDbType.Int,4)
};
			parameters[0].Value = AdminID;

			DbHelperSQL.RunProcedure("AdminList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string AdminIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AdminList ");
			strSql.Append(" where AdminID in ("+AdminIDlist + ")  ");
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
		public zlzw.Model.AdminListModel GetModel(int AdminID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@AdminID", SqlDbType.Int,4)
};
			parameters[0].Value = AdminID;

			zlzw.Model.AdminListModel model=new zlzw.Model.AdminListModel();
			DataSet ds= DbHelperSQL.RunProcedure("AdminList_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["AdminID"]!=null && ds.Tables[0].Rows[0]["AdminID"].ToString()!="")
				{
					model.AdminID=int.Parse(ds.Tables[0].Rows[0]["AdminID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdminGUID"]!=null && ds.Tables[0].Rows[0]["AdminGUID"].ToString()!="")
				{
					model.AdminGUID=new Guid(ds.Tables[0].Rows[0]["AdminGUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdminName"]!=null && ds.Tables[0].Rows[0]["AdminName"].ToString()!="")
				{
					model.AdminName=ds.Tables[0].Rows[0]["AdminName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AdminPassword"]!=null && ds.Tables[0].Rows[0]["AdminPassword"].ToString()!="")
				{
					model.AdminPassword=ds.Tables[0].Rows[0]["AdminPassword"].ToString();
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
			strSql.Append("select AdminID,AdminGUID,AdminName,AdminPassword,IsEnable,PublishDate,Other01,Other02 ");
			strSql.Append(" FROM AdminList ");
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
			strSql.Append(" AdminID,AdminGUID,AdminName,AdminPassword,IsEnable,PublishDate,Other01,Other02 ");
			strSql.Append(" FROM AdminList ");
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
			parameters[0].Value = "AdminList";
			parameters[1].Value = "AdminID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

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
            parameters[0].Value = "AdminList";
            parameters[1].Value = strColumns;
            parameters[2].Value = strOrderColumn;
            parameters[3].Value = PageSize;
            parameters[4].Value = PageIndex;
            parameters[5].Value = nIsCount;
            parameters[6].Value = strOrderType;
            parameters[7].Value = strWhere;
            return DbHelperSQL.RunProcedure("GetRecordFromPage", parameters, "ds");
        }

		#endregion  Method
	}
}