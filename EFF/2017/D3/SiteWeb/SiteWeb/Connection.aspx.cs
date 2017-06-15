using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class Connection: System.Web.UI.Page
    {
        private SqlCommand commander = new SqlCommand( );
        private SqlDataReader reader = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2017_v11;" +
                                                     "Integrated Security = True;");
            Label3.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (tbid.Text != "" && tbpass.Text != "") {
                commander.CommandText = "SELECT * FROM Utilisateur " +
                                        "WHERE idUtil = @id AND " +
                                        "      pass = @passwd";
                commander.Parameters.AddWithValue("@id", tbid.Text);
                commander.Parameters.AddWithValue("@passwd", tbpass.Text);
                commander.Connection.Open( );
                reader = commander.ExecuteReader( );
                bool isvalid = false;

                if (reader.Read( )) {
                    Session["Util"] = tbid.Text;
                    isvalid = true;
                }

                reader.Close( );
                commander.Connection.Close( );

                if (isvalid) Response.Redirect("~/MainPage.aspx");
                else Label3.Text = "ERR";
            } else {
                Label3.Text = "FILL ALL THE FEILDS";
            }

        }
    }
}