using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services
{
    public class MediaFilesService : BaseSearchService<MediaFiles_VM, LanguageParams>
    {

        protected override string Insert_SP
        {
            get
            {
                return "Images_Properties_Save";
            }
        }

        protected override string Find_SP
        {
            get
            {
                return "";
            }
        }

    }
}