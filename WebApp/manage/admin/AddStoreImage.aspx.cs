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
using ExtAspNet;

namespace WebApp.manage.admin
{
    public partial class AddStoreImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_RegionList();
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载区域列表

        private void Load_RegionList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='StoreType' and IsEnable=1 order by OrderNumber asc").Tables[0];
            drpRegionList.DataTextField = "DictionaryValue";
            drpRegionList.DataValueField = "DictionaryListID";

            drpRegionList.DataSource = dt;
            drpRegionList.DataBind();

            Load_StoreType(drpRegionList.SelectedValue);
        }

        #endregion

        #region 加载店面类型列表

        private void Load_StoreType(string strRegionID)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='StoreItem' and IsEnable=1 and IsInner=" + strRegionID).Tables[0];

            drpStoreType.DataTextField = "DictionaryValue";
            drpStoreType.DataValueField = "DictionaryKey";

            drpStoreType.DataSource = dt;
            drpStoreType.DataBind();
        }


        #endregion

        #region 加载店面展示图片列表

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
                DataTable dt = storeImageListBLL.GetList("StoreImageGUID='" + strID + "'").Tables[0];
                zlzw.Model.StoreImageListModal storeImageListModal = storeImageListBLL.GetModel(int.Parse(dt.Rows[0]["StoreImageID"].ToString()));
                drpRegionList.SelectedValue = storeImageListModal.Other01.ToString();
                drpStoreType.SelectedValue = storeImageListModal.DictionaryKey;//所属门店
                txbStoreImageTitle.Text = storeImageListModal.StoreImageTitle;//门店名称
                txbStoreImageDesc.Text = storeImageListModal.StoreImageDesc;//门店简介

                imgUploadLogo.ImageUrl = storeImageListModal.StoreImagePath;//显示上传后的图片
                imgUploadLogo.Visible = true;
                ViewState["StoreImagePath"] = storeImageListModal.StoreImagePath;//门店图片地址
                ViewState["PublishDate"] = storeImageListModal.PublishDate.ToString();
                ViewState["StoreImageGUID"] = storeImageListModal.StoreImageGUID.ToString();
                ToolbarText2.Text = "编辑一个门店展示图片";
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
                zlzw.Model.StoreImageListModal storeImageListModal = new zlzw.Model.StoreImageListModal();
                storeImageListModal.Other01 = drpRegionList.SelectedValue;
                storeImageListModal.DictionaryKey = drpStoreType.SelectedValue;//所属门店
                storeImageListModal.StoreImageTitle = txbStoreImageTitle.Text;//门店名称
                storeImageListModal.StoreImageDesc = txbStoreImageDesc.Text;//合作伙伴简介

                if (btnStoreImageUpload.PostedFile.ContentLength > 0)
                {
                    btnStoreImageUpload.SaveAs(Server.MapPath(ViewState["StoreImagePath"].ToString()));
                    storeImageListModal.StoreImagePath = ViewState["StoreImagePath"].ToString();//保存门店展示图片路径
                }
                else
                {
                    storeImageListModal.StoreImagePath = ViewState["StoreImagePath"].ToString();
                }

                storeImageListModal.IsEnable = 1;
                storeImageListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                storeImageListModal.StoreImageID = int.Parse(Get_StoreImageID(Request.QueryString["value"]));
                storeImageListModal.StoreImageGUID = new Guid(Request.QueryString["value"]);
                zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
                storeImageListBLL.Update(storeImageListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.StoreImageListModal storeImageListModal = new zlzw.Model.StoreImageListModal();
                storeImageListModal.Other01 = drpRegionList.SelectedValue;
                storeImageListModal.DictionaryKey = drpStoreType.SelectedValue;//所属门店
                storeImageListModal.StoreImageTitle = txbStoreImageTitle.Text;//门店名称
                storeImageListModal.StoreImageDesc = txbStoreImageDesc.Text;//合作伙伴简介

                storeImageListModal.IsEnable = 1;
                if (btnStoreImageUpload.HasFile)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnStoreImageUpload.FileName;
                    btnStoreImageUpload.SaveAs(Server.MapPath("~/storefrontEleganceImages/storeImages/" + fileName));
                    storeImageListModal.StoreImagePath = "~/storefrontEleganceImages/storeImages/" + fileName;//保存门店展示图片路径
                }
                else
                {
                    Alert.Show("请上传一张尺寸为166 * 55 的门店展示图片", "错误提醒", MessageBoxIcon.Error);
                    return;
                }
                storeImageListModal.StoreImageGUID = Guid.NewGuid();
                storeImageListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
                storeImageListBLL.Add(storeImageListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取ID

        private string Get_StoreImageID(string strStoreImageGUID)
        {
            zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
            DataTable dt = storeImageListBLL.GetList("StoreImageGUID='" + strStoreImageGUID + "'").Tables[0];

            return dt.Rows[0]["StoreImageID"].ToString();
        }

        #endregion

        protected void drpRegionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_StoreType(drpRegionList.SelectedValue);
        }
    }
}
