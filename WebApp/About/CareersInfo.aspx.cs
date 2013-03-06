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
    public partial class CareersInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string strID = Request.QueryString["id"];
                    Load_JobInfo(strID);
                }
                catch (Exception exp)
                {
                    Response.Redirect("CareersList.aspx");
                }
            }
        }

        #region 加载职位信息

        private void Load_JobInfo(string strID)
        {
            try
            {
                zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
                DataTable dt = careersListBLL.GetList("CareersGUID='" + strID + "'").Tables[0];
                this.Title = "校企英才官网-" + dt.Rows[0]["CareersTitle"].ToString(); ;
                labJobTitle.Text = dt.Rows[0]["CareersTitle"].ToString();
                //labNavTitle.Text = dt.Rows[0]["CareersTitle"].ToString();
                labPublishDate.Text = DateTime.Parse(dt.Rows[0]["PublishDate"].ToString()).ToString("yyyy年MM月dd日");
                labDeptName.Text = dt.Rows[0]["DepartmentName"].ToString();
                labCareersCount.Text = dt.Rows[0]["CareersCount"].ToString() + "人";
                labEducational.Text = dt.Rows[0]["Educational"].ToString();
                labWorkExperience.Text = dt.Rows[0]["WorkExperience"].ToString();
                labResponsibilities.Text = dt.Rows[0]["Responsibilities"].ToString();
                labQualifications.Text = dt.Rows[0]["Qualifications"].ToString();
                labWorkAdd.Text = dt.Rows[0]["WorkAdd"].ToString();
                labTel.Text = dt.Rows[0]["Telephone"].ToString();
                labMail.Text = dt.Rows[0]["EMail"].ToString();
                labContactMan.Text = dt.Rows[0]["ContactMan"].ToString();
            }
            catch (Exception exp)
            {
                Response.Redirect("CareersList.aspx");
            }
        }

        #endregion
    }
}
