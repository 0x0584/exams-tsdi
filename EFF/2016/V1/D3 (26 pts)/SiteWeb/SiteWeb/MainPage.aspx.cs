using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class MainPage: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isOrg = false, isGuest = false;

            try {
                if (Request.QueryString["user"] == "false") ;
                
            } catch (Exception) {

                throw;
            }

        }
    }
}