using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace WebApp.manage.Services
{
    /// <summary>
    /// UploadPartnersLogo 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class UploadPartnersLogo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void Set_PartnersLogo(string srcImage, string destImage, int x, int y, int width, int height)
        {
            DrawImage(Server.MapPath(srcImage), Server.MapPath(destImage), x, y, width - x, height - y);
        }

        /// <summary>
        /// 根据选择区域剪裁图片
        /// </summary>
        /// <param name="srcImage"></param>
        /// <param name="destImage"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void DrawImage(string srcImage, string destImage, int x, int y, int width, int height)
        {
            try
            {
                using (System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(srcImage))
                {
                    using (System.Drawing.Image templateImage = new System.Drawing.Bitmap(width, height))
                    {
                        using (System.Drawing.Graphics templateGraphics = System.Drawing.Graphics.FromImage(templateImage))
                        {
                            templateGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                            templateGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                            templateGraphics.DrawImage(sourceImage, new System.Drawing.Rectangle(0, 0, width, height), new System.Drawing.Rectangle(x, y, width, height), System.Drawing.GraphicsUnit.Pixel);
                            templateImage.Save(destImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                }
            }
            catch (Exception exp)
            {

            }
        }
    }
}
