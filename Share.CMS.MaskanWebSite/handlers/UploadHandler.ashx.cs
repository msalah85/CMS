using Share.CMS.MaskanWebSite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Share.CMS.MaskanWebSite.handlers
{
    /// <summary>
    /// Summary description for UploadHandler
    /// </summary>
    public class UploadHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Files.Count > 0)
            {
                // save img with Row Id
                string Id = context.Request["Id"];
                string[] ArrIds = Id.Split('_');
                List<string> finalCount = new List<string>();
                for (int i = 0; i < ArrIds.Length; i++)
                {
                    if (!String.IsNullOrEmpty((ArrIds[i])))
                    {
                        finalCount.Add(ArrIds[i]);
                    }
                }

                //--------------------------------------------------------------------------------------------------------------
                HttpFileCollection files = context.Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    //System.Threading.Thread.Sleep(1000);
                    HttpPostedFile file = files[i];

                    //------------------------------------- when we upload with original zise ---------------------------------
                    //string filename = context.Server.MapPath("~/Uploads/" + System.IO.Path.GetFileName(file.FileName));
                    //file.SaveAs(filename);
                    //----------------------------------------------------------------------------------------------------------

                    //---------------- save withe edit on with and height-------------------------------------------------------

                        SaveImageOnserver.SaveImg(file, "../Images/Property/", 380, 370, int.Parse(finalCount[i]));
                   
                    //ImageInfo info = new ImageInfo() { ImgExt = System.IO.Path.GetExtension(file.FileName) };

                    //JavaScriptSerializer js = new JavaScriptSerializer();
                    //context.Response.Write(js.Serialize(info));

                }
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