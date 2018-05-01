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
    public class EmailSubscriptionController : ApiController
    {

        [HttpPost]
        [Route("api/EmailSubscription/AddEmailSubscription")]
        public HttpResponseMessage AddEmailSubscription(EmailSubscription_VM emailSubscription_VM)
        {
            try
            {
                EmailSubscriptionService MailService = new EmailSubscriptionService();
                var MailObject = new EmailSubscription_VM
                {
                    Active = true,
                    CreatedOnUtc = DateTime.Now,
                    Email = emailSubscription_VM.Email
                };

                var Result = MailService.Insert(MailObject);

                if (Result == -1)
                    return Request.CreateResponse(HttpStatusCode.OK, Result); //User with this Email or Username Already Exists
                if (Result <= 1)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, Result);
                }
                else
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
