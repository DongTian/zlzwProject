using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace WebApp.Resources.Services
{
    /// <summary>
    /// GetBannerList 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class GetBannerList : System.Web.Services.WebService
    {
        [WebMethod]
        public string Get_BannerList()
        {
            zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            DataTable dt = bannerListBLL.GetList("BannerType=0 and IsHot=1 and IsEnable=1").Tables[0];
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            for (int nCount = 0; nCount < dt.Rows.Count; nCount++)
            {
                strBuilder.Append("<div><a target='_blank' href='" + dt.Rows[nCount]["BannerLinks"].ToString() + "'><img style='border:0px;' src='" + dt.Rows[nCount]["BannerImage"].ToString().Split('~')[1] + "' alt='' /></a></div>");
            }

            return strBuilder.ToString();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
