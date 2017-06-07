using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class Inscription: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            using (var cmd = new System.Data.SqlClient.SqlCommand( )) {
                #region Setup Connection
                cmd.Connection = new System.Data.SqlClient.SqlConnection( );
                cmd.Connection.ConnectionString = "Server = WINXP\\SQLEXPRESS;" +
                                                  "Initial Catalog = ff2016_v13;" +
                                                  "Integrated Security = YES;";
                #endregion

                cmd.Connection.Open( );

                cmd.CommandText = "SELECT TOP 1 idBien FROM Bienfaisant " +
                                  "ORDER BY idBien DESC";
                if (int.Parse(tbid.Text) >= (int)cmd.ExecuteScalar( )) {
                    cmd.CommandText = "INSERT INTO Bienfaisant " +
                                      "VALUES(@idb, @nomb, @prenb, @emailb, @passwdb)";
                    #region Parameters
                    cmd.Parameters.AddWithValue("@idb", tbid.Text);
                    cmd.Parameters.AddWithValue("@nomb", tbname.Text);
                    cmd.Parameters.AddWithValue("@prenb", tbpren.Text);
                    cmd.Parameters.AddWithValue("@emailb", tbemail.Text);
                    cmd.Parameters.AddWithValue("@passwdb", tbpasswd0.Text);
                    #endregion

                    cmd.ExecuteNonQuery( );
                } else {
                    lblerr.Text = "CHOOSE ANOTHER ID";
                }

                cmd.Connection.Close( );
            }

            Session["Email"] = tbemail.Text;
            Session["Type"] = IUser.Type.BIEN;

            Response.Redirect("~/MainPage.aspx");
        }
    }
}