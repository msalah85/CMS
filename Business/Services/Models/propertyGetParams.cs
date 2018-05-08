using Business.BaseSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class propertyGetParams : IBaseSearch
    {
        public string Id { get; set; }
    }
}