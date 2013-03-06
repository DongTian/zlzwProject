using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace WebApp.Resources.Services
{
    /// <summary>
    /// GetRegionList 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class GetRegionList : System.Web.Services.WebService
    {

        [WebMethod]
        public string Get_RegionList()
        {
            try
            {
                zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
                DataTable dt = dictionaryListBLL.GetList(8, "IsEnable=1 and DictionaryCategory='RegionType'", "PublishDate asc").Tables[0];
                System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
                for (int nCount = 0; nCount < dt.Rows.Count; nCount++)
                {
                    if (nCount == 0)
                    {
                        strBuilder.Append("<a class='huia' style='cursor:pointer;color: #F87A00;font-weight:bolder;font-size:16px;' name='RegionType' id='" + dt.Rows[nCount]["DictionaryListID"].ToString() + "'>" + dt.Rows[nCount]["DictionaryValue"].ToString() + "</a>　");
                    }
                    else
                    {
                        strBuilder.Append("<a class='huia' style='cursor:pointer;color: #6e6e6e;font-size:14px;' name='RegionType' id='" + dt.Rows[nCount]["DictionaryListID"].ToString() + "'>" + dt.Rows[nCount]["DictionaryValue"].ToString() + "</a>　");
                    }
                }
                return strBuilder.ToString();
            }
            catch (Exception exp)
            {
                return "-1";
            }
        }

        [WebMethod]
        public string Get_PostList(string strID)
        {
            //zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
            //DataTable dt = defaultPostListBLL.GetList(6,"IsEnable=1 and IsHot=1 and DictionaryListID=" + strID,"PublishDate desc").Tables[0];
            if (strID != "14")
            {
                return "";
            }
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBManageConnectionString"].ConnectionString;
                string commandString = "select top 8 * from XQYCEnterpriseJob order by CreateTime desc";

                DataSet ds = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(commandString, connectionString);
                ada.Fill(ds, "table1");
                DataTable dt = ds.Tables[0];
                System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
                if (dt.Rows.Count > 0)
                {
                    for (int nCount = 0; nCount < dt.Rows.Count; nCount++)
                    {
                        strBuilder.AppendLine("<li><img src='Resources/images/5-120601154100-50.gif'>　<span class='r hui'>" + Set_DateFormat(dt.Rows[nCount]["EnterpriseName"].ToString()) + "</span><a href='OnlineApplicationInfo.aspx?id=" + dt.Rows[nCount]["EnterpriseJobGuid"].ToString() + "' class='huia'>" + dt.Rows[nCount]["EnterpriseName"].ToString() + "　/　<spanstyle='color: #58738D'>" + dt.Rows[nCount]["EnterpriseJobStation"].ToString() + "</span>　/　<span style='color: #58738D'>" + dt.Rows[nCount]["EnterpriseJobLaborCount"].ToString() + " 人 </span></a></li>");
                        //strBuilder.Append("<li><span class='r hui'>2010-01-01</span><a href='#' class='huia'>青岛诺尔信电子科技　/　<span style='color:#58738D'>销售员、业务员</span>　/　<span style='color:#58738D'>　6人　</span></a></li>");
                    }
                }
                else
                {
                    strBuilder.AppendLine("<li style='text-align:center;color:#304877;font-size:16px;'><strong>暂无相关职位信息</strong></li>");
                }
                return strBuilder.ToString();
            }
            catch (Exception exp)
            {
                return "-1";
            }
        }

        #region 辅助函数

        private string Set_DateFormat(string strDate)
        {
            try
            {
                return DateTime.Parse(strDate).ToString("yyyy年MM月dd日");
            }
            catch (Exception exp)
            {
                return DateTime.Now.ToString("yyyy年MM月dd日");
            }
        }

        #endregion
    }
}
