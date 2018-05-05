using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Share.CMS.MaskanWebSite.Areas.Core.Models
{
    public class propertyAddUI_vm
    {
        public List<ProjectTypes_VM> ProjectTypes { get; set; }

        public List<ProjectTypes_VM> PropertyTypes { get; set; }

        public List<ProjectTypes_VM> RegionsNames { get; set; }

        public List<ProjectTypes_VM> AreaTypes { get; set; }

        public List<ProjectTypes_VM> PriceTypes { get; set; }

        public List<ProjectTypes_VM>  FurnitureTypes { get; set; }

        public List<ProjectTypes_VM> ContactPersons { get; set; }

        public List<ProjectTypes_VM> FeaturesNames { get; set; }

        public List<ProjectTypes_VM> OwnerShipTypes { get; set; }

    }
}