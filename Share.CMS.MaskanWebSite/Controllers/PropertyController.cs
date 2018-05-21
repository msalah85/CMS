using Business.Services;
using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Share.CMS.MaskanWebSite.Controllers
{
    public class PropertyController : ApiController
    {
        [HttpPost]
        [Route("api/Property/SaveImages")]
        public HttpResponseMessage SaveImages(MediaFiles_VM[] MediaFiles_VM)
        {
            MediaFilesService Service = new MediaFilesService();
            List<string> Results = new List<string>();
            for (int i = 0; i < MediaFiles_VM.Length; i++)
            {
                if (i == 0)
                    MediaFiles_VM[0].IsMain = true;
                else
                    MediaFiles_VM[i].IsMain = false;

                MediaFiles_VM[i].MediaTypeID = null;
                MediaFiles_VM[i].MediaFiles = null;
                MediaFiles_VM[i].Priority = null;
                MediaFiles_VM[i].Inserted_Inc_Id = null;
                int InsertedIncId = 0;
                int result = Service.InsertWithResult(MediaFiles_VM[i], out InsertedIncId);
                Results.Add(result + "_");
            }
            string ReturnString = string.Join("_", Results.ToArray());
            return Request.CreateResponse(HttpStatusCode.OK, ReturnString.Remove(ReturnString.Length - 1));

        }
    }
}
