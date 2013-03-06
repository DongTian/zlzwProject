using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace WebApp.manage.Services
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UploadPartnersLogo1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            HttpPostedFile file = context.Request.Files["Filedata"];
            string uploadPath =
                HttpContext.Current.Server.MapPath(@context.Request["folder"]) + "\\";

            //if (context.Request.Cookies["LoginUserID"] == null)
            //{
            //    context.Response.Write("0");
            //}
            if (file != null)
            {
                if (!System.IO.Directory.Exists(uploadPath))
                {
                    System.IO.Directory.CreateDirectory(uploadPath);
                }
                string strExtension = file.FileName.Substring(file.FileName.LastIndexOf('.'));
                string strFileName_Prefix = DateTime.Now.ToString("yyyyMMddHHmmssffff");//文件前缀名称
                string fileName = strFileName_Prefix + "_b" + strExtension;// 文件名称

                string strFilePath = context.Server.MapPath("~/PartnersLogo/" + fileName);
                file.SaveAs(uploadPath + fileName);
                //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
                context.Response.Write("PartnersLogo/" + fileName);
            }
            else
            {
                context.Response.Write("0");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
