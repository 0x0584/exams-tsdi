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
            string pMain = "~/MainPage.aspx?";

            if (tbusrname.Text != "" && tbpasswd.Text != "" &&
                !(chkguest.Checked)) {
                string response = string.Empty;
                #region Participant || Organisateur

                bool isvalid, isOrg;
                string email, passwd;

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

                if (isvalid) {
                    response = string.Format(pMain + "user=true&isorg={1}&email={0}", email, isOrg);
                    Response.Redirect(response);
                } else lblerr.Text = "E-mail and/or Password are/is wrong";
                #endregion
                return;
            } else if (tbusrname.Text == "" && tbpasswd.Text == "" &&
                       chkguest.Checked) {
                // Guest user
                Response.Redirect(pMain + "user=false");
            } else /* either login or passwd is empty */ {
                //lblerr.Style.Value = "font-size: 10px; color: #541542;";
                lblerr.Text = "FILL ALL THE FEILDS" +
                              "<BR> OR <I>CHECK 'GUEST'</I> TO SIGN IN AS GUEST";
            }
        }
    }
}