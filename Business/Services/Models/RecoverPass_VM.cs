using Business.BaseSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class RecoverPass_VM : IBaseSearch
    {
        public string NewPassword { get; set; }

        public string ConfirmedPassword { get; set; }

        public string Email { get; set; }


    }
}