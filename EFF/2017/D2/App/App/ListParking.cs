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
    public partial class ListParking: Form
    {
        private SqlCommand commander = new SqlCommand( );
        private SqlDataReader reader = null;

        public ListParking()
        {
            InitializeComponent( );
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2017_v11;" +
                                                     "Integrated Security = True;");

        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<object> view = new List<object>( );

            commander.CommandText = "SELECT nomPark, adPark FROM Parking " +
                                    "WHERE ville = @v";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@v", tbsearch.Text);
            commander.Connection.Open( );

            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                view.Add(new {
                    nomPark = reader["nomPark"].ToString( ),
                    adPark = reader["adPark"].ToString( )
                });
            }
            reader.Close( );
            commander.Connection.Close( );

            dgv1.DataSource = null;
            dgv1.DataSource = view;
        }

      
    }
}
