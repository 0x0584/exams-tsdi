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
        public SearchFormateur()
        {
            InitializeComponent( );
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                DataSet ds = new DataSet( );
                SqlCommand commander = new SqlCommand( );

                #region setup commander
                commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                         "Initial Catalog = ff2016_v33; " +
                                                         "Integrated Security = yes;");
                commander.CommandText = "SELECT * FROM Formateur WHERE numFormateur = @numf";
                commander.Parameters.AddWithValue("@numf", textBox1.Text);
                #endregion
                try {

                    SqlDataAdapter adapter = new SqlDataAdapter(commander);
                    adapter.Fill(ds, "tFormateur");

                } catch (Exception) {
                    MessageBox.Show(e.ToString());
                }
                dgv1.DataSource = null;
                dgv1.DataSource = ds.Tables["tFormateur"];
            }
        }


    }
}
