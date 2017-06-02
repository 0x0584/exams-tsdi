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
    public partial class SearchFormateur: Form
    {
        SqlCommand commander = new SqlCommand( );

        public SearchFormateur()
        {
            InitializeComponent( );
        }

        private void CountChapitres(Label l)
        {
            commander.CommandText = "SELECT COUNT(*) " +
                                    "FROM Chapitre c, UV u, Formateur f " +
                                    "WHERE u.numUV = c.numUV " +
                                    "   AND u.numEnsei = f.numFormateur " +
                                    "   AND f.numFormateur = @numf";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numf", textBox1.Text);

            commander.Connection.Open( );
            l.Text = "nb chapitres: " + commander.ExecuteScalar( ).ToString( );
            commander.Connection.Close( );
        
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                DataSet ds = new DataSet( );

                try {
                    commander.CommandText = "SELECT * FROM Formateur WHERE numFormateur = @numf";
                    commander.Parameters.Clear( );
                    commander.Parameters.AddWithValue("@numf", textBox1.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(commander);
                    adapter.Fill(ds, "tFormateur");

                } catch (Exception) {
                    MessageBox.Show(e.ToString( ));
                }

                dgv1.DataSource = null;
                dgv1.DataSource = ds.Tables["tFormateur"];
                CountChapitres(lbl_nb_chapitres);
            }
        }

        private void SearchFormateur_Load(object sender, EventArgs e)
        {
            #region setup commander
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2016_v33; " +
                                                     "Integrated Security = yes;");
            commander.CommandText = "SELECT * FROM Formateur WHERE numFormateur = @numf";
            commander.Parameters.AddWithValue("@numf", textBox1.Text);
            #endregion

            textBox1.Text = "1";
            btnsearch_Click(sender, e);
        }

        private void btnuvinfo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                commander.Connection.Open( );
                commander.CommandText = "SELECT * FROM UV u, Formateur f " +
                                        "WHERE (u.numEnsei = f.numFormateur OR u.numRespo = f.numFormateur) " +
                                        "AND f.numFormateur = @numf";
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@numf", textBox1.Text);

                DataSet ds = new DataSet( );
                SqlDataAdapter adapter = new SqlDataAdapter(commander);

                adapter.Fill(ds, "tFormateur");

                dgv1.DataSource = null;
                dgv1.DataSource = ds.Tables["tFormateur"];
                CountChapitres(lbl_nb_chapitres);

                commander.Connection.Close( );
            }
        }



    }
}
