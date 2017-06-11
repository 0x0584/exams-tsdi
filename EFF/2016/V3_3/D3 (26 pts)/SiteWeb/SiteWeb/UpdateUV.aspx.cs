using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class UpdateUV: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;
        int numf = 0;
        string currentUV = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2016_v33;" +
                                                     "Integrated Security = TRUE;");
            Session["Formation"] = 1;

            if (Session["Formation"] == null) Response.Redirect("~/Default.aspx");
            else numf = int.Parse(Session["Formation"].ToString( ));

            if (IsPostBack) return; // skip the rest..

            btndel.Enabled = btnfilter.Enabled = false;
            btnselected.Enabled = btnupdate.Enabled = false;

            #region Fill ListUV
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM UV";
            reader = commander.ExecuteReader( );

            List<string> numUVs = new List<string>( );

            while (reader.Read( )) {
                string item = string.Format("{0} [{1}hrs]", reader["nomUV"].ToString( ),
                                                            reader["massHoraire"].ToString( ));
                listUV.Items.Add(item);
                numUVs.Add(reader["numUV"].ToString( ));
            }
            reader.Close( );

            for (int i = 0; i < listUV.Items.Count; i++) {
                listUV.Items[i].Value = numUVs[i];
            }

            commander.Connection.Close( );
            #endregion
        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            // TODO: find how to confirm!
            // 


        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM UV WHERE numUV = @n";
            commander.Parameters.AddWithValue("@n", int.Parse(listUV.SelectedItem.Value));
            
            reader = commander.ExecuteReader( );
            reader.Read( );
            lblinfo.Text = string.Format("NUM: {0} | NOM: {1} | MASS HORAIRE: {2}",
                                            reader["numUV"].ToString( ),
                                            reader["nomUV"].ToString( ),
                                            reader["massHoraire"].ToString( ));
            reader.Close( );
            commander.Connection.Close( );
            
            btndel.Enabled = btnfilter.Enabled = true;
            btnselected.Enabled = btnupdate.Enabled = true;
        }
    }
}