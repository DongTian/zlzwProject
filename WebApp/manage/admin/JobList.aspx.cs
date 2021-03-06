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
    public partial class JobList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.RecordCount = Get_AdminListTotalCount();//获取总页数
                #region 热门岗位列表绑定

                JobList_BindGrid();

                #endregion
                Window1.Title = "添加管理员";
                btnAdd.OnClientClick = Window1.GetShowReference("AddJob.aspx?Type=0", "添加岗位") + "return false;";
                btnDel.OnClientClick = grid1.GetNoSelectionAlertReference("请选择要删除的岗位!");
            }
        }

        #region 页面方法

        protected string GetMyValue(object value)
        {
            return (Convert.ToInt32(value) * 100).ToString();
        }

        protected string GetEditUrl(object value)
        {
            return "javascript:" + Window1.GetShowReference("AddJob.aspx?Type=1&value=" + value, "编辑岗位");
            //return String.Format("javascript:box.{0}_show(\"AddEnterpriseAfficheList.aspx?value={1}\", \"This is title\");", Window1.ClientID, value);
        }

        #endregion

        #region 数据绑定

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <returns></returns>
        private int Get_AdminListTotalCount()
        {
            zlzw.BLL.JobListBLL jobListBLL = new zlzw.BLL.JobListBLL();
            DataTable dt = jobListBLL.GetList("").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }
        }

        private void JobList_BindGrid()
        {
            zlzw.BLL.JobListBLL jobListBLL = new zlzw.BLL.JobListBLL();
            DataTable dt = jobListBLL.GetList(grid1.PageSize, grid1.PageIndex + 1, "JobID,JobName,IsHot,IsEnable,PublishDate", "PublishDate", 0, "desc", "").Tables[0];

            grid1.DataSource = dt;
            grid1.DataBind();
        }



        #endregion

        #region 分页事件

        protected void Grid1_PageIndexChange(object sender, ExtAspNet.GridPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;

            JobList_BindGrid();
        }


        #endregion

        #region 行绑定事件

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            DataRowView dr = e.DataItem as DataRowView;
            if (dr != null)
            {
                string strPublishDate = dr["PublishDate"].ToString();
                e.Values[3] = Conver_DateFormat(strPublishDate);
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

                zlzw.BLL.JobListBLL jobListBLL = new zlzw.BLL.JobListBLL();
                zlzw.Model.JobListModel jobListModal = jobListBLL.GetModel(int.Parse(strSelectID));
                jobListModal.IsEnable = 0;
                jobListBLL.Update(jobListModal);
                JobList_BindGrid();

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
