using Business.Enums;
using Business.Extenions;
using Business.Globalization;
using Business.Services;
using Business.Services.Models;
using Business.SessionImpl;
using Share.CMS.MaskanWebSite.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Share.CMS.MaskanWebSite.Areas.Core.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Core/Profile
        public ActionResult Index()
        {
            // Set Language Information.
            ManageUserLanguage(GetActiveLanguage());
            return View();
        }

        [HttpPost]
        public ActionResult SaveProfile(UserViewModel model, HttpPostedFileBase file)
        {
            if (String.IsNullOrEmpty(model.UserFullName) || String.IsNullOrEmpty(model.Password) || string.IsNullOrEmpty(model.Email))
            {
                ViewBag.SuccessMsg = "Please, fill all required fileds";
                return View("Index");
            }
            UserViewModel user = (UserViewModel)Session[SessionEnum.User_Info.ToString()]; // User session.
            if (file != null)
            {
                if (file != null && file.ContentLength > 0)
                {
                    SaveImageOnserver.SaveImg(file, "~/Images/Profile/", 200, 200, Convert.ToInt32(user.UserID));
                }
            }

            // update DB.

            UserService service = new UserService();
            UserViewModel Usermodel = new UserViewModel()
            {
                UserID = user.UserID,
                UserFullName = model.UserFullName,
                Password = EncryptDecryptString.Encrypt(model.Password, "Taj$$Key"),
                Address = model.Address,
                Phone=user.Phone,
                Username=user.Username,
                Country=user.Country,
                Email=model.Email,
                Mobile=user.Mobile,
                Nationality=user.Nationality
            };

            if (file != null)
            {
                Usermodel.Image = Path.GetExtension(file.FileName);
            }
            else
            {
                Usermodel.Image = user.Image;
            }

            int ResultDB = service.Update(Usermodel);
            Session[SessionEnum.User_Info.ToString()] = Usermodel;

            ViewBag.SuccessMsg = "Your data saved successfully";
            return View("Index");
        }

        public int GetActiveLanguage()
        {
            try
            {
                LanguageService _languageService = new LanguageService();
                List<LanguagesViewModel> langs = new List<LanguagesViewModel>();
                langs = _languageService.Find();
                if (langs.Count > 0)
                    return langs[0].LanguageId;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private DataTable tb_GUI_Lang = new DataTable();
        private void ManageUserLanguage(int userLangID)
        {
            try
            {
                string direction = "RTL";
                if (userLangID == 2) direction = "LTR";
                GlobalizationManager _GlobalizationManager;

                SessionHandler.Instance.Remove(SessionEnum.Language_Info);

                if (userLangID != LocalizationService.GetLanguageID("Default"))
                {
                    string module = (ApplicationService.GetByID(Apps.MaskanWeb)).ApplicationName;
                    DataSet ds_ModuleWL = LocalizationService.GetModule(Convert.ToInt32(userLangID), module, true);

                    Session["loginISRTL"] = false;

                    if (ds_ModuleWL != null)
                    {
                        _GlobalizationManager = new GlobalizationManager(ds_ModuleWL, direction);
                    }
                    else
                    {
                        _GlobalizationManager = new GlobalizationManager(tb_GUI_Lang);
                    }
                    SessionHandler.Instance.Set(_GlobalizationManager, SessionEnum.Language_Info);
                }
                else
                {
                    _GlobalizationManager = new GlobalizationManager(tb_GUI_Lang);
                    SessionHandler.Instance.Set(_GlobalizationManager, SessionEnum.Language_Info);
                }
            }
            catch (Exception ex)
            {
                Session["ds_Language_WL"] = null;
            }
        }

    }
}