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

namespace WebApp.manage
{
    public partial class Login : Utility.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            // 创建一个 6 位的随机数并保存在 Session 对象中
            Session["CaptchaImageText"] = GenerateRandomCode();
        }

        /// <summary>
        /// 创建一个 6 位的随机数
        /// </summary>
        /// <returns></returns>
        private string GenerateRandomCode()
        {
            string s = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                s += random.Next(10).ToString();
            }
            return s;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbCaptcha.Text == "")
            {
                ExtAspNet.Alert.ShowInTop("验证码不能为空");
            }
            if (txbUserName.Text == "")
            {
                ExtAspNet.Alert.ShowInTop("账号不能为空");
                return;
            }
            if (txbPassword.Text == "")
            {
                ExtAspNet.Alert.ShowInTop("密码不能为空");
            }
            if (txbCaptcha.Text != Session["CaptchaImageText"].ToString())
            {
                ExtAspNet.Alert.ShowInTop("验证码错误");
                return;
            }
            zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
            DataTable dt = adminListBLL.GetList("AdminName='" + txbUserName.Text + "' and AdminPassword='"+ txbPassword.Text +"'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                HttpCookie cookie = new HttpCookie("AdminID", dt.Rows[0]["AdminGUID"].ToString());
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
                HttpCookie cookie01 = new HttpCookie("AdminName", HttpUtility.UrlEncode(dt.Rows[0]["AdminName"].ToString(), System.Text.Encoding.GetEncoding("GB2312")));
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie01);
                //MenuDAL menuDAL = new MenuDAL();
                Response.Redirect("default.aspx");
            }
            else
            {
                ExtAspNet.Alert.ShowInTop("账号或密码错误");
            }
            //if (tbxUserName.Text == "admin" && tbxPassword.Text == "admin")
            //{
            //    Alert.ShowInTop("成功登录！");
            //}
            //else
            //{
            //    Alert.ShowInTop("用户名或密码错误！", MessageBoxIcon.Error);
            //}

        }

    }
}
