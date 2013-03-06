﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:VentureStarListDAL
	/// </summary>
	public partial class VentureStarListDAL
	{
		public VentureStarListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int VentureStarID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@VentureStarID", SqlDbType.Int,4)
			};
			parameters[0].Value = VentureStarID;

			int result= DbHelperSQL.RunProcedure("VentureStarList_Exists",parameters,out rowsAffected);
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
		public int Add(zlzw.Model.VentureStarListModal model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@VentureStarID", SqlDbType.Int,4),
					new SqlParameter("@VentureStarGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@VentureStarSource", SqlDbType.NVarChar,100),
					new SqlParameter("@DictionaryKey", SqlDbType.NVarChar,50),
					new SqlParameter("@VentureStarName", SqlDbType.NVarChar,50),
					new SqlParameter("@VentureStarContent", SqlDbType.NVarChar),
					new SqlParameter("@VentureStarImage", SqlDbType.NVarChar,100),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.VentureStarSource;
			parameters[3].Value = model.DictionaryKey;
			parameters[4].Value = model.VentureStarName;
			parameters[5].Value = model.VentureStarContent;
			parameters[6].Value = model.VentureStarImage;
			parameters[7].Value = model.IsHot;
			parameters[8].Value = model.IsEnable;
			parameters[9].Value = model.PublishDate;
			parameters[10].Value = model.Other01;
			parameters[11].Value = model.Other02;

			DbHelperSQL.RunProcedure("VentureStarList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.VentureStarListModal model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@VentureStarID", SqlDbType.Int,4),
					new SqlParameter("@VentureStarGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@VentureStarSource", SqlDbType.NVarChar,100),
					new SqlParameter("@DictionaryKey", SqlDbType.NVarChar,50),
					new SqlParameter("@VentureStarName", SqlDbType.NVarChar,50),
					new SqlParameter("@VentureStarContent", SqlDbType.NVarChar),
					new SqlParameter("@VentureStarImage", SqlDbType.NVarChar,100),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.VentureStarID;
			parameters[1].Value = model.VentureStarGUID;
			parameters[2].Value = model.VentureStarSource;
			parameters[3].Value = model.DictionaryKey;
			parameters[4].Value = model.VentureStarName;
			parameters[5].Value = model.VentureStarContent;
			parameters[6].Value = model.VentureStarImage;
			parameters[7].Value = model.IsHot;
			parameters[8].Value = model.IsEnable;
			parameters[9].Value = model.PublishDate;
			parameters[10].Value = model.Other01;
			parameters[11].Value = model.Other02;

			DbHelperSQL.RunProcedure("VentureStarList_Update",parameters,out rowsAffected);
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
		public bool Delete(int VentureStarID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@VentureStarID", SqlDbType.Int,4)
			};
			parameters[0].Value = VentureStarID;

			DbHelperSQL.RunProcedure("VentureStarList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string VentureStarIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from VentureStarList ");
			strSql.Append(" where VentureStarID in ("+VentureStarIDlist + ")  ");
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
		public zlzw.Model.VentureStarListModal GetModel(int VentureStarID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@VentureStarID", SqlDbType.Int,4)
			};
			parameters[0].Value = VentureStarID;

			zlzw.Model.VentureStarListModal model=new zlzw.Model.VentureStarListModal();
			DataSet ds= DbHelperSQL.RunProcedure("VentureStarList_GetModel",parameters,"ds");
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
		public zlzw.Model.VentureStarListModal DataRowToModel(DataRow row)
		{
			zlzw.Model.VentureStarListModal model=new zlzw.Model.VentureStarListModal();
			if (row != null)
			{
				if(row["VentureStarID"]!=null && row["VentureStarID"].ToString()!="")
				{
					model.VentureStarID=int.Parse(row["VentureStarID"].ToString());
				}
				if(row["VentureStarGUID"]!=null && row["VentureStarGUID"].ToString()!="")
				{
					model.VentureStarGUID= new Guid(row["VentureStarGUID"].ToString());
				}
				if(row["VentureStarSource"]!=null)
				{
					model.VentureStarSource=row["VentureStarSource"].ToString();
				}
				if(row["DictionaryKey"]!=null)
				{
					model.DictionaryKey=row["DictionaryKey"].ToString();
				}
				if(row["VentureStarName"]!=null)
				{
					model.VentureStarName=row["VentureStarName"].ToString();
				}
				if(row["VentureStarContent"]!=null)
				{
					model.VentureStarContent=row["VentureStarContent"].ToString();
				}
				if(row["VentureStarImage"]!=null)
				{
					model.VentureStarImage=row["VentureStarImage"].ToString();
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
				if(row["Other01"]!=null)
				{
					model.Other01=row["Other01"].ToString();
				}
				if(row["Other02"]!=null)
				{
					model.Other02=row["Other02"].ToString();
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
			strSql.Append("select VentureStarID,VentureStarGUID,VentureStarSource,DictionaryKey,VentureStarName,VentureStarContent,VentureStarImage,IsHot,IsEnable,PublishDate,Other01,Other02 ");
			strSql.Append(" FROM VentureStarList ");
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
			strSql.Append(" VentureStarID,VentureStarGUID,VentureStarSource,DictionaryKey,VentureStarName,VentureStarContent,VentureStarImage,IsHot,IsEnable,PublishDate,Other01,Other02 ");
			strSql.Append(" FROM VentureStarList ");
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
			strSql.Append("select count(1) FROM VentureStarList ");
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
				strSql.Append("order by T.VentureStarID desc");
			}
			strSql.Append(")AS Row, T.*  from VentureStarList T ");
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
			parameters[0].Value = "VentureStarList";
			parameters[1].Value = "VentureStarID";
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
            parameters[0].Value = "VentureStarList";
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