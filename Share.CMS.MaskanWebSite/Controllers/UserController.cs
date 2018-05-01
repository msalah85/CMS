using Business.Enums;
using Business.Extenions;
using Business.Services;
using Business.Services.Models;
using Business.SessionImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Share.CMS.MaskanWebSite.Controllers
{
    public class UserController : Controller
    {

        [HttpPost]
        public int LogIn(LogInParams _LogInViewModel)
        {
            try
            {
                UserService _userService = new UserService();
                string _pass = EncryptDecryptString.Encrypt(_LogInViewModel.Password, "Taj$$Key");
                var _paramters = new LogInParams()
                {
                    Username = _LogInViewModel.Username,
                    Password = _pass
                };

                List<UserViewModel> User_List = new List<UserViewModel>();
                User_List = _userService.Find(_paramters);
                if (User_List.Count <= 0)
                    return -1;

                Session[SessionEnum.User_Info.ToString()] = new UserViewModel();
                Session[SessionEnum.User_Info.ToString()] = User_List[0];

                return 1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost]
        public int Register(UserViewModel model)
        {
            try
            {
                UserService _userService = new UserService();
                string _pass = EncryptDecryptString.Encrypt(model.Password, "Taj$$Key");
                var _paramters = new UserViewModel()
                {
                    Username = model.Username,
                    UserFullName = model.Username,
                    Password = _pass,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    Country = model.Country
                };
                _paramters.UserID = null;
                _paramters.IsActive = null;
                _paramters.IsDeleted = null;

                int Result = _userService.Insert(_paramters);

                // set Current session.
                Session[SessionEnum.User_Info.ToString()] = new UserViewModel();
                Session[SessionEnum.User_Info.ToString()] = _paramters;

                return Result;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }




    }
}