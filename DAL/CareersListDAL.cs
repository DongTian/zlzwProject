using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:CareersListDAL
	/// </summary>
	public partial class CareersListDAL
	{
		public CareersListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CareersID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@CareersID", SqlDbType.Int,4)
			};
			parameters[0].Value = CareersID;

			int result= DbHelperSQL.RunProcedure("CareersList_Exists",parameters,out rowsAffected);
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
		public int Add(zlzw.Model.CareersListModal model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@CareersID", SqlDbType.Int,4),
					new SqlParameter("@CareersGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DictionaryKey", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@CareersTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@CareersCount", SqlDbType.Int,4),
					new SqlParameter("@WorkAdd", SqlDbType.NVarChar,100),
					new SqlParameter("@Educational", SqlDbType.NVarChar,50),
					new SqlParameter("@Salary", SqlDbType.NVarChar,50),
					new SqlParameter("@WorkExperience", SqlDbType.NVarChar),
					new SqlParameter("@Responsibilities", SqlDbType.NVarChar),
					new SqlParameter("@Qualifications", SqlDbType.NVarChar),
					new SqlParameter("@EMail", SqlDbType.NVarChar,50),
					new SqlParameter("@Telephone", SqlDbType.NVarChar,50),
					new SqlParameter("@ContactMan", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.DictionaryKey;
			parameters[3].Value = model.DepartmentName;
			parameters[4].Value = model.CareersTitle;
			parameters[5].Value = model.CareersCount;
			parameters[6].Value = model.WorkAdd;
			parameters[7].Value = model.Educational;
			parameters[8].Value = model.Salary;
			parameters[9].Value = model.WorkExperience;
			parameters[10].Value = model.Responsibilities;
			parameters[11].Value = model.Qualifications;
			parameters[12].Value = model.EMail;
			parameters[13].Value = model.Telephone;
			parameters[14].Value = model.ContactMan;
			parameters[15].Value = model.IsEnable;
			parameters[16].Value = model.IsHot;
			parameters[17].Value = model.PublishDate;
			parameters[18].Value = model.Other01;
			parameters[19].Value = model.Other02;
			parameters[20].Value = model.Other03;

			DbHelperSQL.RunProcedure("CareersList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.CareersListModal model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@CareersID", SqlDbType.Int,4),
					new SqlParameter("@CareersGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DictionaryKey", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@CareersTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@CareersCount", SqlDbType.Int,4),
					new SqlParameter("@WorkAdd", SqlDbType.NVarChar,100),
					new SqlParameter("@Educational", SqlDbType.NVarChar,50),
					new SqlParameter("@Salary", SqlDbType.NVarChar,50),
					new SqlParameter("@WorkExperience", SqlDbType.NVarChar),
					new SqlParameter("@Responsibilities", SqlDbType.NVarChar),
					new SqlParameter("@Qualifications", SqlDbType.NVarChar),
					new SqlParameter("@EMail", SqlDbType.NVarChar,50),
					new SqlParameter("@Telephone", SqlDbType.NVarChar,50),
					new SqlParameter("@ContactMan", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.CareersID;
			parameters[1].Value = model.CareersGUID;
			parameters[2].Value = model.DictionaryKey;
			parameters[3].Value = model.DepartmentName;
			parameters[4].Value = model.CareersTitle;
			parameters[5].Value = model.CareersCount;
			parameters[6].Value = model.WorkAdd;
			parameters[7].Value = model.Educational;
			parameters[8].Value = model.Salary;
			parameters[9].Value = model.WorkExperience;
			parameters[10].Value = model.Responsibilities;
			parameters[11].Value = model.Qualifications;
			parameters[12].Value = model.EMail;
			parameters[13].Value = model.Telephone;
			parameters[14].Value = model.ContactMan;
			parameters[15].Value = model.IsEnable;
			parameters[16].Value = model.IsHot;
			parameters[17].Value = model.PublishDate;
			parameters[18].Value = model.Other01;
			parameters[19].Value = model.Other02;
			parameters[20].Value = model.Other03;

			DbHelperSQL.RunProcedure("CareersList_Update",parameters,out rowsAffected);
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
		public bool Delete(int CareersID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@CareersID", SqlDbType.Int,4)
			};
			parameters[0].Value = CareersID;

			DbHelperSQL.RunProcedure("CareersList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string CareersIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CareersList ");
			strSql.Append(" where CareersID in ("+CareersIDlist + ")  ");
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
		public zlzw.Model.CareersListModal GetModel(int CareersID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@CareersID", SqlDbType.Int,4)
			};
			parameters[0].Value = CareersID;

			zlzw.Model.CareersListModal model=new zlzw.Model.CareersListModal();
			DataSet ds= DbHelperSQL.RunProcedure("CareersList_GetModel",parameters,"ds");
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
		public zlzw.Model.CareersListModal DataRowToModel(DataRow row)
		{
			zlzw.Model.CareersListModal model=new zlzw.Model.CareersListModal();
			if (row != null)
			{
				if(row["CareersID"]!=null && row["CareersID"].ToString()!="")
				{
					model.CareersID=int.Parse(row["CareersID"].ToString());
				}
				if(row["CareersGUID"]!=null && row["CareersGUID"].ToString()!="")
				{
					model.CareersGUID= new Guid(row["CareersGUID"].ToString());
				}
				if(row["DictionaryKey"]!=null)
				{
					model.DictionaryKey=row["DictionaryKey"].ToString();
				}
				if(row["DepartmentName"]!=null)
				{
					model.DepartmentName=row["DepartmentName"].ToString();
				}
				if(row["CareersTitle"]!=null)
				{
					model.CareersTitle=row["CareersTitle"].ToString();
				}
				if(row["CareersCount"]!=null && row["CareersCount"].ToString()!="")
				{
					model.CareersCount=int.Parse(row["CareersCount"].ToString());
				}
				if(row["WorkAdd"]!=null)
				{
					model.WorkAdd=row["WorkAdd"].ToString();
				}
				if(row["Educational"]!=null)
				{
					model.Educational=row["Educational"].ToString();
				}
				if(row["Salary"]!=null)
				{
					model.Salary=row["Salary"].ToString();
				}
				if(row["WorkExperience"]!=null)
				{
					model.WorkExperience=row["WorkExperience"].ToString();
				}
				if(row["Responsibilities"]!=null)
				{
					model.Responsibilities=row["Responsibilities"].ToString();
				}
				if(row["Qualifications"]!=null)
				{
					model.Qualifications=row["Qualifications"].ToString();
				}
				if(row["EMail"]!=null)
				{
					model.EMail=row["EMail"].ToString();
				}
				if(row["Telephone"]!=null)
				{
					model.Telephone=row["Telephone"].ToString();
				}
				if(row["ContactMan"]!=null)
				{
					model.ContactMan=row["ContactMan"].ToString();
				}
				if(row["IsEnable"]!=null && row["IsEnable"].ToString()!="")
				{
					model.IsEnable=int.Parse(row["IsEnable"].ToString());
				}
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(row["IsHot"].ToString());
				}
				if(row["PublishDate"]!=null && row["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(row["PublishDate"].ToString());
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
			strSql.Append("select CareersID,CareersGUID,DictionaryKey,DepartmentName,CareersTitle,CareersCount,WorkAdd,Educational,Salary,WorkExperience,Responsibilities,Qualifications,EMail,Telephone,ContactMan,IsEnable,IsHot,PublishDate,Other01,Other02,Other03 ");
			strSql.Append(" FROM CareersList ");
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
			strSql.Append(" CareersID,CareersGUID,DictionaryKey,DepartmentName,CareersTitle,CareersCount,WorkAdd,Educational,Salary,WorkExperience,Responsibilities,Qualifications,EMail,Telephone,ContactMan,IsEnable,IsHot,PublishDate,Other01,Other02,Other03 ");
			strSql.Append(" FROM CareersList ");
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
			strSql.Append("select count(1) FROM CareersList ");
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
				strSql.Append("order by T.CareersID desc");
			}
			strSql.Append(")AS Row, T.*  from CareersList T ");
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
			parameters[0].Value = "CareersList";
			parameters[1].Value = "CareersID";
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
            parameters[0].Value = "CareersList";
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