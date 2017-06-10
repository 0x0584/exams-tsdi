using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class Inscription: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbsignup_Click(object sender, EventArgs e)
        {
            int lastid = 0;
            SqlCommand commander = new SqlCommand( );
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial Catalog = ff2016;" +
                                                     "Integrated Security = TRUE;");

            commander.Connection.Open( );

            commander.CommandText = "SELECT TOP 1 idP FROM Participant ORDER BY idP DESC";
            lastid = (int)commander.ExecuteScalar( );

            commander.CommandText = "INSERT INTO Participant VALUES(@idp, @nomp, @prenp, @emailp, @passwdp)";
            commander.Parameters.AddWithValue("@idp", ++lastid);
            commander.Parameters.AddWithValue("@nomp", tbname.Text);
            commander.Parameters.AddWithValue("@prenp", tbpren.Text);
            commander.Parameters.AddWithValue("@emailp", tbemail.Text);
            commander.Parameters.AddWithValue("@passwdp", tbpasswd0.Text);

            commander.ExecuteNonQuery( );

            commander.Connection.Close( );

            Response.Redirect(string.Format("~/MainPage.aspx?user=true&isorg=false&" +
                                                            "email={0}", tbemail.Text));
        }
    }
}