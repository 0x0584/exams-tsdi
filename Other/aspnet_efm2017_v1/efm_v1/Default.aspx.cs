using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace efm_v1
{
    public partial class _Default: System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"server = WINXP\SQLEXPRESS; Initial catalog = efm_v1; Integrated security = yes;");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader;

        int lastid = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection.Open( );
            command.CommandText = "SELECT id FROM Stag";
            command.Connection = connection;

            reader = command.ExecuteReader( );
            ddl_ids.Items.Clear( );
            while (reader.Read( ))
                ddl_ids.Items.Add(reader[0].ToString( ));
            reader.Close( );

            command.CommandText = "SELECT ideven FROM Even";
            reader = command.ExecuteReader( );
            while (reader.Read( ))
                lastid = int.Parse(reader[0].ToString( ));
            reader.Close( );

            tbeventid.Text = lastid.ToString( );
            rdetatevent.Items[0].Selected = true;
        
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            command.CommandText = "INSERT INTO Even values(@id, @nom, @date, @etat, @idstag)";
            command.Parameters.AddWithValue("@id", lastid);            
            command.Parameters.AddWithValue("@nom", TextBox2.Text);
            command.Parameters.AddWithValue("@date", Calendar1.SelectedDate);

            for (int i = 0; i < rdetatevent.Items.Count; ++i)
                if (rdetatevent.Items[i].Selected) {
                    command.Parameters.AddWithValue("@etat", rdetatevent.Items[i].Value);
                    break;
                }
            command.Parameters.AddWithValue("@idstag", ddl_ids.Text);

            try {
                connection.Open( );
                command.ExecuteNonQuery( );
                ++lastid;
            } catch (SqlException exp) {
                lblnomevent.Text = exp.ToString( );
            } finally {  connection.Close( ); }
        }
    }
}
