using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class ConnectionPage: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            if (tbusrname.Text != "" && tbpasswd.Text != "" &&
                !(chkguest.Checked)) {
                // Participant || Organisateur 

                bool isvalid, isOrg;
                string email, passwd;
                string response;

                isvalid = isOrg = false; 
                email = passwd = response = string.Empty;

                #region Retrieve the E-mail and the Password
                using (var commander = new System.Data.SqlClient.SqlCommand( )) {
                    #region Setup the `commander`
                    string strconnection = "Server = WINXP\\SQLEXPRESS; Initial catalog = ff2016; Integrated security = yes;";
                    commander.Connection = new System.Data.SqlClient.SqlConnection(strconnection);
                    commander.CommandText = "SELECT o.emailOrg,o.passOrg, " +
                                                 "p.email, p.passP " +
                                          "FROM Participant p, Organisateur o";
                    #endregion
                    commander.Connection.Open( );
                    using (var reader = commander.ExecuteReader( )) {
                        while (reader.Read( )) {
                            bool issame_email, issame_passwd;

                            #region Organisateur
                            issame_passwd = (reader["passOrg"].ToString( ) == tbpasswd.Text.TrimEnd( ));
                            issame_email = (reader["emailOrg"].ToString( ) == tbusrname.Text.TrimEnd( ));
                            if (issame_email && issame_passwd) {
                                isOrg = isvalid = true;
                                email = reader["emailOrg"].ToString( );
                                passwd = reader["passOrg"].ToString( );
                                break;
                            }
                            #endregion
                            #region Participant
                            issame_email = (reader["email"].ToString( ) == tbusrname.Text.TrimEnd( ));
                            issame_passwd = (reader["passP"].ToString( ) == tbpasswd.Text.TrimEnd( ));
                            if (issame_email && issame_passwd) {
                                isOrg = !(isvalid = true);
                                email = reader["email"].ToString( );
                                passwd = reader["passP"].ToString( );
                                break;
                            }
                            #endregion
                        }
                        reader.Close( );
                    }
                    commander.Connection.Close( );
                }
                #endregion


                if (isvalid) response = string.Format("~/MainPage.aspx?user=true&isorg={2}&email={0}&passwd={1}", email, passwd, isOrg);
                else lblerr.Text = "E-mail and/or Password are/is wrong";

                Response.Redirect(response);
            } else if (tbusrname.Text == "" && tbpasswd.Text == "" &&
                       chkguest.Checked) {
                // Participant (normal user)
                Response.Redirect("~/MainPage.aspx?user=false");
            } /* either login or passwd is empty */ else lblerr.Text = "FILL ALL THE FEILDS OR SIGN IN AS GUEST";

        }
    }
}