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
    public partial class StoreImageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_StoreImageTotalCount();//获取总页数
                #region 店面图片列表绑定

                StoreImageList_BindGrid();

                #endregion
                Window1.Title = "添加管理员";
                btnAdd.OnClientClick = Window1.GetShowReference("AddStoreImage.aspx?Type=0", "添加店面图片") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的店面图片!");
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddStoreImage.aspx?Type=1&value=" + value, "编辑店面图片");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_StoreImageTotalCount()
        {
            zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
            DataTable dt = storeImageListBLL.GetList("IsEnable=1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void StoreImageList_BindGrid()
        {
            zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
            DataTable dt = storeImageListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }

        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, ExtAspNet.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            StoreImageList_BindGrid();
        }


        #endregion

        #region 行绑定事件

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            DataRowView dr = e.DataItem as DataRowView;
            if (dr != null)
            {
                string strOther01 = dr["Other01"].ToString();
                e.Values[0] = GetRegionName(strOther01);

                string strDictionaryKey = dr["DictionaryKey"].ToString();
                e.Values[1] = Get_StoreTitle(strDictionaryKey);
            }
        }

        #endregion

        #region 获取所属区域名称

        private string GetRegionName(string strOther01)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryListID=" + strOther01).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["DictionaryValue"].ToString();
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

                zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
                DataTable dt = storeImageListBLL.GetList("StoreImageGUID='" + strSelectID + "'").Tables[0];
                zlzw.Model.StoreImageListModal storeImageListModal = storeImageListBLL.GetModel(int.Parse(dt.Rows[0]["StoreImageID"].ToString()));
                storeImageListModal.IsEnable = 0;
                storeImageListBLL.Update(storeImageListModal);
                StoreImageList_BindGrid();

                #endregion
            }
            else
            {
                return;
            }
        }

        #endregion

        #region 根据索引获取店面名称

        private string Get_StoreTitle(string strDictionaryKey)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryKey='" + strDictionaryKey + "'").Tables[0];

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["DictionaryValue"].ToString();
            }
            else
            {
                return "未知";
            }
        }

        #endregion
    }
}
