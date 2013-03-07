using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using FineUI;

namespace WebApp.manage.admin
{
    public partial class AddCareers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_CareersTypeList();//加载门店信息
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载职位性质

        private void Load_CareersTypeList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("IsEnable=1 and DictionaryCategory='StoreType'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                drpStoreType.DataTextField = "DictionaryValue";
                drpStoreType.DataValueField = "DictionaryKey";

                drpStoreType.DataSource = dt;
                drpStoreType.DataBind();
            }
            else
            {
                drpStoreType.Items.Add(new FineUI.ListItem("-- 门店信息尚未添加 --", "-1"));
            }
        }

        #endregion

        #region 加载用户信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
                zlzw.Model.CareersListModal careersListModal = careersListBLL.GetModel(int.Parse(Get_CareersID(strID)));
                drpStoreType.SelectedValue = careersListModal.DictionaryKey;//所属门店
                txbDepartmentName.Text = careersListModal.DepartmentName;//招聘部门
                txbCareersTitle.Text = careersListModal.CareersTitle;//职位名称
                txbCareersCount.Text = careersListModal.CareersCount.ToString();//招聘人数
                txbWorkAdd.Text = careersListModal.WorkAdd;//工作地点
                txbEducational.Text = careersListModal.Educational;//学历要求
                txbSalary.Text = careersListModal.Salary;//月薪
                txbWorkExperience.Text = careersListModal.WorkExperience;//工作经验
                txbEmail.Text = careersListModal.EMail;//联系邮件
                txbTel.Text = careersListModal.Telephone;//联系电话
                txbContactMan.Text = careersListModal.ContactMan;//联系人
                txbResponsibilities.Text = careersListModal.Responsibilities;//岗位职责
                txbQualifications.Text = careersListModal.Qualifications;//任职资格
                
                if (careersListModal.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }

                ViewState["PublishDate"] = careersListModal.PublishDate.ToString();
                ToolbarText2.Text = "编辑一个职位信息";
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
        }

        #endregion

        #region 保存按钮事件

        protected void btnSaveRefresh_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["Type"] == "1")
            {
                //编辑保存
                zlzw.Model.CareersListModal careersListModal = new zlzw.Model.CareersListModal();
                careersListModal.DictionaryKey = drpStoreType.SelectedValue;//所属门店
                careersListModal.DepartmentName = txbDepartmentName.Text;//招聘部门
                careersListModal.CareersTitle = txbCareersTitle.Text;//职位名称
                careersListModal.CareersCount = int.Parse(txbCareersCount.Text);//招聘人数
                careersListModal.WorkAdd = txbWorkAdd.Text;//工作地点
                careersListModal.Educational = txbEducational.Text;//学历要求
                careersListModal.Salary = txbSalary.Text;//月薪
                careersListModal.WorkExperience = txbWorkExperience.Text;//工作经验
                careersListModal.EMail = txbEmail.Text;//联系邮件
                careersListModal.Telephone = txbTel.Text;//联系电话
                careersListModal.ContactMan = txbContactMan.Text;//联系人
                careersListModal.Responsibilities =txbResponsibilities.Text ;//岗位职责
                careersListModal.Qualifications = txbQualifications.Text;//任职资格

                if (ckbIsHot.Checked)
                {
                    careersListModal.IsHot = 1;
                }
                else
                {
                    careersListModal.IsHot = 0;
                }
                careersListModal.IsEnable = 1;
                careersListModal.CareersGUID = new Guid(Request.QueryString["value"]);
                careersListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                careersListModal.CareersID = int.Parse(Get_CareersID(Request.QueryString["value"]));
                zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
                careersListBLL.Update(careersListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.CareersListModal careersListModal = new zlzw.Model.CareersListModal();
                careersListModal.DictionaryKey = drpStoreType.SelectedValue;//所属门店
                careersListModal.DepartmentName = txbDepartmentName.Text;//招聘部门
                careersListModal.CareersTitle = txbCareersTitle.Text;//职位名称
                careersListModal.CareersCount = int.Parse(txbCareersCount.Text);//招聘人数
                careersListModal.WorkAdd = txbWorkAdd.Text;//工作地点
                careersListModal.Educational = txbEducational.Text;//学历要求
                careersListModal.Salary = txbSalary.Text;//月薪
                careersListModal.WorkExperience = txbWorkExperience.Text;//工作经验
                careersListModal.EMail = txbEmail.Text;//联系邮件
                careersListModal.Telephone = txbTel.Text;//联系电话
                careersListModal.ContactMan = txbContactMan.Text;//联系人
                careersListModal.Responsibilities = txbResponsibilities.Text;//岗位职责
                careersListModal.Qualifications = txbQualifications.Text;//任职资格
                careersListModal.CareersGUID = Guid.NewGuid();//创建GUID
                careersListModal.IsEnable = 1;

                if (ckbIsHot.Checked)
                {
                    careersListModal.IsHot = 1;
                }
                else
                {
                    careersListModal.IsHot = 0;
                }

                careersListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
                careersListBLL.Add(careersListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取ID

        private string Get_CareersID(string strCareersGUID)
        {
            zlzw.BLL.CareersListBLL careersListBLL = new zlzw.BLL.CareersListBLL();
            DataTable dt = careersListBLL.GetList("CareersGUID='" + strCareersGUID + "'").Tables[0];

            return dt.Rows[0]["CareersID"].ToString();
        }

        #endregion

    }
}
