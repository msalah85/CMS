using Business.Enums;
using Business.Extenions;
using Business.Globalization;
using Business.Services;
using Business.Services.Models;
using Business.Services.propertyAdd;
using Business.SessionImpl;
using Newtonsoft.Json;
using Share.CMS.MaskanWebSite.Areas.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Share.CMS.MaskanWebSite.Areas.Core.Controllers
{
    public class PropertyController : Controller
    {
        // GET: Core/Property
        public ActionResult Index()
        {
            // Set Language Information.
            ManageUserLanguage(GetActiveLanguage());

            // Fill UI Model.
            propertyAddUI_vm UIModel = new propertyAddUI_vm();
            UIModel.ProjectTypes = ProjectTypes();
            UIModel.PropertyTypes = PropertyTypes();
            UIModel.RegionsNames = Regions_Names();
            UIModel.AreaTypes = AreaTypes();
            UIModel.PriceTypes = PriceTypes();
            UIModel.FurnitureTypes = FurnitureTypes();
            UIModel.ContactPersons = ContactPersons();
            UIModel.FeaturesNames = FeaturesNames();
            UIModel.OwnerShipTypes = OwnershipsNames();

            return View(UIModel);
        }


        // Get Form data.
        // - Project Types. 
        public List<ProjectTypes_VM> ProjectTypes()
        {
            ProjectTypesService Service = new ProjectTypesService();
            List<ProjectTypes_VM> ProjTypes = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return ProjTypes;
        }


        // - Prop Types. 
        public List<ProjectTypes_VM> PropertyTypes()
        {
            PropertyTypesService Service = new PropertyTypesService();
            List<ProjectTypes_VM> PropertyTypes = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return PropertyTypes;
        }


        // Regions names
        public List<ProjectTypes_VM> Regions_Names()
        {
            RegionsNamesService Service = new RegionsNamesService();
            List<ProjectTypes_VM> Regions_Names = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return Regions_Names;
        }


        // Area Types.
        public List<ProjectTypes_VM> AreaTypes()
        {
            AreaTypesService Service = new AreaTypesService();
            List<ProjectTypes_VM> AreaTypes = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return AreaTypes;
        }

        // price types.
        public List<ProjectTypes_VM> PriceTypes()
        {
            PriceTypesService Service = new PriceTypesService();
            List<ProjectTypes_VM> PriceTypes = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return PriceTypes;
        }



        // price types.
        public List<ProjectTypes_VM> FurnitureTypes()
        {
            FurnitureTypesService Service = new FurnitureTypesService();
            List<ProjectTypes_VM> FurnitureTypes = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return FurnitureTypes;
        }


        // Contact Persons.
        public List<ProjectTypes_VM> ContactPersons()
        {
            ContactPersonService Service = new ContactPersonService();
            List<ProjectTypes_VM> ContactPersons = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return ContactPersons;
        }


        // Contact Persons.
        public List<ProjectTypes_VM> FeaturesNames()
        {
            FeaturesService Service = new FeaturesService();
            List<ProjectTypes_VM> FeaturesNames = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return FeaturesNames;
        }


        // Ownership Serivce
        public List<ProjectTypes_VM> OwnershipsNames()
        {
            OwnerShipService Service = new OwnerShipService();
            List<ProjectTypes_VM> Ownerships = Service.Find(new PagingParams { key = null, pageNum = "1", pageSize = "10" });
            return Ownerships;
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


        [HttpPost]
        public int InsertProperty(propertyViewModel propertyViewModel)
        {
            UserViewModel user = (UserViewModel)Session[SessionEnum.User_Info.ToString()]; // User session.
            propertyService service = new propertyService();
            propertyViewModel Model = new propertyViewModel
            {
                Active = true,
                AddedByUserID = Convert.ToInt32(user.UserID),
                AdditionalRooms = propertyViewModel.AdditionalRooms,
                Area = propertyViewModel.Area,
                AreaTypeID = propertyViewModel.AreaTypeID,
                Balconies = propertyViewModel.Balconies,
                Bathrooms = propertyViewModel.Bathrooms,
                BedRooms = propertyViewModel.BedRooms,
                CityID = propertyViewModel.CityID,
                ContactPersonID = 1,
                CountryID = propertyViewModel.CountryID,
                CreationDate = Convert.ToDateTime(propertyViewModel.CreationDate),
                Description = propertyViewModel.Description,
                Floor = propertyViewModel.Floor,
                FurnitureTypeID = propertyViewModel.FurnitureTypeID,
                LocationLang = propertyViewModel.LocationLang,
                LocationLat = propertyViewModel.LocationLat,
                OwnershipTypeID = propertyViewModel.OwnershipTypeID,
                Price = propertyViewModel.Price,
                PriceTypeID = propertyViewModel.PriceTypeID,
                ProjectTypeID = propertyViewModel.ProjectTypeID,
                PropertyID = propertyViewModel.PropertyID,
                PropertyTitle = propertyViewModel.PropertyTitle,
                PropertyTypeID = propertyViewModel.PropertyTypeID,
                ResidanceID = propertyViewModel.ResidanceID,
                StreetID = propertyViewModel.StreetID
            };

            int result = service.Insert(Model);
            return result;
        }

    }
}