﻿using System;
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
    public partial class VentureStarList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_VentureStarListTotalCount();//获取总页数

                #region 列表绑定

                VentureStarList_BindGrid();

                #endregion

                Window1.Title = "添加创业明星";
                btnAdd.OnClientClick = Window1.GetShowReference("AddVentureStar.aspx?Type=0", "添加创业明星") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的创业明星!");
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddVentureStar.aspx?Type=1&value=" + value, "编辑创业明星");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_VentureStarListTotalCount()
        {
            zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
            DataTable dt = ventureStarListBLL.GetList("IsEnable=1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void VentureStarList_BindGrid()
        {
            zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
            DataTable dt = ventureStarListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }

        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, ExtAspNet.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            VentureStarList_BindGrid();
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
                e.Values[1] = Get_StoreTypeName(strDictionaryKey);
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

                zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
                DataTable dt = ventureStarListBLL.GetList("VentureStarGUID='" + strSelectID + "'").Tables[0];
                zlzw.Model.VentureStarListModal ventureStarListModal = ventureStarListBLL.GetModel(int.Parse(dt.Rows[0]["VentureStarID"].ToString()));
                ventureStarListModal.IsEnable = 0;
                ventureStarListBLL.Update(ventureStarListModal);
                VentureStarList_BindGrid();

                #endregion
            }
            else
            {
                return;
            }
        }

        #endregion

        #region 根据GUID获取所在店面

        private string Get_StoreTypeName(string strStoreGUID)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryKey='" + strStoreGUID + "'").Tables[0];

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
