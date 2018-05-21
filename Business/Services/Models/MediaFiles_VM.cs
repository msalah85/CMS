using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class MediaFiles_VM
    {
        public int? MediaFiles { get; set; }

        public int? PropertyID { get; set; }

        public string MediaUrl { get; set; }

        public bool? Active { get; set; }

        public int? Priority { get; set; }

        public int? MediaTypeID { get; set; }

        public bool? IsMain { get; set; }

        public int? Inserted_Inc_Id { get; set; }


    }
}