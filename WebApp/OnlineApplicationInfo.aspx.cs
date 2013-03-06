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

namespace WebApp
{
    public partial class OnlineApplicationInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Load_xieRDataInfo(Request.QueryString["id"]);
                }
                catch (Exception exp)
                {
                    Response.Redirect("default.aspx");
                }
            }
        }

        #region 加载职位信息

        private void Load_xieRDataInfo(string strGUID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBManageConnectionString"].ConnectionString;
            string commandString = "select * from XQYCEnterpriseJob where EnterpriseJobGuid='" + strGUID +"' order by CreateTime desc";

            DataSet ds = new DataSet();
            System.Data.SqlClient.SqlDataAdapter ada = new System.Data.SqlClient.SqlDataAdapter(commandString, connectionString);
            ada.Fill(ds, "table1");
            DataTable dt = ds.Tables[0];
            labEnterpriseTitle.Text = dt.Rows[0]["EnterpriseName"].ToString();//企业名称
            labPublisDate.Text = DateTime.Parse(dt.Rows[0]["CreateTime"].ToString()).ToString("yyyy年MM月dd日");
            labWorkAdd.Text = dt.Rows[0]["EnterpriseAddress"].ToString();//工作地点
            labRecruitmentNumber.Text = dt.Rows[0]["EnterpriseJobLaborCount"].ToString() + "　人";
            labPostInfo.Text = dt.Rows[0]["EnterpriseJobStation"].ToString();//招聘信息
            labPostDemand.Text = dt.Rows[0]["EnterpriseJobDemand"].ToString();//岗位要求
            labTreatmentInfo.Text = dt.Rows[0]["EnterpriseJobTreadment"].ToString();//待遇相关
            if (dt.Rows[0]["EnterpriseJobOther"].ToString() != "")
            {
                labOtherInfo.Visible = true;
                labOtherInfo.Text = dt.Rows[0]["EnterpriseJobOther"].ToString();
            }
            else
            {
                labOtherInfo.Visible = false;
            }

        }

        #endregion

        #region 加载职位信息 (不用)

        private void Load_JobInfo(string strID)
        {
            try
            {
                zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
                zlzw.Model.DefaultPostListModal defaultPostListModal = defaultPostListBLL.GetModel(int.Parse(strID));
                labEnterpriseTitle.Text = defaultPostListModal.EnterpriseName;//企业名称
                labPublisDate.Text = DateTime.Parse(defaultPostListModal.PublishDate.ToString()).ToString("yyyy年MM月dd日");
                labWorkAdd.Text = defaultPostListModal.WorkAdd;//工作地点
                labRecruitmentNumber.Text = defaultPostListModal.RecruitmentNumber + "　人";
                labPostInfo.Text = defaultPostListModal.PostInfo;//招聘信息
                labPostDemand.Text = defaultPostListModal.PostDemand;//岗位要求
                labTreatmentInfo.Text = defaultPostListModal.TreatmentInfo;//待遇相关
                if (defaultPostListModal.OtherInfo != "")
                {
                    labOtherInfo.Visible = true;
                    labOtherInfo.Text = defaultPostListModal.OtherInfo;
                }
                else
                {
                    labOtherInfo.Visible = false;
                }
            }
            catch (Exception exp)
            {
                Response.Redirect("default.aspx");
            }
        }

        #endregion

    }
}
