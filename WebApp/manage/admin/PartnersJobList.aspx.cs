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
    public partial class PartnersJobList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_PostListTotalCount();//获取总页数
                #region 合作伙伴职位列表绑定

                PostList_BindGrid();

                #endregion
                Window1.Title = "添加合作伙伴职位信息";
                btnAdd.OnClientClick = Window1.GetShowReference("AddPartnersJobList.aspx?Type=0", "添加合作伙伴职位信息") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的合作伙伴职位信息!");
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddPartnersJobList.aspx?Type=1&value=" + value, "编辑合作伙伴职位信息");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_PostListTotalCount()
        {
            zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
            DataTable dt = partnersJobListBLL.GetList("IsEnable=1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void PostList_BindGrid()
        {
            zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
            DataTable dt = partnersJobListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }



        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            PostList_BindGrid();
        }


        #endregion

        #region 行绑定事件

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            DataRowView dr = e.DataItem as DataRowView;
            if (dr != null)
            {
                string strDictionaryListID = dr["PartnerGUID"].ToString();
                e.Values[0] = Get_PartnerName(strDictionaryListID);
            }
        }

        #endregion

        #region 获取合作伙伴名称

        private string Get_PartnerName(string strPartnerGUID)
        {
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            DataTable dt = partnersListBLL.GetList("PartnerGUID='"+ strPartnerGUID +"'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["PartnerName"].ToString();
            }
            else
            {
                return "未知";
            }
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

                zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
                zlzw.Model.PartnersJobListModel partnersJobListModel = partnersJobListBLL.GetModel(int.Parse(strSelectID));
                partnersJobListModel.IsEnable = 0;
                partnersJobListBLL.Update(partnersJobListModel);
                PostList_BindGrid();

                #endregion
            }
            else
            {
                return;
            }
        }

        #endregion

        #region 格式转换

        private string Conver_DateFormat(string strPublishDate)
        {
            try
            {
                return DateTime.Parse(strPublishDate).ToString("yyyy年MM月dd日");
            }
            catch (Exception exp)
            {
                return DateTime.Now.ToString("yyyy年MM月dd日");
            }
        }

        #endregion

    }
}