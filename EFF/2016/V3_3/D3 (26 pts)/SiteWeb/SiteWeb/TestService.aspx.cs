using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class TestService: System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand( );
        SqlDataReader rd = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                               "Initial Catalog = ff2016_v33;" +
                                               "Integrated Security = true;");

            if (IsPostBack) return;

            cmd.CommandText = "SELECT * FROM Formation";
            cmd.Connection.Open( );
            rd = cmd.ExecuteReader( );
            DropDownList1.Items.Clear( );
            while (rd.Read( )) {
                string str = string.Format("({0}) {1}",
                                            rd["numFormation"].ToString( ),
                                            rd["nomFormation"].ToString( ));
                DropDownList1.Items.Add(str);
            }
            cmd.Connection.Close( );
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SrvUV.ServiceUVSoapClient srv = new SrvUV.ServiceUVSoapClient( );

            int numf = int.Parse(DropDownList1.Text.Split(new char[] { '(', ')' })[1]);
            Label1.Text = srv.InfoFormation(numf);
        }
    }
}