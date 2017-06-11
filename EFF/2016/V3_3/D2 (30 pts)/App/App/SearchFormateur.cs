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
        SqlDataReader reader = null;

        public SearchFormateur()
        {
            InitializeComponent( );
        }

        private void CountEnseiRespo(Label l, Label ll)
        {
            commander.CommandText = "SELECT COUNT(u.numEnsei) FROM UV u " +
                                    "WHERE (u.numEnsei = @numf)";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numf", tbsearch.Text);

            l.Text = "nb Enseign: " + commander.ExecuteScalar( ).ToString( );
        
            commander.CommandText = "SELECT COUNT(u.numRespo) FROM UV u " +
                                    "WHERE (u.numRespo = @numf)";

            ll.Text = "nb Respo: " + commander.ExecuteScalar( ).ToString( );
        }

        private void CountChapitres(Label l)
        {
            commander.CommandText = "SELECT COUNT(*) " +
                                    "FROM Chapitre c, UV u, Formateur f " +
                                    "WHERE u.numUV = c.numUV " +
                                    "   AND u.numEnsei = f.numFormateur " +
                                    "   AND f.numFormateur = @numf";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numf", tbsearch.Text);

            l.Text = "nb chapitres: " + commander.ExecuteScalar( ).ToString( );

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (tbsearch.Text != "") {

                try {
                    commander.CommandText = "SELECT * FROM Formateur WHERE numFormateur = @numf";
                    commander.Parameters.Clear( );
                    commander.Parameters.AddWithValue("@numf", tbsearch.Text);

                    commander.Connection.Open( );

                    reader = commander.ExecuteReader( );

                    if (reader.Read( )) {
                        tbname.Text = reader["nomFormateur"].ToString( );
                        tbpren.Text = reader["prenFormateur"].ToString( );
                        tbtele.Text = reader["teleFormateur"].ToString( );
                        tbaddr.Text = reader["AddrFormateur"].ToString( );
                        chboxtype.Text = reader["typeFormateur"].ToString( );
                    } else {
                        tbaddr.Text = tbname.Text = "";
                        tbpren.Text = tbtele.Text = "";
                        chboxtype.Text = "";
                    }

                    if (!(reader.IsClosed)) reader.Close( );

                    CountChapitres(lbl_nb_chapitres);
                    CountEnseiRespo(lbl_ensei, lbl_respo);
                    commander.Connection.Close( );
                } catch (Exception) {
                    MessageBox.Show(e.ToString( ));
                }

            }
        }

        private void SearchFormateur_Load(object sender, EventArgs e)
        {
            #region setup commander
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2016_v33; " +
                                                     "Integrated Security = yes;");
            #endregion

            tbsearch.Text = "1";
            btnsearch_Click(sender, e);
        }

        private void btnuvinfo_Click(object sender, EventArgs e)
        {
            if (tbsearch.Text != "") {
                commander.Connection.Open( );
                commander.CommandText = "SELECT u.numUV, u.nomUV, u.numFormation, " +
                                        "       u.numEnsei, u.numRespo, u.massHoraire " +
                                        "FROM UV u, Formateur f " +
                                        "WHERE (u.numEnsei = f.numFormateur OR u.numRespo = f.numFormateur) " +
                                        "AND f.numFormateur = @numf";
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@numf", tbsearch.Text);

                DataSet ds = new DataSet( );
                SqlDataAdapter adapter = new SqlDataAdapter(commander);
                adapter.Fill(ds, "tFormateur");
                dgv1.DataSource = null;
                dgv1.DataSource = ds.Tables["tFormateur"];

                CountChapitres(lbl_nb_chapitres);

                commander.Connection.Close( );
            }
        }

        private void btnetat_Click(object sender, EventArgs e)
        {

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            commander.CommandText = "UPDATE Formateur " +
                                    "SET nomFormateur = @nomf, prenFormateur = @prenf, " +
                                    "    teleFormateur = @telef, AddrFormateur = @addrf, " +
                                    "    typeFormateur = @typef " +
                                    "WHERE numFormateur = @numf";
            commander.Parameters.AddWithValue("@nomf", tbname.Text);
            commander.Parameters.AddWithValue("@prenf", tbpren.Text);
            commander.Parameters.AddWithValue("@telef", tbtele.Text);
            commander.Parameters.AddWithValue("@addrf", tbaddr.Text);
            commander.Parameters.AddWithValue("@typef", chboxtype.Text);
            commander.Parameters.AddWithValue("@numf", tbsearch.Text);

            commander.Connection.Open( );
            commander.ExecuteNonQuery( );
            commander.Connection.Close( );
        }



    }
}
