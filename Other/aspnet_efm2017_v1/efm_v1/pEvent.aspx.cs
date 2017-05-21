using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace efm_v1
{
    public partial class pEvent: System.Web.UI.Page
    {
        string t_head = "<thead> <tr> " +
                            "<td> Event</td> " +
                            "<td> Nom Event</td> " +
                            "<td> Date Event</td> " +
                            "<td> Nom Stag</td> " +
                        "</tr> </thead>";
        string t_tag = "<table border=\"1\" cellpadding=\"5\" cellspacing=\"3\">",
            t_end_tag = "</table>";
        string even = "";

        SqlConnection connection = new SqlConnection(@"server = WINXP\SQLEXPRESS; " +
                                                      "Initial catalog = efm_v1; " +
                                                      "Integrated security = yes;");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                even = Request.QueryString["event"].ToString( );
                
                if(even == "encours") even = "en cours";
                else if(even == "enattente") even = "en attente";
                else even = "termine";
                
                command.Connection = connection;
                command.CommandText = "SELECT id, nomeven, dateeven, nomstag " +
                                      "FROM Even e, Stag s " +
                                      "WHERE e.idstag = s.id AND etateven = @even";
                command.Parameters.AddWithValue("@even", even);

                connection.Open( );
                reader = command.ExecuteReader( );

                Response.Write(t_tag); // <table ...>
                Response.Write(t_head); // <thead> <tr> <td> idEvent </td> .... </thead>

                while (reader.Read( )) {
                    string t_row = "<tr>" +
                                        "<td>" + reader["id"] + "</td>" +
                                        "<td>" + reader["nomeven"] + "</td>" +
                                        "<td>" + reader["dateeven"] + "</td>" +
                                        "<td>" + reader["nomstag"] + "</td>" +
                                   "</tr>";
                    Response.Write(t_row); // <tr> <td> 11 </td> ... </tr>
                }
                reader.Close( );
                connection.Close( );

                Response.Write(t_end_tag); // </table>
            } catch (Exception) {
                Response.Write("<h1>ERR404</h1>");
            }

        }

    }
}