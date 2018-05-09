using Business.Services;
using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Share.CMS.WebApi._0.Controllers
{
    public class PropertyController : ApiController
    {
        [HttpGet]
        [Route("api/PropertyService/Property_Get/{Id}")]
        public HttpResponseMessage Property_Get(string  Id)
        {
            try
            {
                Property_Get_Service _propertyService = new Property_Get_Service();
                var _paramters = new propertyGetParams()
                {
                    Id=Convert.ToInt32(Id)
                };

                List<propertyViewModel> Properties_List = new List<propertyViewModel>();
                Properties_List = _propertyService.Find(_paramters);
                return Request.CreateResponse(HttpStatusCode.OK, Properties_List);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
