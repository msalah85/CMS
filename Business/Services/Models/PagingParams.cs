using Business.BaseSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class PagingParams : IBaseSearch
    {
        public string  pageNum { get; set; }

        public string pageSize { get; set; }

        public int? key { get; set; }

    }
}