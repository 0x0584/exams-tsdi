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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ToMainPage(string email, bool isplan)
        {
            IUser.Type type;

            if (!(isplan) && email != "none") type = IUser.Type.BIEN;
            else if (isplan) type = IUser.Type.PLAN;
            else type = IUser.Type.GUEST;

            string pMain = "~/MainPage.aspx";

            Session["Email"] = email;
            Session["Type"] = type;

            Response.Redirect(pMain);
        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            if (IsPostBack) {
                if (tbemail.Text != "" && tbpasswd.Text != "") {
                    bool isplan = false;
                    bool exists = false;
                    string email = "";

                    #region Planificateur || Bienfaisant
                    SqlCommand commander = new SqlCommand( );

                    #region Setup commander
                    commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                             "Initial Catalog = ff2016_v13;" +
                                                             "Integrated Security = YES;");
                    commander.Parameters.AddWithValue("@email", tbemail.Text);
                    commander.Parameters.AddWithValue("@passwd", tbpasswd.Text);
                    #endregion

                    commander.CommandText = "SELECT * FROM Bienfaisant b " +
                                            "WHERE (b.emailBien = @email AND b.passBien = @passwd)";
                    commander.Connection.Open( );
                    SqlDataReader reader = commander.ExecuteReader( );

                    if (reader.Read( )) {
                        email = reader["emailBien"].ToString( );
                        exists |= true; // it's true!
                        goto TO_PAGE;
                    }

                    commander.CommandText = "SELECT * FROM Planificateur b " +
                                            "WHERE (b.emailPlan = @email AND b.passPlan = @passwd)";
                    if (!(reader.IsClosed)) reader.Close( );
                    reader = commander.ExecuteReader( );

                    if (reader.Read( )) {
                        email = reader["emailPlan"].ToString( );
                        exists |= (isplan ^= true); // it's true too!!
                        goto TO_PAGE;
                    }

                TO_PAGE:
                    commander.Connection.Close( );
                    #endregion

                    if (exists) ToMainPage(email, isplan);
                    else lblerr.Text = "E-MAIL AND/OR PASSWORD ARE/IS WRONG";
                } else if (chboxguest.Checked) {
                    ToMainPage("none", false);
                } else {
                    lblerr.Text = "ERR, FILL ALL THE FEILDS OR SIGN IN AS GUEST!";
                }
            }
        }
    }
}
