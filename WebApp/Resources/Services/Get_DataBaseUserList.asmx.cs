using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApp.Resources.Services
{
    /// <summary>
    /// Get_DataBaseUserList 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Get_DataBaseUserList : System.Web.Services.WebService
    {
        [WebMethod]
        public string Get_Database_UserLogin(string strUserName, string strUserPassword)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBManageConnectionString"].ConnectionString;
            string commandString = "select * from CoreUser where UserStatus=1 and  UserName='" + strUserName + "' and Password='" + strUserPassword + "'";

            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.SqlClient.SqlDataAdapter ada = new System.Data.SqlClient.SqlDataAdapter(commandString, connectionString);
            ada.Fill(ds, "table1");
            System.Data.DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                //byte[] uArray = System.Text.Encoding.UTF8.GetBytes(strUserName);//"admin" 为用户输入的登录账户
                //string u = Convert.ToBase64String(uArray);

                //byte[] pArray = System.Text.Encoding.UTF8.GetBytes(strUserPassword); //"kingstudyhr"为用户输入的登录口令
                //string p = Convert.ToBase64String(pArray);

                string u = strUserName;
                string p = strUserPassword;
                bool isBase64 = false;

                string dbMangageRootUrl = System.Configuration.ConfigurationManager.AppSettings["dbManageURL"]; //数据库管理系统的根地址
                string webLoginUrl = string.Format("{0}/UserCenter/Home/webIndex?u={1}&p={2}&isBase64={3}", dbMangageRootUrl, u, p, isBase64);

                return webLoginUrl;

            }
            else
            {
                return "-1";
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
