using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class ConnectionPage: System.Web.UI.Page
    {
        bool isuser;

        protected void Page_Load(object sender, EventArgs e)
        {
            isuser = !(chkguest.Checked = true);
            tbpasswd.Enabled = tbusrname.Enabled = isuser;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbpasswd.Enabled = tbusrname.Enabled = (isuser ^= true);

        }

        

    }
}