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
    public partial class AddStoreStatistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_StoreList();//加载店面列表
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载店面列表

        private void Load_StoreList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='StoreType'").Tables[0];

            drpStorefrontEleganceType.DataTextField = "DictionaryValue";
            drpStorefrontEleganceType.DataValueField = "DictionaryKey";

            drpStorefrontEleganceType.DataSource = dt;
            drpStorefrontEleganceType.DataBind();
        }

        #endregion

        #region 加载店面风采信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.StorefrontEleganceListBLL storefrontEleganceListBLL = new zlzw.BLL.StorefrontEleganceListBLL();
                DataTable dt = storefrontEleganceListBLL.GetList("StorefrontEleganceGUID='" + strID + "'").Tables[0];
                zlzw.Model.StorefrontEleganceListModal storefrontEleganceListModal = storefrontEleganceListBLL.GetModel(int.Parse(dt.Rows[0]["StorefrontEleganceID"].ToString()));

                drpStorefrontEleganceType.SelectedValue = storefrontEleganceListModal.DictionaryKey;//所属店铺
                txbStorefrontEleganceTitle.Text = storefrontEleganceListModal.StorefrontEleganceTitle;//店铺名称
                txbStorefrontEleganceDescription.Text = storefrontEleganceListModal.StorefrontEleganceDescription;//店铺简介
                txbPushJobs.Text = storefrontEleganceListModal.PushJobs;//主推岗位

                ViewState["StorefrontEleganceHeadImage"] = storefrontEleganceListModal.StorefrontEleganceHeadImage;//门店简介
                ViewState["PublishDate"] = storefrontEleganceListModal.PublishDate.ToString();
                ViewState["StorefrontEleganceGUID"] = storefrontEleganceListModal.StorefrontEleganceGUID;//店面风采GUID
                ToolbarText2.Text = "编辑一个店面风采";
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
                zlzw.Model.StorefrontEleganceListModal storefrontEleganceListModal = new zlzw.Model.StorefrontEleganceListModal();
                storefrontEleganceListModal.StorefrontEleganceGUID = new Guid(ViewState["StorefrontEleganceGUID"].ToString());//店面风采GUID
                storefrontEleganceListModal.DictionaryKey = drpStorefrontEleganceType.SelectedValue;//所属门店
                storefrontEleganceListModal.StorefrontEleganceTitle = txbStorefrontEleganceTitle.Text;//门店名称
                storefrontEleganceListModal.StorefrontEleganceDescription = txbStorefrontEleganceDescription.Text;//门店简介
                storefrontEleganceListModal.PushJobs = txbPushJobs.Text;//主推岗位
                if (btnStorefrontEleganceHeadImage.PostedFile.ContentLength > 0)
                {
                    btnStorefrontEleganceHeadImage.SaveAs(Server.MapPath(ViewState["StorefrontEleganceHeadImage"].ToString()));
                    storefrontEleganceListModal.StorefrontEleganceHeadImage = ViewState["StorefrontEleganceHeadImage"].ToString();//保存页面头部门店介绍路径
                }
                else
                {
                    storefrontEleganceListModal.StorefrontEleganceHeadImage = ViewState["StorefrontEleganceHeadImage"].ToString();
                } 

                storefrontEleganceListModal.IsEnable = 1;
                storefrontEleganceListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                storefrontEleganceListModal.StorefrontEleganceID = int.Parse(Get_StorefrontEleganceID(Request.QueryString["value"]));
                storefrontEleganceListModal.StorefrontEleganceGUID = new Guid(Request.QueryString["value"]);
                zlzw.BLL.StorefrontEleganceListBLL storefrontEleganceListBLL = new zlzw.BLL.StorefrontEleganceListBLL();
                storefrontEleganceListBLL.Update(storefrontEleganceListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.StorefrontEleganceListModal storefrontEleganceListModal = new zlzw.Model.StorefrontEleganceListModal();
                storefrontEleganceListModal.DictionaryKey = drpStorefrontEleganceType.SelectedValue;//所属门店
                storefrontEleganceListModal.StorefrontEleganceTitle = txbStorefrontEleganceTitle.Text;//门店名称
                storefrontEleganceListModal.StorefrontEleganceDescription = txbStorefrontEleganceDescription.Text;//门店简介
                storefrontEleganceListModal.PushJobs = txbPushJobs.Text;//主推岗位
                if (btnStorefrontEleganceHeadImage.PostedFile.ContentLength > 0)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnStorefrontEleganceHeadImage.FileName;
                    btnStorefrontEleganceHeadImage.SaveAs(Server.MapPath("~/storefrontEleganceImages/" + fileName));
                    storefrontEleganceListModal.StorefrontEleganceHeadImage = "~/storefrontEleganceImages/" + fileName;//保存页面头部门店介绍路径
                }
                else
                {
                    storefrontEleganceListModal.StorefrontEleganceHeadImage = ViewState["StorefrontEleganceHeadImage"].ToString();
                }

                storefrontEleganceListModal.IsEnable = 1;
                storefrontEleganceListModal.StorefrontEleganceGUID = Guid.NewGuid();//店面风采GUID
                storefrontEleganceListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.StorefrontEleganceListBLL storefrontEleganceListBLL = new zlzw.BLL.StorefrontEleganceListBLL();
                storefrontEleganceListBLL.Add(storefrontEleganceListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取ID

        private string Get_StorefrontEleganceID(string strStorefrontEleganceGUID)
        {
            zlzw.BLL.StorefrontEleganceListBLL storefrontEleganceListBLL = new zlzw.BLL.StorefrontEleganceListBLL();
            DataTable dt = storefrontEleganceListBLL.GetList("StorefrontEleganceGUID='" + strStorefrontEleganceGUID + "'").Tables[0];

            return dt.Rows[0]["StorefrontEleganceID"].ToString();
        }

        #endregion
    }
}
