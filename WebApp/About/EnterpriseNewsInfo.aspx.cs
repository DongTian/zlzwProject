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

namespace WebApp.About
{
    public partial class EnterpriseNewsInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string strNewsGUID = Request.QueryString["id"];
                    Load_NewsContent(strNewsGUID);
                }
                catch (Exception exp)
                {
                    Response.Redirect("../default.aspx");
                }
            }
        }

        #region 根据GUID加载新闻内容

        private void Load_NewsContent(string strNewsGUID)
        {
            try
            {
                zlzw.BLL.NewsListBLL newsListBLL = new zlzw.BLL.NewsListBLL();
                DataTable dt = newsListBLL.GetList("NewsGUID='" + strNewsGUID + "'").Tables[0];
                labNewsTitle.Text = dt.Rows[0]["NewsTitle"].ToString();
                //labNavNewsTitle.Text = this.Title =  labNewsTitle.Text;
                labPublisDate.Text = "发布日期:　"+DateTime.Parse(dt.Rows[0]["PublishDate"].ToString()).ToString("yyyy年MM月dd日");
                labNewsContent.Text = dt.Rows[0]["NewsContent"].ToString();
            }
            catch (Exception exp)
            {
                Response.Redirect("../default.aspx");
            }
        }

        #endregion
    }
}
