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
        int currentUV = 0;

        protected void FillListView()
        {
            List<string> numUVs = new List<string>( );
            listUV.Items.Clear( );

            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM UV";
            reader = commander.ExecuteReader( );


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
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2016_v33;" +
                                                     "Integrated Security = TRUE;");
            Session["Formation"] = 1;

            if (Session["Formation"] == null) Response.Redirect("~/Default.aspx");
            else numf = int.Parse(Session["Formation"].ToString( ));

            if (listUV.SelectedItem != null)
                currentUV = int.Parse(listUV.SelectedItem.Value);

            gv1.DataSource = new List<object>( );

            if (IsPostBack) return; // skip the rest..

            btndel.Enabled = btnfilter.Enabled = false;
            btnselected.Enabled = btnupdate.Enabled = false;

            FillListView( );
        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            // TODO: find how to confirm!
            // 

            commander.CommandText = "DELETE FROM UV WHERE numUV = @n";

            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@n", currentUV);

            try {
                commander.Connection.Open( );
                commander.ExecuteNonQuery( ); // ask for confirmation
                commander.Connection.Close( );

                FillListView( );

                btndel.Enabled = btnfilter.Enabled = false;
                btnselected.Enabled = btnupdate.Enabled = false;
                gv1.DataSource = null;

                lblinfo.Text = lblerr.Text = "";
            } catch (SqlException sexp) { lblerr.Text = sexp.ToString( ); }


        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM UV WHERE numUV = @n";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@n", currentUV);

            reader = commander.ExecuteReader( );
            reader.Read( );
            lblinfo.Text = string.Format("NUM: {0} | NOM: {1} | MASS HORAIRE: {2}",
                                            reader["numUV"].ToString( ),
                                            reader["nomUV"].ToString( ),
                                            reader["massHoraire"].ToString( ));
            reader.Close( );
            commander.Connection.Close( );

            gv1.DataSource = null;
            btndel.Enabled = btnfilter.Enabled = true;
            btnselected.Enabled = btnupdate.Enabled = true;
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM UV WHERE numUV = @n";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@n", currentUV);

            reader = commander.ExecuteReader( );
            reader.Read( );
            string str = string.Format("~/AddUV.aspx?nu={0}&no={1}&M={2}&E={3}&R={4}",
                                            reader["numUV"].ToString( ),
                                            reader["nomUV"].ToString( ),
                                            reader["massHoraire"].ToString( ),
                                            reader["numEnsei"].ToString( ),
                                            reader["numRespo"].ToString( ));
            reader.Close( );
            commander.Connection.Close( );


            Response.Redirect(str);
        }

        protected void btnselected_Click(object sender, EventArgs e)
        {
            List<object> view = new List<object>( );

            commander.CommandText = "SELECT * FROM Chapitre WHERE numUV = @n";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@n", currentUV);
            commander.Connection.Open( );

            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                object o = new {
                    numChapitre = reader["numChapitre"].ToString( ),
                    nomChapitre = reader["nomChapitre"].ToString( ),
                    numUV = reader["numUV"].ToString( )
                };
                view.Add(o);
            }
            reader.Close( );

            commander.Connection.Close( );

            gv1.DataSource = null;
            gv1.DataSource = view;
            gv1.DataBind( );
        }
    }
}