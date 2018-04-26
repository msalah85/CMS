﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Share.CMS.WebAPI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Business.Services.Models;
using Business.Services;

namespace Share.CMS.WebAPI.Controllers
{
    public class UsersAPIController : ApiController
    {
        private UserManager<ApplicationUser> userManager;

        public UsersAPIController()
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
        {
        }

        public UsersAPIController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("api/UsersService/LogIn")]
        public HttpResponseMessage LogIn(LoginViewModel _LogInViewModel)
        {
            try
            {
                var user = userManager.Find(_LogInViewModel.UserName, _LogInViewModel.Password);
                if (user != null)
                {
                    return Request.CreateResponse(HttpStatusCode.Accepted, user);
                }
                else
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid username or password.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/UsersService/Register")]
        public HttpResponseMessage Register(RegisterViewModel model)
        {
            try
            {
                var user = new ApplicationUser() { UserName = model.UserName, Phone = model.Phone, Country = model.Country, Address = model.Address };
                var result = userManager.Create(user, model.Password);
                if (result.Succeeded)
                {
                    return Request.CreateResponse(HttpStatusCode.Accepted, user);
                }
                else
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/PropertyService/Properties_List")]
        public HttpResponseMessage Properties_List(propertyParams _propertyParams)
        {
            try
            {
                propertyService _propertyService = new propertyService();
                var _paramters = new propertyParams()
                {
                    DisplayStart = _propertyParams.DisplayStart,
                    DisplayLength = _propertyParams.DisplayLength
                };
                List<propertyViewModel> Properties_List = new List<propertyViewModel>();
                Properties_List = _propertyService.Find(_paramters);
                return Request.CreateResponse(HttpStatusCode.OK, Properties_List);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
