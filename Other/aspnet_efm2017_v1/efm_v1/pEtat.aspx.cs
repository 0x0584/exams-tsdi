using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace efm_v1
{
    public partial class About: System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"server = WINXP\SQLEXPRESS; " +
                                                      "Initial catalog = efm_v1; " +
                                                      "Integrated security = yes;");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader;

        int count = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.Open( );

            List<HyperLink> links = new List<HyperLink>();
            links.AddRange(new HyperLink[]{lnkenc, lnkenatt, lnkterm});

            int i = 0;
            foreach (string type_even in new string[] { "en cours", "en attente", "termine" }) {
                command.Parameters.Clear( );
                command.CommandText = "SELECT COUNT(*) FROM Even WHERE etateven = @event";
                command.Parameters.AddWithValue("@event", type_even);

                try {
                    count = (int)command.ExecuteScalar( );
                    links[i].Text = string.Format( "{0}({1})", links[i].Text, count);
                    ++i;
                } catch (SqlException exp) {
                    Response.Write("<h1>" + exp.ToString( ) + "</h1>");
                }
            }

            connection.Close( );
        }
    }
}
