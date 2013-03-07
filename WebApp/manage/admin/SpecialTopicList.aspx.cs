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
    public partial class SpecialTopicList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_SpecialTopicTotalCount();//获取总页数
                #region 横幅广告列表绑定

                SpecialList_BindGrid();

                #endregion
                Window1.Title = "添加横幅广告";
                btnAdd.OnClientClick = Window1.GetShowReference("AddSpecialTopic.aspx?Type=0", "添加横幅广告") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的横幅广告!");
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddSpecialTopic.aspx?Type=1&value=" + value, "编辑横幅广告");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_SpecialTopicTotalCount()
        {
            zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            DataTable dt = bannerListBLL.GetList("IsEnable=1 and BannerType=1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void SpecialList_BindGrid()
        {
            zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            DataTable dt = bannerListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "*", "PublishDate", 0, "desc", "IsEnable=1 and BannerType=1").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }



        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            SpecialList_BindGrid();
        }


        #endregion

        #region 行绑定事件

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            //DataRowView dr = e.DataItem as DataRowView;
            //if (dr != null)
            //{
            //    string strPublishDate = dr["PublishDate"].ToString();
            //    e.Values[3] = Conver_DateFormat(strPublishDate);
            //}
        }

        #endregion

        #region 删除按钮事件

        protected void btnDel_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRowIndexArray != null && grid1.SelectedRowIndexArray.Length > 0)
            {
                string strSelectID = "0";
                for (int i = 0, count = grid1.SelectedRowIndexArray.Length; i < count; i++)
                {
                    int rowIndex = grid1.SelectedRowIndexArray[i];
                    foreach (object key in grid1.DataKeys[rowIndex])
                    {
                        strSelectID = key.ToString();
                    }
                }
                #region 删除逻辑

                zlzw.BLL.BannerListBLL BannerListBLL = new zlzw.BLL.BannerListBLL();
                zlzw.Model.BannerListModel bannerListModel = BannerListBLL.GetModel(int.Parse(Get_BannerID(strSelectID)));
                bannerListModel.IsEnable = 0;
                BannerListBLL.Update(bannerListModel);
                SpecialList_BindGrid();

                #endregion
            }
            else
            {
                return;
            }
        }

        #endregion

        #region 根据GUID获取焦点图ID

        private string Get_BannerID(string strBannerGUID)
        {
            zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            DataTable dt = bannerListBLL.GetList("BannerGUID='" + strBannerGUID + "'").Tables[0];

            return dt.Rows[0]["BannerID"].ToString();
        }

        #endregion
    }
}
