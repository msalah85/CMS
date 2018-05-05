using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.propertyAdd
{
    public class FurnitureTypesService : BaseSearchService<ProjectTypes_VM, PagingParams>
    {
        protected override string Find_SP
        {
            get
            {
                return "FurnitureTypes_Names";
            }
        }
    }
}
