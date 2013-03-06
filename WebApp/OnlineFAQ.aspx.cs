using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace WebApp
{
    public partial class OnlineFAQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AspNetPager1.RecordCount = Load_MessageListRecordCount();//用户留言总数
                Load_MessageList();//用户留言列表绑定
            }
        }

        #region 获取用户留言总数

        private int Load_MessageListRecordCount()
        {
            zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
            DataTable dt = messageListBLL.GetList("IsEnable=1 and IsReply=1").Tables[0];

            return dt.Rows.Count;
        }

        #endregion

        #region 加载用户留言列表

        private void Load_MessageList()
        {
            int nPageIndex = AspNetPager1.CurrentPageIndex;
            int nPageSize = AspNetPager1.PageSize = 5;
            zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
            DataTable dt = messageListBLL.GetList(nPageSize, nPageIndex, "*", "PublishDate", 0, "desc", "IsEnable=1 and IsReply=1").Tables[0];

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        #endregion

        #region 用户留言行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labPublishUserName = (Label)e.Item.FindControl("labPublishUserName");
                Label labPublishDate = (Label)e.Item.FindControl("labPublishDate");
                Label labPublishContent = (Label)e.Item.FindControl("labPublishContent");
                Label labReplyUser = (Label)e.Item.FindControl("labReplyUser");
                Label labReplyDate = (Label)e.Item.FindControl("labReplyDate");
                Label labReplyContent = (Label)e.Item.FindControl("labReplyContent");

                labPublishUserName.Text = drv["PublishUserName"].ToString();//发布人姓名
                labPublishDate.Text = DateTime.Parse(drv["PublishDate"].ToString()).ToString("yyyy年MM月dd日");//发布日期
                labPublishContent.Text = drv["PublishContent"].ToString();//发布内容
                labReplyUser.Text = Get_ReplyName(drv["ReplyUserGUID"].ToString());//回复人
                labReplyDate.Text = DateTime.Parse(drv["ReplyDate"].ToString()).ToString("yyyy年MM月dd日");//回复日期
                labReplyContent.Text = drv["ReplyContent"].ToString();//回复内容
            }
        }

        #endregion

        #region 分页事件

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Load_MessageList();
        }

        #endregion

        #region 获取回复人名称

        private string Get_ReplyName(string strGUID)
        {
            zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
            DataTable dt = adminListBLL.GetList("AdminGUID='" + strGUID + "'").Tables[0];

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["AdminName"].ToString();
            }
            else
            {
                return "管理员";
            }
        }

        #endregion

        #region 提交问题

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                zlzw.Model.MessageListModal messageListModal = new zlzw.Model.MessageListModal();
                messageListModal.MessageGUID = Guid.NewGuid();
                messageListModal.PublishUserName = search.Value;
                messageListModal.PublishContent = textarea.Value;
                messageListModal.PublishDate = DateTime.Now;
                messageListModal.IsReply = 0;
                messageListModal.IsEnable = 0;
                zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
                messageListBLL.Add(messageListModal);
                search.Value = "";
                textarea.Value = "";
                ClientScript.RegisterStartupScript(Page.GetType(), "SuccessInfo", "<script type='text/javascript'>alert('留言成功，请等待管理员的审核');</script>");
            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(Page.GetType(),"errorInfo","<script type='text/javascript'>alert('留言失败，请稍后重试');</script>");
            }
        }

        #endregion
    }
}
