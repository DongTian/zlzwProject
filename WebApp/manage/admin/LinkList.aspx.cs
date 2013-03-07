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
    public partial class LinkList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_LinkListTotalCount();//获取总页数
                #region 友情链接列表绑定

                LinkList_BindGrid();

                #endregion
                Window1.Title = "添加友情链接";
                btnAdd.OnClientClick = Window1.GetShowReference("AddLinkList.aspx?Type=0", "添加友情链接员") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的友情链接!");
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddLinkList.aspx?Type=1&value=" + value, "编辑友情链接");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_LinkListTotalCount()
        {
            zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
            DataTable dt = linkListBLL.GetList("IsEnable=1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void LinkList_BindGrid()
        {
            zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
            DataTable dt = linkListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }



        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            LinkList_BindGrid();
        }


        #endregion

        #region 行绑定事件

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            DataRowView dr = e.DataItem as DataRowView;
            if (dr != null)
            {
                string strLinkType = dr["LinkType"].ToString();
                if (strLinkType == "0")
                {
                    e.Values[0] = "图片";
                }
                else
                {
                    e.Values[0] = "文字";
                }
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

                zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
                zlzw.Model.AdminListModel adminListModel = adminListBLL.GetModel(int.Parse(strSelectID));
                adminListModel.IsEnable = 0;
                adminListBLL.Update(adminListModel);
                LinkList_BindGrid();

                #endregion
            }
            else
            {
                return;
            }
        }

        #endregion
    }
}
