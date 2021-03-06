﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zlzw.DAL
{
	/// <summary>
	/// 数据访问类:MessageListDAL
	/// </summary>
	public partial class MessageListDAL
	{
		public MessageListDAL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MessageID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4)
			};
			parameters[0].Value = MessageID;

			int result= DbHelperSQL.RunProcedure("MessageList_Exists",parameters,out rowsAffected);
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
		public int Add(zlzw.Model.MessageListModal model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4),
					new SqlParameter("@MessageGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@PublishUserName", SqlDbType.NVarChar,50),
					new SqlParameter("@PublishContent", SqlDbType.NVarChar),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@ReplyUserGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ReplyContent", SqlDbType.NVarChar),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@IsReply", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50),
					new SqlParameter("@Other04", SqlDbType.Int,4)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.PublishUserName;
			parameters[3].Value = model.PublishContent;
			parameters[4].Value = model.PublishDate;
            parameters[5].Value = model.ReplyUserGUID;
			parameters[6].Value = model.ReplyContent;
			parameters[7].Value = model.ReplyDate;
			parameters[8].Value = model.IsReply;
			parameters[9].Value = model.IsEnable;
			parameters[10].Value = model.Other01;
			parameters[11].Value = model.Other02;
			parameters[12].Value = model.Other03;
			parameters[13].Value = model.Other04;

			DbHelperSQL.RunProcedure("MessageList_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(zlzw.Model.MessageListModal model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4),
					new SqlParameter("@MessageGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@PublishUserName", SqlDbType.NVarChar,50),
					new SqlParameter("@PublishContent", SqlDbType.NVarChar),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@ReplyUserGUID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ReplyContent", SqlDbType.NVarChar),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@IsReply", SqlDbType.Int,4),
					new SqlParameter("@IsEnable", SqlDbType.Int,4),
					new SqlParameter("@Other01", SqlDbType.NVarChar,50),
					new SqlParameter("@Other02", SqlDbType.NVarChar,50),
					new SqlParameter("@Other03", SqlDbType.NVarChar,50),
					new SqlParameter("@Other04", SqlDbType.Int,4)};
			parameters[0].Value = model.MessageID;
			parameters[1].Value = model.MessageGUID;
			parameters[2].Value = model.PublishUserName;
			parameters[3].Value = model.PublishContent;
			parameters[4].Value = model.PublishDate;
			parameters[5].Value = model.ReplyUserGUID;
			parameters[6].Value = model.ReplyContent;
			parameters[7].Value = model.ReplyDate;
			parameters[8].Value = model.IsReply;
			parameters[9].Value = model.IsEnable;
			parameters[10].Value = model.Other01;
			parameters[11].Value = model.Other02;
			parameters[12].Value = model.Other03;
			parameters[13].Value = model.Other04;

			DbHelperSQL.RunProcedure("MessageList_Update",parameters,out rowsAffected);
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
		public bool Delete(int MessageID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4)
			};
			parameters[0].Value = MessageID;

			DbHelperSQL.RunProcedure("MessageList_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string MessageIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MessageList ");
			strSql.Append(" where MessageID in ("+MessageIDlist + ")  ");
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
		public zlzw.Model.MessageListModal GetModel(int MessageID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4)
			};
			parameters[0].Value = MessageID;

			zlzw.Model.MessageListModal model=new zlzw.Model.MessageListModal();
			DataSet ds= DbHelperSQL.RunProcedure("MessageList_GetModel",parameters,"ds");
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
		public zlzw.Model.MessageListModal DataRowToModel(DataRow row)
		{
			zlzw.Model.MessageListModal model=new zlzw.Model.MessageListModal();
			if (row != null)
			{
				if(row["MessageID"]!=null && row["MessageID"].ToString()!="")
				{
					model.MessageID=int.Parse(row["MessageID"].ToString());
				}
				if(row["MessageGUID"]!=null && row["MessageGUID"].ToString()!="")
				{
					model.MessageGUID= new Guid(row["MessageGUID"].ToString());
				}
				if(row["PublishUserName"]!=null)
				{
					model.PublishUserName=row["PublishUserName"].ToString();
				}
				if(row["PublishContent"]!=null)
				{
					model.PublishContent=row["PublishContent"].ToString();
				}
				if(row["PublishDate"]!=null && row["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(row["PublishDate"].ToString());
				}
				if(row["ReplyUserGUID"]!=null && row["ReplyUserGUID"].ToString()!="")
				{
					model.ReplyUserGUID= new Guid(row["ReplyUserGUID"].ToString());
				}
				if(row["ReplyContent"]!=null)
				{
					model.ReplyContent=row["ReplyContent"].ToString();
				}
				if(row["ReplyDate"]!=null && row["ReplyDate"].ToString()!="")
				{
					model.ReplyDate=DateTime.Parse(row["ReplyDate"].ToString());
				}
				if(row["IsReply"]!=null && row["IsReply"].ToString()!="")
				{
					model.IsReply=int.Parse(row["IsReply"].ToString());
				}
				if(row["IsEnable"]!=null && row["IsEnable"].ToString()!="")
				{
					model.IsEnable=int.Parse(row["IsEnable"].ToString());
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
				if(row["Other04"]!=null && row["Other04"].ToString()!="")
				{
					model.Other04=int.Parse(row["Other04"].ToString());
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
			strSql.Append("select MessageID,MessageGUID,PublishUserName,PublishContent,PublishDate,ReplyUserGUID,ReplyContent,ReplyDate,IsReply,IsEnable,Other01,Other02,Other03,Other04 ");
			strSql.Append(" FROM MessageList ");
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
			strSql.Append(" MessageID,MessageGUID,PublishUserName,PublishContent,PublishDate,ReplyUserGUID,ReplyContent,ReplyDate,IsReply,IsEnable,Other01,Other02,Other03,Other04 ");
			strSql.Append(" FROM MessageList ");
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
			strSql.Append("select count(1) FROM MessageList ");
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
				strSql.Append("order by T.MessageID desc");
			}
			strSql.Append(")AS Row, T.*  from MessageList T ");
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
			parameters[0].Value = "MessageList";
			parameters[1].Value = "MessageID";
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
            parameters[0].Value = "MessageList";
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