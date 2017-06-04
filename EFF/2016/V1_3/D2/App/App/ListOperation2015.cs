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
    public partial class ListOperation2015: Form
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        public ListOperation2015()
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial Catalog = ff2016_v13; " +
                                                     "Integrated Security = YES;");
            InitializeComponent( );
        }

        private void ListOperation2015_Load(object sender, EventArgs e)
        {
            List<object> view = new List<object>( );

            commander.CommandText = "SELECT o.nomOp, o.dateCreation, o.montantOp, " +
                                    "       COUNT(b.idBien) as nombreBien  " +
                                    "FROM Operation o, Bienfaisant b, Donation d " +
                                    "WHERE o.cumulMontant >= o.montantOp AND " +
                                    "      YEAR(o.dateCreation) = 2017 AND " +
                                    "      d.idBien = b.idBien AND d.idOp = o.idOp " +
                                    "GROUP BY o.nomOp, o.dateCreation, o.montantOp";

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                view.Add(new {
                    nomOp = reader["nomOp"].ToString( ),
                    dateCreation = reader["dateCreation"].ToString( ),
                    montantOp = reader["montantOp"].ToString( ),
                    nombreBien = reader["nombreBien"].ToString( )
                });
            }
            reader.Close( );
            commander.Connection.Close( );

            dgv1.DataSource = null;
            dgv1.DataSource = view;
        }
    }
}