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
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AspNetPager1.RecordCount = Load_MessageListRecordCount();//用户留言总数
                Load_MessageList();
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

        #region 历史留言列表绑定

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

        #region 分页事件

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Load_MessageList();
        }

        #endregion

        #region 历史留言列表绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labPublishDate = (Label)e.Item.FindControl("labPublishDate");
                Label labContent = (Label)e.Item.FindControl("labContent");
                Label labReplyPublish = (Label)e.Item.FindControl("labReplyPublish");
                Label labReplyContent = (Label)e.Item.FindControl("labReplyContent");

                labPublishDate.Text = DateTime.Parse(drv["PublishDate"].ToString()).ToString("yyyy年MM月dd日");
                labContent.Text = drv["PublishContent"].ToString();
                labReplyPublish.Text = DateTime.Parse(drv["ReplyDate"].ToString()).ToString("yyyy年MM月dd日");
                labReplyContent.Text = drv["ReplyContent"].ToString();
                
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
                ClientScript.RegisterStartupScript(Page.GetType(), "errorInfo", "<script type='text/javascript'>alert('留言失败，请稍后重试');</script>");
            }
        }

        #endregion
    }
}
