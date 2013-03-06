using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApp.Resources.Services
{
    /// <summary>
    /// GetPartnersJob 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class GetPartnersJob : System.Web.Services.WebService
    {
        [WebMethod]
        public string Get_GetPartnersJob(string strID)
        {
            zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
            zlzw.Model.PartnersJobListModel partnersJobListModel = partnersJobListBLL.GetModel(int.Parse(strID));
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            strBuilder.Append("<table style='font-size:14px;'>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>企业名称：" + Get_EnterpriseName(partnersJobListModel.PartnerGUID.ToString()));
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>发布日期：" + DateTime.Parse(partnersJobListModel.PublishDate.ToString()).ToString("yyyy年MM月dd"));
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>职位信息：" + partnersJobListModel.PostInfo);
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>工作地点：" + partnersJobListModel.WorkAdd);
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>岗位要求：<br/><br/>" + partnersJobListModel.PostDemand);
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>待遇相关：<br/><br/>" + partnersJobListModel.TreatmentInfo);
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("<tr>");
            strBuilder.Append("<td>");
            strBuilder.Append("<p>其他信息：<br/><br/>" + partnersJobListModel.OtherInfo);
            strBuilder.Append("</p></td>");
            strBuilder.Append("</tr>");
            strBuilder.Append("</table>");

            return strBuilder.ToString();
        }

        #region 获取企业名称 
        
        private string Get_EnterpriseName(string strEnterpriseID)
        {
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            System.Data.DataTable dt = partnersListBLL.GetList("PartnerGUID='" + strEnterpriseID + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["PartnerName"].ToString();
            }
            else
            {
                return "未知";
            }
        }

        #endregion

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
