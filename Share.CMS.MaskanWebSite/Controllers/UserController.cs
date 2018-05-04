using Business.Enums;
using Business.Extenions;
using Business.Services;
using Business.Services.Models;
using Business.SessionImpl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
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


        [HttpGet]
        public void LogOut()
        {
            Session[SessionEnum.User_Info.ToString()] = null;
        }

        [HttpGet]
        public string RecoverPassoerd(string Email)
        {
            try
            {
                // check Email in our database or not.
                UserService _userService = new UserService();
                var _paramters = new LogInParams()
                {
                    Email = Email
                };

                List<UserViewModel> User_List = new List<UserViewModel>();
                User_List = _userService.Find(_paramters);
                if (User_List.Count <= 0)
                    return "This email does not exsit in our database";

                //---------------------------------------------------------------

                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                string AppEmail = EncryptDecryptString.Decrypt(ConfigurationManager.AppSettings["Email"], "Taj$$Key");
                string AppPass = EncryptDecryptString.Decrypt(ConfigurationManager.AppSettings["EmailAuth"], "Taj$$Key");

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(AppEmail, AppPass);
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.From = new MailAddress(AppEmail);
                msg.To.Add(new MailAddress(Email));

                msg.Subject = "Maskan Rest Password";

                msg.IsBodyHtml = true;
                string _pass = EncryptDecryptString.Encrypt(Email, "Taj$$Key");

                string CurrentUrl = "http://" + Request.Url.DnsSafeHost + ":" + Request.Url.Port + "/ResetPassword/restpass/" + _pass;
                // Email Body.
                string body = "Dear User <br />";
                body += "Please fllow this link to recover your passord </br>";
                body += "<a href =" + CurrentUrl + "> Maskan rest your Password </ a >  <br />";

                msg.Body = body;
                msg.IsBodyHtml = true;

                client.Send(msg);

                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }



    }
}