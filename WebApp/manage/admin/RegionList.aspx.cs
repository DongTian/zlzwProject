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
    public partial class RegionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_RegionListTotalCount();//获取总页数
                #region 区域类型列表绑定



                #endregion
                Window1.Title = "添加地区信息";
                btnAdd.OnClientClick = Window1.GetShowReference("AddRegion.aspx?Type=0", "添加地区信息") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的地区信息!");

                RegionList_BindGrid();
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddRegion.aspx?Type=1&value=" + value, "编辑地区信息");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_RegionListTotalCount()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("IsEnable=1 and DictionaryCategory='RegionType'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void RegionList_BindGrid()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "*", "PublishDate", 0, "desc", "DictionaryCategory='RegionType' and IsEnable=1").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }

        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            RegionList_BindGrid();
        }


        #endregion

        #region 行绑定事件

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            //DataRowView dr = e.DataItem as DataRowView;
            //if (dr != null)
            //{
            //    string strPublishUserGUID = dr["PublishUserGUID"].ToString();
            //    e.Values[1] = Get_PublishName(strPublishUserGUID);

                
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

                zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
                zlzw.Model.DictionaryListModel dictionaryListModel = dictionaryListBLL.GetModel(int.Parse(strSelectID));
                dictionaryListModel.IsEnable = 0;
                dictionaryListBLL.Update(dictionaryListModel);
                RegionList_BindGrid();
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
