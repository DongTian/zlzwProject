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
    public partial class AddVentureStar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_RegionList();//加载区域列表
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

        #region 加载所属店面

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

        protected void drpRegionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_StoreType(drpRegionList.SelectedValue);
        }

        #region 加载创业明星信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
                DataTable dt = ventureStarListBLL.GetList("VentureStarGUID='" + strID + "'").Tables[0];
                zlzw.Model.VentureStarListModal ventureStarListModal = ventureStarListBLL.GetModel(int.Parse(dt.Rows[0]["VentureStarID"].ToString()));
                drpRegionList.SelectedValue = ventureStarListModal.Other01.ToString();
                drpStoreType.SelectedValue = ventureStarListModal.DictionaryKey;//所属门店
                txbVentureStarName.Text = ventureStarListModal.VentureStarName;//创业明星姓名
                FCKeditor1.Value = ventureStarListModal.VentureStarContent;//创业明星介绍
                labPreviweImg.ImageUrl = ventureStarListModal.VentureStarImage.Split('~')[1];
                ViewState["VentureStarImage"] = ventureStarListModal.VentureStarImage;//创业明星图片地址
                ViewState["PublishDate"] = ventureStarListModal.PublishDate.ToString();
                ViewState["VentureStarGUID"] = ventureStarListModal.VentureStarGUID.ToString();
                ToolbarText2.Text = "编辑一个创业明星";
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
                zlzw.Model.VentureStarListModal ventureStarListModal = new zlzw.Model.VentureStarListModal();
                ventureStarListModal.Other01 = drpRegionList.SelectedValue;
                ventureStarListModal.DictionaryKey = drpStoreType.SelectedValue;//所属门店
                ventureStarListModal.VentureStarName = txbVentureStarName.Text;//创业明星姓名
                ventureStarListModal.VentureStarContent = FCKeditor1.Value;//创业明星介绍

                if (btnImageUpload.PostedFile.ContentLength > 0)
                {
                    btnImageUpload.SaveAs(Server.MapPath(ViewState["VentureStarImage"].ToString()));
                    ventureStarListModal.VentureStarImage = ViewState["VentureStarImage"].ToString();//保存企业Logo路径
                }
                else
                {
                    ventureStarListModal.VentureStarImage = ViewState["VentureStarImage"].ToString();
                }

                ventureStarListModal.IsEnable = 1;
                ventureStarListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                ventureStarListModal.VentureStarID = int.Parse(Get_VentureStarID(Request.QueryString["value"]));
                ventureStarListModal.VentureStarGUID = new Guid(Request.QueryString["value"]);
                zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
                ventureStarListBLL.Update(ventureStarListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.VentureStarListModal ventureStarListModal = new zlzw.Model.VentureStarListModal();
                ventureStarListModal.Other01 = drpRegionList.SelectedValue;
                ventureStarListModal.DictionaryKey = drpStoreType.SelectedValue;//所属门店
                ventureStarListModal.VentureStarName = txbVentureStarName.Text;//创业明星姓名
                ventureStarListModal.VentureStarContent = FCKeditor1.Value;//创业明星介绍
                ventureStarListModal.IsEnable = 1;
                if (btnImageUpload.HasFile)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnImageUpload.FileName;
                    btnImageUpload.SaveAs(Server.MapPath("~/VentureStarImage/" + fileName));
                    ventureStarListModal.VentureStarImage = "~/VentureStarImage/" + fileName;//保存企业Logo路径
                }
                else
                {
                    Alert.Show("请上传一张尺寸为166 * 55 的创业明星图片", "错误提醒", MessageBoxIcon.Error);
                    return;
                }
                ventureStarListModal.VentureStarGUID = Guid.NewGuid();
                ventureStarListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
                ventureStarListBLL.Add(ventureStarListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取ID

        private string Get_VentureStarID(string strVentureStarGUID)
        {
            zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
            DataTable dt = ventureStarListBLL.GetList("VentureStarGUID='" + strVentureStarGUID + "'").Tables[0];

            return dt.Rows[0]["VentureStarID"].ToString();
        }

        #endregion
    }
}
