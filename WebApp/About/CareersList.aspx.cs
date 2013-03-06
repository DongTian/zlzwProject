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
    public partial class CareersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AspNetPager1.RecordCount = Get_CareersListRecordCount();//获取诚聘英才总数
                Load_CareersList();
            }
        }

        #region 获取诚聘英才总数

        private int Get_CareersListRecordCount()
        {
            zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
            DataTable dt = careersListBLL.GetList("IsEnable=1").Tables[0];

            return dt.Rows.Count;
        }

        #endregion

        #region 诚聘英才列表绑定

        private void Load_CareersList()
        {
            int nPageIndex = AspNetPager1.CurrentPageIndex;
            int nPageSize = AspNetPager1.PageSize = 4;
            zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
            DataTable dt = careersListBLL.GetList(nPageSize, nPageIndex, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        #endregion

        #region 诚聘英才行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labJobTitle = (Label)e.Item.FindControl("labJobTitle");
                Label labPublishDate = (Label)e.Item.FindControl("labPublishDate");
                Label labResponsibilities = (Label)e.Item.FindControl("labResponsibilities");
                Label labQualifications = (Label)e.Item.FindControl("labQualifications");
                Label labCheck = (Label)e.Item.FindControl("labCheck");

                labJobTitle.Text = drv["DepartmentName"].ToString() + "　" + drv["CareersTitle"].ToString() + "　" + "人数:　" + drv["CareersCount"].ToString() + "人";
                labPublishDate.Text = DateTime.Parse(drv["PublishDate"].ToString()).ToString("yyyy年MM月dd日");
                labResponsibilities.Text = drv["Responsibilities"].ToString();
                labQualifications.Text = drv["Qualifications"].ToString();
                labCheck.Text = "<a href='CareersInfo.aspx?id=" + drv["CareersGUID"].ToString() + "' style='color:#F26200; font-weight:bold;'>查看职位详情</a>";
            }
        }

        #endregion

        #region 分页事件

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Load_CareersList();
        }

        #endregion
    }
}
