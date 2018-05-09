using Business.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class propertyViewModel
    {
        [NonSqlParameter]
        public string PropertyID { get; set; }

        public DateTime CreationDate { get; set; }

        public string CountryID { get; set; }

        public string CityID { get; set; }

        public string ResidanceID { get; set; }

        public string StreetID { get; set; }

        public string LocationLat { get; set; }

        public string LocationLang { get; set; }

        public string ContactPersonID { get; set; }

        public string AddedByUserID { get; set; }

        public bool Active { get; set; }

        public string PropertyTitle { get; set; }

        public string Description { get; set; }

        public string Area { get; set; }

        public string AreaTypeID { get; set; }

        public decimal Price { get; set; }

        public string PriceTypeID { get; set; }

        public string BedRooms { get; set; }

        public string AdditionalRooms { get; set; }

        public string Bathrooms { get; set; }

        public string Balconies { get; set; }

        public string Floor { get; set; }

        public string FurnitureTypeID { get; set; }

        public string PropertyTypeID { get; set; }

        public string ProjectTypeID { get; set; }

        public string OwnershipTypeID { get; set; }


    }
}