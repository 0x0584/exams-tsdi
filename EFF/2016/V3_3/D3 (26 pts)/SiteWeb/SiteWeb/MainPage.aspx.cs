using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class MainPage: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        protected void GetInfo(int numf)
        {
            commander.CommandText = "SELECT * FROM Formation WHERE numFormation = @numF";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numF", numf);

            reader = commander.ExecuteReader( );

            if (reader.Read( )) {
                lblnum.Text = reader["numFormation"].ToString( );
                lblnom.Text = reader["nomFormation"].ToString( );
                lblnb_uv.Text = reader["nombreUV"].ToString( );
            }

            if (!(reader.IsClosed)) reader.Close( );

        }

        protected object BindGridView(int numf)
        {
            List<object> view = new List<object>( );

            commander.CommandText = "SELECT * FROM UV WHERE numFormation = @numF";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numF", numf);

            reader = commander.ExecuteReader( );

            while (reader.Read( )) {
                view.Add(new {
                    numUV = reader["numUV"].ToString( ),
                    nomUV = reader["nomUV"].ToString( ),
                    massHoraire = reader["massHoraire"].ToString( ),
                    numEnsei = reader["numEnsei"].ToString( ),
                    numRespo = reader["numRespo"].ToString( ),
                });
            }

            reader.Close( );

            return view;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                      "Initial Catalog = ff2016_v33;" +
                                                      "Integrated Security = TRUE;");

            if (Session["Formation"] == null) // la contrainte
                Response.Redirect("~/Default.aspx");

            if (IsPostBack) return;

            commander.Connection.Open( );

            int numFormation = int.Parse(Session["Formation"].ToString( ));

            GetInfo(numFormation);

            gv1.DataSource = null;
            gv1.DataSource = BindGridView(numFormation);
            gv1.DataBind( );

            commander.Connection.Close( );
        }
    }
}