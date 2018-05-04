using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class ResetPasswordService : BaseSearchService<RegisterViewModel, RecoverPass_VM>
    {

        protected override string Find_SP
        {
            get
            {
                return "";
            }
        }

        protected override string Update_SP
        {
            get
            {
                return "Sp_Reset_Password";
            }
        }

        protected override string Insert_SP
        {
            get
            {
                return "";
            }
        }
    }
}