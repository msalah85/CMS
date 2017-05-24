//using IraqCars.Business.Business;
//using Minutesuae.SystemUtilities;
using System;
using System.Web.UI;

namespace Share.CMS.Web.Admin
{
    public partial class sys_Default : Page
    {
        void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
                //CookiesManager.ResetCookie();
            }
        }
    }
}