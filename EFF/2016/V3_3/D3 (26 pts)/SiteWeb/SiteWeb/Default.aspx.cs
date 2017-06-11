using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class _Default: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial Catalog = ff2016_v33; " +
                                                     "Integrated Security = TRUE;");
            lblerr.Text = "";
        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            commander.CommandText = "SELECT * FROM " +
                                    "Formation " +
                                    "WHERE numFormation = @numf AND " +
                                    "motdepass = @passwd";

            commander.Parameters.AddWithValue("@numf", tbnumf.Text);
            commander.Parameters.AddWithValue("@passwd", tbpassf.Text);

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );

            if (reader.Read( )) {
                // Tout accès direct sans authentification
                // permet de retourner l’utilisateur à la page de login
                //
                // if(Session["Formation"] != null) ...
                Session["Formation"] = reader["numFormation"].ToString( );
                Response.Redirect("~/MainPage.aspx");
            } else lblerr.Text = "ERR";
        }
    }
}
