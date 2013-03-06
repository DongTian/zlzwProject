using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:NewsListDAL
	/// </summary>
	public partial class NewsListDAL
	{
		public NewsListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NewsID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsID;

			int result= DbHelperSQL.RunProcedure("NewsList_Exists",parameters,out rowsAffected);
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
		public int Add(zlzw.Model.NewsListModel model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DictionaryKey", SqlDbType.NVarChar,50),
					new SqlParameter("@NewsTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@NewsTag", SqlDbType.NVarChar,50),
					new SqlParameter("@NewsSummary", SqlDbType.NVarChar),
					new SqlParameter("@NewsContent", SqlDbType.NVarChar),
					new SqlParameter("@NewsSource", SqlDbType.NVarChar,50),
					new SqlParameter("@NewsSourceLink", SqlDbType.NVarChar,200),
					new SqlParameter("@PublishUserGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@ViewCount", SqlDbType.Int,4),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.DictionaryKey;
			parameters[3].Value = model.NewsTitle;
			parameters[4].Value = model.NewsTag;
			parameters[5].Value = model.NewsSummary;
			parameters[6].Value = model.NewsContent;
			parameters[7].Value = model.NewsSource;
			parameters[8].Value = model.NewsSourceLink;
            parameters[9].Value = model.PublishUserGUID;
			parameters[10].Value = model.PublishDate;
			parameters[11].Value = model.IsEnable;
			parameters[12].Value = model.IsHot;
			parameters[13].Value = model.ViewCount;
			parameters[14].Value = model.Other01;
			parameters[15].Value = model.Other02;
			parameters[16].Value = model.Other03;

			DbHelperSQL.RunProcedure("NewsList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.NewsListModel model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DictionaryKey", SqlDbType.NVarChar,50),
					new SqlParameter("@NewsTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@NewsTag", SqlDbType.NVarChar,50),
					new SqlParameter("@NewsSummary", SqlDbType.NVarChar),
					new SqlParameter("@NewsContent", SqlDbType.NVarChar),
					new SqlParameter("@NewsSource", SqlDbType.NVarChar,50),
					new SqlParameter("@NewsSourceLink", SqlDbType.NVarChar,200),
					new SqlParameter("@PublishUserGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@ViewCount", SqlDbType.Int,4),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.NewsID;
			parameters[1].Value = model.NewsGUID;
			parameters[2].Value = model.DictionaryKey;
			parameters[3].Value = model.NewsTitle;
			parameters[4].Value = model.NewsTag;
			parameters[5].Value = model.NewsSummary;
			parameters[6].Value = model.NewsContent;
			parameters[7].Value = model.NewsSource;
			parameters[8].Value = model.NewsSourceLink;
			parameters[9].Value = model.PublishUserGUID;
			parameters[10].Value = model.PublishDate;
			parameters[11].Value = model.IsEnable;
			parameters[12].Value = model.IsHot;
			parameters[13].Value = model.ViewCount;
			parameters[14].Value = model.Other01;
			parameters[15].Value = model.Other02;
			parameters[16].Value = model.Other03;

			DbHelperSQL.RunProcedure("NewsList_Update",parameters,out rowsAffected);
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
		public bool Delete(int NewsID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsID;

			DbHelperSQL.RunProcedure("NewsList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string NewsIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewsList ");
			strSql.Append(" where NewsID in ("+NewsIDlist + ")  ");
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
		public zlzw.Model.NewsListModel GetModel(int NewsID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsID;

			zlzw.Model.NewsListModel model=new zlzw.Model.NewsListModel();
			DataSet ds= DbHelperSQL.RunProcedure("NewsList_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NewsID"]!=null && ds.Tables[0].Rows[0]["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(ds.Tables[0].Rows[0]["NewsID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NewsGUID"]!=null && ds.Tables[0].Rows[0]["NewsGUID"].ToString()!="")
				{
					model.NewsGUID=new Guid(ds.Tables[0].Rows[0]["NewsGUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DictionaryKey"]!=null && ds.Tables[0].Rows[0]["DictionaryKey"].ToString()!="")
				{
					model.DictionaryKey=ds.Tables[0].Rows[0]["DictionaryKey"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NewsTitle"]!=null && ds.Tables[0].Rows[0]["NewsTitle"].ToString()!="")
				{
					model.NewsTitle=ds.Tables[0].Rows[0]["NewsTitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NewsTag"]!=null && ds.Tables[0].Rows[0]["NewsTag"].ToString()!="")
				{
					model.NewsTag=ds.Tables[0].Rows[0]["NewsTag"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NewsSummary"]!=null && ds.Tables[0].Rows[0]["NewsSummary"].ToString()!="")
				{
					model.NewsSummary=ds.Tables[0].Rows[0]["NewsSummary"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NewsContent"]!=null && ds.Tables[0].Rows[0]["NewsContent"].ToString()!="")
				{
					model.NewsContent=ds.Tables[0].Rows[0]["NewsContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NewsSource"]!=null && ds.Tables[0].Rows[0]["NewsSource"].ToString()!="")
				{
					model.NewsSource=ds.Tables[0].Rows[0]["NewsSource"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NewsSourceLink"]!=null && ds.Tables[0].Rows[0]["NewsSourceLink"].ToString()!="")
				{
					model.NewsSourceLink=ds.Tables[0].Rows[0]["NewsSourceLink"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PublishUserGUID"]!=null && ds.Tables[0].Rows[0]["PublishUserGUID"].ToString()!="")
				{
					model.PublishUserGUID=new Guid(ds.Tables[0].Rows[0]["PublishUserGUID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PublishDate"]!=null && ds.Tables[0].Rows[0]["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(ds.Tables[0].Rows[0]["PublishDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsEnable"]!=null && ds.Tables[0].Rows[0]["IsEnable"].ToString()!="")
				{
					model.IsEnable=int.Parse(ds.Tables[0].Rows[0]["IsEnable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsHot"]!=null && ds.Tables[0].Rows[0]["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(ds.Tables[0].Rows[0]["IsHot"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ViewCount"]!=null && ds.Tables[0].Rows[0]["ViewCount"].ToString()!="")
				{
					model.ViewCount=int.Parse(ds.Tables[0].Rows[0]["ViewCount"].ToString());
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
					model.Other03=ds.Tables[0].Rows[0]["Other03"].ToString();
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
			strSql.Append("select NewsID,NewsGUID,DictionaryKey,NewsTitle,NewsTag,NewsSummary,NewsContent,NewsSource,NewsSourceLink,PublishUserGUID,PublishDate,IsEnable,IsHot,ViewCount,Other01,Other02,Other03 ");
			strSql.Append(" FROM NewsList ");
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
			strSql.Append(" NewsID,NewsGUID,DictionaryKey,NewsTitle,NewsTag,NewsSummary,NewsContent,NewsSource,NewsSourceLink,PublishUserGUID,PublishDate,IsEnable,IsHot,ViewCount,Other01,Other02,Other03 ");
			strSql.Append(" FROM NewsList ");
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
			parameters[0].Value = "NewsList";
			parameters[1].Value = "NewsID";
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
            parameters[0].Value = "NewsList";
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