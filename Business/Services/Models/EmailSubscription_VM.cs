using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Services.Models
{
    public class EmailSubscription_VM
    {

        public string Email { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedOnUtc { get; set; }

    }
}