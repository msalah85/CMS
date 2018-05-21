using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace Share.CMS.MaskanWebSite.Helpers
{
    public class SaveImageOnserver
    {
        public static void SaveImg(HttpPostedFileBase hpf, string Path, int width, int height, int Id)
        {
            bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(Path));
            if (!exists)
                System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(Path));

            string imgPath = Path + Id + System.IO.Path.GetExtension(hpf.FileName);
            Stream stream = hpf.InputStream;
            Bitmap image = new Bitmap(stream);
            Bitmap target = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(target);
            graphic.DrawImage(image, 0, 0, width, height);
            //target.Save(HttpContext.Current.Server.MapPath(imgPath));
            using (MemoryStream ms = new MemoryStream())
            {
                //error will throw from here
                target.Save(ms, ImageFormat.Jpeg);
                target.Save(HttpContext.Current.Server.MapPath(imgPath));
            }

        }

        public static void SaveImg(HttpPostedFile hpf, string Path, int width, int height, int Id)
        {
            bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(Path));
            if (!exists)
                System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(Path));

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