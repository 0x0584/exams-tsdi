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
    public partial class Consultation: Form
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        public Consultation()
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial catalog = ff2016_v13; " +
                                                     "Integrated Security = YES;");
            InitializeComponent( );
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            commander.CommandText = "SELECT * FROM Famille";

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                cbox1.Items.Add(string.Format("({0}) {1}",reader["idFamille"].ToString(),
                                                          reader["nomFamille"].ToString( )));
            }
            reader.Close( );
            commander.Connection.Close( );
        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] g = cbox1.Text.Split(new char[] { '(', ')' });

            int idf = int.Parse(cbox1.Text.Split(new char[] { '(', ')' })[1]);

            List<object> view = new List<object>( );

            commander.CommandText = "SELECT o.nomOp, o.dateFin, SUM(d.montantDonation) AS totalDonation " +
                                    "FROM Operation o, Donation d " +
                                    "WHERE d.idOp = o.idOp AND o.idFamille = @idf " +
                                    "GROUP BY o.nomOp, dateFin";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@idf", idf);

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                view.Add(new {
                    nomOP = reader["nomOp"].ToString( ),
                    dateFin = reader["dateFin"].ToString( ),
                    totalDonation = reader["totalDonation"].ToString( )
                });
            }
            reader.Close( );
            commander.Connection.Close( );

            dgv1.DataSource = null;
            dgv1.DataSource = view;
        }

    }
}
