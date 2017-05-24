using System;
using System.Web.UI;

namespace Share.CMS.Web.Admin
{
    public partial class sys_master : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (SessionManager.Current.ID == "0")
            //    Server.Transfer("default.aspx");
        }
    }
}