using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Share.CMS.MaskanWebSite.Helpers
{
    public class SaveImageOnserver
    {
        public static void SaveImg(HttpPostedFileBase hpf, string Path, int width, int height, int Id)
        {
            string imgPath = Path + Id + System.IO.Path.GetExtension(hpf.FileName);
            Stream stream = hpf.InputStream;
            Bitmap image = new Bitmap(stream);
            Bitmap target = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(target);
            graphic.DrawImage(image, 0, 0, width, height);
            target.Save(HttpContext.Current.Server.MapPath(imgPath));
        }
    }
}