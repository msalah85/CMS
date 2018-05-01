using Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services
{
    public class EmailSubscriptionService : BaseSearchService<EmailSubscription_VM, EmailSubscriptionParams>
    {
        protected override string Find_SP
        {
            get
            {
                return "";
            }
        }

        protected override string Insert_SP
        {
            get
            {
                return "Sp_NewsLetterSubscription";
            }
        }

    }
}