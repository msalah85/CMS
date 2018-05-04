using Business.Enums;
using Business.Extenions;
using Business.Globalization;
using Business.Services;
using Business.Services.Models;
using Business.SessionImpl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Share.CMS.MaskanWebSite.Controllers
{
    public class ResetPasswordController : Controller
    {
        GlobalizationManager _GlobalizationManager = SessionHandler.Instance.Get<GlobalizationManager>(SessionEnum.Language_Info);

        // GET: ResetPassword
        public ActionResult Index()
        {
            // Set Language Information.
            ManageUserLanguage(GetActiveLanguage());
            return View();
        }

        public ActionResult RestPass(RecoverPass_VM recoverPass_VM)
        {
            if (recoverPass_VM.NewPassword == "" || recoverPass_VM.NewPassword == null)
                return View("Index");

            if (recoverPass_VM.NewPassword != recoverPass_VM.ConfirmedPassword)
            {
                ViewBag.ErrorMessage = "Please make shure Passowrds are matched";
                return View("Index");
            }
            else
            {
                // Update User Row With new password.
                string Email = EncryptDecryptString.Decrypt(Request.Url.Segments.Last(), "Taj$$Key");
                ResetPasswordService ResetService = new ResetPasswordService();
                var Model = new RegisterViewModel { Email = Email, Password = EncryptDecryptString.Encrypt(recoverPass_VM.NewPassword, "Taj$$Key") };
                Model.IsActive = null; Model.Mobile = null; Model.Phone = null; Model.UserID = null; Model.Username = null;
                int Result = ResetService.Update(Model);
                if (Result < 0)
                {
                    ViewBag.ErrorMessage = _GlobalizationManager.GetTranslatedText("There is an Error while recovering your password", Enum_LangModule.MaskanWeb, "84");
                    return View("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = _GlobalizationManager.GetTranslatedText("Your password successfully recovered, Please login with your new password.", Enum_LangModule.MaskanWeb, "83");
                    return View("Index");
                }
            }
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