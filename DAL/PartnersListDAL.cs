using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:PartnersListDAL
	/// </summary>
	public partial class PartnersListDAL
	{
		public PartnersListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PartnerID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@PartnerID", SqlDbType.Int,4)
			};
			parameters[0].Value = PartnerID;

			int result= DbHelperSQL.RunProcedure("PartnersList_Exists",parameters,out rowsAffected);
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
		public int Add(zlzw.Model.PartnersListModel model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@PartnerID", SqlDbType.Int,4),
					new SqlParameter("@PartnerGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@PartnerName", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerIntroduction", SqlDbType.NVarChar,-1),
					new SqlParameter("@PartnerLogo", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerBanner", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerKind", SqlDbType.Int,4),
					new SqlParameter("@PartnerCategory", SqlDbType.NVarChar,50),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@JobContactName", SqlDbType.NVarChar,50),
					new SqlParameter("@JobContactAdd", SqlDbType.NVarChar,50),
					new SqlParameter("@JobContactPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.PartnerName;
			parameters[3].Value = model.PartnerTitle;
			parameters[4].Value = model.PartnerIntroduction;
			parameters[5].Value = model.PartnerLogo;
			parameters[6].Value = model.PartnerBanner;
			parameters[7].Value = model.PartnerKind;
			parameters[8].Value = model.PartnerCategory;
			parameters[9].Value = model.IsHot;
			parameters[10].Value = model.IsEnable;
			parameters[11].Value = model.PublishDate;
			parameters[12].Value = model.JobContactName;
			parameters[13].Value = model.JobContactAdd;
			parameters[14].Value = model.JobContactPhone;
			parameters[15].Value = model.Other01;
			parameters[16].Value = model.Other02;
			parameters[17].Value = model.Other03;

			DbHelperSQL.RunProcedure("PartnersList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.PartnersListModel model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@PartnerID", SqlDbType.Int,4),
					new SqlParameter("@PartnerGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@PartnerName", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerIntroduction", SqlDbType.NVarChar,-1),
					new SqlParameter("@PartnerLogo", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerBanner", SqlDbType.NVarChar,200),
					new SqlParameter("@PartnerKind", SqlDbType.Int,4),
					new SqlParameter("@PartnerCategory", SqlDbType.NVarChar,50),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@JobContactName", SqlDbType.NVarChar,50),
					new SqlParameter("@JobContactAdd", SqlDbType.NVarChar,50),
					new SqlParameter("@JobContactPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.PartnerID;
			parameters[1].Value = model.PartnerGUID;
			parameters[2].Value = model.PartnerName;
			parameters[3].Value = model.PartnerTitle;
			parameters[4].Value = model.PartnerIntroduction;
			parameters[5].Value = model.PartnerLogo;
			parameters[6].Value = model.PartnerBanner;
			parameters[7].Value = model.PartnerKind;
			parameters[8].Value = model.PartnerCategory;
			parameters[9].Value = model.IsHot;
			parameters[10].Value = model.IsEnable;
			parameters[11].Value = model.PublishDate;
			parameters[12].Value = model.JobContactName;
			parameters[13].Value = model.JobContactAdd;
			parameters[14].Value = model.JobContactPhone;
			parameters[15].Value = model.Other01;
			parameters[16].Value = model.Other02;
			parameters[17].Value = model.Other03;

			DbHelperSQL.RunProcedure("PartnersList_Update",parameters,out rowsAffected);
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
		public bool Delete(int PartnerID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@PartnerID", SqlDbType.Int,4)
			};
			parameters[0].Value = PartnerID;

			DbHelperSQL.RunProcedure("PartnersList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string PartnerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PartnersList ");
			strSql.Append(" where PartnerID in ("+PartnerIDlist + ")  ");
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
		public zlzw.Model.PartnersListModel GetModel(int PartnerID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@PartnerID", SqlDbType.Int,4)
			};
			parameters[0].Value = PartnerID;

			zlzw.Model.PartnersListModel model=new zlzw.Model.PartnersListModel();
			DataSet ds= DbHelperSQL.RunProcedure("PartnersList_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
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
		public zlzw.Model.PartnersListModel DataRowToModel(DataRow row)
		{
			zlzw.Model.PartnersListModel model=new zlzw.Model.PartnersListModel();
			if (row != null)
			{
				if(row["PartnerID"]!=null && row["PartnerID"].ToString()!="")
				{
					model.PartnerID=int.Parse(row["PartnerID"].ToString());
				}
				if(row["PartnerGUID"]!=null && row["PartnerGUID"].ToString()!="")
				{
					model.PartnerGUID= new Guid(row["PartnerGUID"].ToString());
				}
				if(row["PartnerName"]!=null)
				{
					model.PartnerName=row["PartnerName"].ToString();
				}
				if(row["PartnerTitle"]!=null)
				{
					model.PartnerTitle=row["PartnerTitle"].ToString();
				}
				if(row["PartnerIntroduction"]!=null)
				{
					model.PartnerIntroduction=row["PartnerIntroduction"].ToString();
				}
				if(row["PartnerLogo"]!=null)
				{
					model.PartnerLogo=row["PartnerLogo"].ToString();
				}
				if(row["PartnerBanner"]!=null)
				{
					model.PartnerBanner=row["PartnerBanner"].ToString();
				}
				if(row["PartnerKind"]!=null && row["PartnerKind"].ToString()!="")
				{
					model.PartnerKind=int.Parse(row["PartnerKind"].ToString());
				}
				if(row["PartnerCategory"]!=null)
				{
					model.PartnerCategory=row["PartnerCategory"].ToString();
				}
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(row["IsHot"].ToString());
				}
				if(row["IsEnable"]!=null && row["IsEnable"].ToString()!="")
				{
					model.IsEnable=int.Parse(row["IsEnable"].ToString());
				}
				if(row["PublishDate"]!=null && row["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(row["PublishDate"].ToString());
				}
				if(row["JobContactName"]!=null)
				{
					model.JobContactName=row["JobContactName"].ToString();
				}
				if(row["JobContactAdd"]!=null)
				{
					model.JobContactAdd=row["JobContactAdd"].ToString();
				}
				if(row["JobContactPhone"]!=null)
				{
					model.JobContactPhone=row["JobContactPhone"].ToString();
				}
				if(row["Other01"]!=null)
				{
					model.Other01=row["Other01"].ToString();
				}
				if(row["Other02"]!=null)
				{
					model.Other02=row["Other02"].ToString();
				}
				if(row["Other03"]!=null)
				{
					model.Other03=row["Other03"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PartnerID,PartnerGUID,PartnerName,PartnerTitle,PartnerIntroduction,PartnerLogo,PartnerBanner,PartnerKind,PartnerCategory,IsHot,IsEnable,PublishDate,JobContactName,JobContactAdd,JobContactPhone,Other01,Other02,Other03 ");
			strSql.Append(" FROM PartnersList ");
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
			strSql.Append(" PartnerID,PartnerGUID,PartnerName,PartnerTitle,PartnerIntroduction,PartnerLogo,PartnerBanner,PartnerKind,PartnerCategory,IsHot,IsEnable,PublishDate,JobContactName,JobContactAdd,JobContactPhone,Other01,Other02,Other03 ");
			strSql.Append(" FROM PartnersList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM PartnersList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.PartnerID desc");
			}
			strSql.Append(")AS Row, T.*  from PartnersList T ");
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
			parameters[0].Value = "PartnersList";
			parameters[1].Value = "PartnerID";
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
            parameters[0].Value = "PartnersList";
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