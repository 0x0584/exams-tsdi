using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class AddUV: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;
        int numf;

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2016_v33;" +
                                                     "Integrated Security = TRUE;");

            if (Session["Formation"] == null) Response.Redirect("~/Default.aspx");
            else numf = int.Parse(Session["Formation"].ToString( ));

            lblerr.Text = "";
            if (IsPostBack) return; // skip the rest..

            #region Fill DropDownLists
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM Formateur";
            reader = commander.ExecuteReader( );

            while (reader.Read( )) {
                string str = string.Format("({0}) {1}",
                                            reader["numFormateur"].ToString( ),
                                            reader["nomFormateur"].ToString( ));
                ddlist_ens.Items.Add(str);
                ddlist_res.Items.Add(str);
            }
            reader.Close( );

            commander.Connection.Close( );
            #endregion
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            #region Setup Parameters
            commander.Parameters.AddWithValue("@numuv", tbnumuv.Text);
            commander.Parameters.AddWithValue("@nomuv", tbnom.Text);
            commander.Parameters.AddWithValue("@massH", tbmass.Text);
            commander.Parameters.AddWithValue("@E", ddlist_ens.Text.Split(new char[] { '(', ')' })[1]);
            commander.Parameters.AddWithValue("@R", ddlist_ens.Text.Split(new char[] { '(', ')' })[1]);
            commander.Parameters.AddWithValue("@numf", numf);
            #endregion

            commander.Connection.Open( );

            #region Ensure the uniqness of the `numUV`
            commander.CommandText = "SELECT * FROM UV WHERE numUV = @numuv";
            reader = commander.ExecuteReader( );

            if (reader.Read( )) {
                //RegularExpressionValidator1.Text = "Duplicated!!";
                //RegularExpressionValidator1.ErrorMessage = "Duplicated!!";
                lblerr.Text = "Duplicated!!";
                reader.Close( );
                goto FAILED;
            }

            if (!(reader.IsClosed)) reader.Close( );

            #endregion

            commander.CommandText = "INSERT INTO UV " +
                                    "VALUES(@numuv, @nomuv, @massH, @E, @R, @numf)";


            commander.ExecuteNonQuery( );
            commander.Connection.Close( );

            Response.Redirect("~/MainPage.aspx");

        FAILED:
            return;
        }
    }
}