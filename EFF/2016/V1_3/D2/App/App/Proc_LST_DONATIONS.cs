using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class Proc_LST_DONATIONS: Form
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        public Proc_LST_DONATIONS()
        {
            InitializeComponent( );

            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial catalog = ff2016_v13;" +
                                                     "Integrated Security = YES;");
            commander.CommandText = "SELECT idOp FROM Operation";

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                cbox1.Items.Add(reader["idOp"].ToString( ));
            }
            reader.Close( );
            commander.Connection.Close( );

            commander.CommandType = CommandType.StoredProcedure;
        }

        private void Proc_LST_DONATIONS_Load(object sender, EventArgs e)
        {

        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> view = new List<object>( );

            commander.CommandText = "LST_DONATIONS";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@idOp", cbox1.Text);

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                view.Add(new {
                    nomBien = reader["nomBien"].ToString( ),
                    montantDonation = reader["montantDonation"].ToString( )
                });
            }
            reader.Close( );
            commander.Connection.Close( );

            dgv1.DataSource = null;
            dgv1.DataSource = view;
        }
    }
}
