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
    public partial class FormProc3: Form
    {
        SqlConnection connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial catalog = ff2016; " +
                                                     "Integrated Security = yes; ");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader = null;

        public FormProc3()
        {
            InitializeComponent( );
            command.Connection = connection;
        }

        private void FormProc3_Load(object sender, EventArgs e)
        {
            // TODO: find how to execute a stocked procedure
            //

            List<object> view = new List<object>( );

            connection.Open( );
            
            #region Setup the command
            command.CommandType = CommandType.StoredProcedure;            
            command.CommandText = "LST_PARTICI";
            command.Parameters.Clear( );
            command.Parameters.AddWithValue("@idC", 1);
            #endregion

            reader = command.ExecuteReader( );
            
            while (reader.Read( )) {
                view.Add(new {
                    MontantPart = reader["montantPart"].ToString( ),
                    NomP = reader["nomP"].ToString()
                });
            }
            reader.Close( );

            dataGridView1.DataSource = view;
            connection.Close( );
        }
    }
}
