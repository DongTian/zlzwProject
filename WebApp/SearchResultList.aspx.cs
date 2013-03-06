using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class SearchResultList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    strSearchKey = Server.UrlDecode(Request.QueryString["id"]);
                    Load_RegionList();//加载区域列表
                    AspNetPager1.RecordCount = Load_xirJobList_RecordCount(strSearchKey);//获取总页数
                    Load_xierDataList(strSearchKey);//加载职位列表
                }
                catch (Exception exp)
                {
                    Response.Redirect("default.aspx");
                }
            }

        }

        #region 页面变量

        private string strSearchKey = "";
        public string SearchKey
        {
            set
            {
                strSearchKey = value;
            }
            get
            {
                return strSearchKey;
            }
        }

        #endregion

        #region 绑定解然数据库数据_返回总页数

        private int Load_xirJobList_RecordCount(string strKey)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBManageConnectionString"].ConnectionString;
                string commandString = "select * from XQYCEnterpriseJob where EnterpriseJobStation like '%" + strKey + "%' order by CreateTime desc";

                DataSet ds = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(commandString, connectionString);
                ada.Fill(ds, "table1");
                DataTable dt = ds.Tables[0];
                return dt.Rows.Count;

            }
            catch (Exception exp)
            {
                return 0;
            }
        }

        #endregion

        #region 获取当前区域的总页数(不用)

        private int Get_JobRecordCount()
        {
            zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
            DataTable dt = defaultPostListBLL.GetList("IsEnable=1 and EnterpriseName LIKE '%" + strSearchKey + "%' or WorkAdd LIKE '%" + strSearchKey + "%' or PostInfo LIKE '%" + strSearchKey + "%'").Tables[0];

            return dt.Rows.Count;
        }

        #endregion

        #region 加载区域信息

        private void Load_RegionList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='RegionType' and IsEnable=1").Tables[0];

            drpSelectCity.DataTextField = "DictionaryValue";
            drpSelectCity.DataValueField = "DictionaryListID";

            drpSelectCity.DataSource = dt;
            drpSelectCity.DataBind();
        }

        #endregion

        #region 绑定解然数据库数据 获取分页数据

        private void Load_xierDataList(string strKey)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBManageConnectionString"].ConnectionString;
                AspNetPager1.PageSize = 10;
                SqlDataReader sqlDR = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "usp_XQYC_EnterpriseJob_SelectPaging",
                    new SqlParameter("@startIndex", AspNetPager1.StartRecordIndex),
                    new SqlParameter("@endIndex", AspNetPager1.EndRecordIndex),
                    new SqlParameter("@whereClause", "CanUsable=1 and EnterpriseJobStation like '%" + strKey + "%'"),
                    new SqlParameter("@orderClause", "CreateTime desc"));

                Repeater1.DataSource = ConvertDataReaderToDataTable(sqlDR);
                Repeater1.DataBind();
            }
            catch (Exception exp)
            {
                return;
            }
            labEmptyInfo.Visible = false;
        }

        #endregion

        #region 转换DataTable

        private DataTable ConvertDataReaderToDataTable(SqlDataReader dataReader)
        {
            DataTable datatable = new DataTable("DataTable");
            DataTable schemaTable = dataReader.GetSchemaTable();
            //动态添加列
            try
            {
                foreach (DataRow myRow in schemaTable.Rows)
                {
                    DataColumn myDataColumn = new DataColumn();
                    myDataColumn.DataType = myRow["DataTypeName"].GetType();
                    myDataColumn.ColumnName = myRow[0].ToString();
                    datatable.Columns.Add(myDataColumn);
                }
                //添加数据
                while (dataReader.Read())
                {
                    DataRow myDataRow = datatable.NewRow();
                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        myDataRow[i] = dataReader[i].ToString();
                    }
                    datatable.Rows.Add(myDataRow);
                    myDataRow = null;
                }
                schemaTable = null;
                dataReader.Close();
                return datatable;
            }
            catch (Exception ex)
            {
                throw new Exception("转换出错出错!", ex);
            }

        }


        #endregion

        #region 绑定职位信息(不用)

        private void Load_JobList()
        {
            int nPageIndex = AspNetPager1.CurrentPageIndex;
            int nPageSize = AspNetPager1.PageSize = 10;
            zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
            DataTable dt = defaultPostListBLL.GetList(nPageSize, nPageIndex, "*", "PublishDate", 0, "desc", "IsEnable=1 and EnterpriseName LIKE '%" + strSearchKey + "%' or WorkAdd LIKE '%" + strSearchKey + "%' or PostInfo LIKE '%" + strSearchKey + "%'").Tables[0];
            if (dt.Rows.Count == 0)
            {
                labEmptyInfo.Visible = true;
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                labEmptyInfo.Visible = false;
            }
        }

        #endregion

        #region 城市选择事件

        protected void drpSelectCity_SelectedIndexChanged1(object sender, EventArgs e)
        {
            labCurrentCity.Text = drpSelectCity.SelectedItem.Text;
            Get_JobRecordCount();
            Load_JobList();
        }

        #endregion

        #region 根据城市ID获取城市名称

        #endregion

        #region 职位列表行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labPublishDate = (Label)e.Item.FindControl("labPublishDate");
                Label labJobTitle = (Label)e.Item.FindControl("labJobTitle");

                labPublishDate.Text = DateTime.Parse(drv["CreateTime"].ToString()).ToString("yyyy年MM月dd日");
                string strEnterpriseID = drv["EnterpriseJobGuid"].ToString();
                string strEnterpriseName = Set_EnterpriseNameLength(drv["EnterpriseName"].ToString());
                labJobTitle.Text = "<a title='" + drv["EnterpriseName"].ToString() + "' href='OnlineApplicationInfo.aspx?id=" + strEnterpriseID + "' class='huia'>" + strEnterpriseName + "</a>　/　<a title='" + Set_PostInfoLength(drv["EnterpriseJobStation"].ToString()) + "' href='OnlineApplicationInfo.aspx?id=" + strEnterpriseID + "' class='huia'>" + drv["EnterpriseJobStation"].ToString() + "</a>　/　<a href='OnlineApplicationInfo.aspx?id=" + strEnterpriseID + "' class='huia'>" + drv["EnterpriseJobLaborCount"].ToString() + "人</a>";
            }
        }

        #endregion

        #region 设置企业名称长度

        private string Set_EnterpriseNameLength(string strTitle)
        {
            if (strTitle.Length >= 16)
            {
                return strTitle.Substring(0, 16) + "...";
            }
            else
            {
                return strTitle;
            }
        }

        #endregion

        #region 设置职位长度

        private string Set_PostInfoLength(string strTitle)
        {
            if (strTitle.Length >= 10)
            {
                return strTitle.Substring(0, 10) + "...";
            }
            else
            {
                return strTitle;
            }
        }

        #endregion

        #region 分页事件

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Load_xierDataList(Server.UrlDecode(Request.QueryString["id"]));
        }

        #endregion

    }
}
