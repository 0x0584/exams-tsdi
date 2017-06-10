using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class WebForm1: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceBien.BienfaisantsSoapClient srv = new ServiceBien.BienfaisantsSoapClient( );
            lbltest.Text = srv.nb_Bienfaisants( ).ToString( );

        }
    }
}