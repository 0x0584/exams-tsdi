using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace App
{
    public partial class Form1: Form
    {
        SqlCommand commander = new SqlCommand( );
        List<SqlCommand> list_commaders = new List<SqlCommand>( );
        SqlDataReader reader = null;
        int lastid = 0;
        int count;

        public Form1()
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2015_v11;" +
                                                     "Integrated Security = TRUE;");
            InitializeComponent( );
            label5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            commander.Connection.Open( );

            #region Fill The combobox
            commander.CommandText = "SELECT * FROM Ville";
            reader = commander.ExecuteReader( );

            while (reader.Read( )) {
                string item = string.Format("({0}) {1}",
                                                reader["code_ville"].ToString( ),
                                                reader["nom_ville"].ToString( ));
                comboville.Items.Add(item);
            }
            reader.Close( );
            #endregion

            commander.CommandText = "SELECT TOP 1 code_quartier FROM Quartier " +
                                    "ORDER BY code_quartier DESC";
            lastid = (int)commander.ExecuteScalar( );

            commander.Connection.Close( );

            comboville.Text = comboville.Items[0].ToString( );

            RefreshForm( );
        }

        private void RefreshForm()
        {
            List<object> view = new List<object>( );

            commander.CommandText = "SELECT * FROM Quartier";
            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                object o = new {
                    code_quartier = reader["code_quartier"].ToString( ),
                    nom_quartier = reader["nom_quartier"].ToString( ),
                    population_quartier = reader["population_quartier"].ToString( ),
                    code_ville = reader["code_ville"].ToString( ),
                    total_quartier = reader["total_quartier"].ToString( )
                };
                view.Add(o);
            }
            reader.Close( );
            commander.Connection.Close( );
            dgv1.DataSource = null;
            dgv1.DataSource = view;

            tbnom.Text = tbpop.Text = "";
            tbtotal.Text = "0";
        }

        private bool IsValidateInput()
        {
            Regex reg = new Regex("^[0-9]*(\\.?[0-9]+)?$");
            Match match;
            bool isvalid;

            isvalid = (match = reg.Match(tbtotal.Text)).Success;
            isvalid &= (match = reg.Match(tbpop.Text)).Success;

            return isvalid;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (IsValidateInput( )) {
                try {
                    SqlCommand foocommander = new SqlCommand( );

                    foocommander.Connection = commander.Connection;
                    foocommander.CommandText = "INSERT INTO Quartier " +
                                            "VALUES(@codeQ, @nomQ, @popQ, @codeV, @totalQ)";
                    #region Parameters
                    foocommander.Parameters.AddWithValue("@codeQ", ++lastid);
                    foocommander.Parameters.AddWithValue("@nomQ", tbnom.Text);
                    foocommander.Parameters.AddWithValue("@popQ", tbpop.Text);
                    foocommander.Parameters.AddWithValue("@codeV", comboville.Text.Split(new char[] { '(', ')' })[1]);
                    foocommander.Parameters.AddWithValue("@totalQ", tbtotal.Text);
                    #endregion
                    label5.Text = (++count).ToString( );
                    list_commaders.Add(foocommander);

                } catch (SqlException sexp) {
                    MessageBox.Show(sexp.ToString( ));
                }
            } else {
                MessageBox.Show("CHECK YOUR INPUT");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            foreach (SqlCommand cmd in list_commaders) {
                cmd.ExecuteNonQuery( );
            }
            label5.Text = "";
            list_commaders.Clear( );
            RefreshForm( );
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Confirm", "ARE YOUR SURE?", MessageBoxButtons.YesNo);
            if (dlg == System.Windows.Forms.DialogResult.Yes) {
                try {
                    commander.CommandText = "DELETE FROM Quartier WHERE code_quartier = @codeQ";
                    string codeQ = dgv1.Rows[dgv1.SelectedCells[0].RowIndex].Cells["code_quartier"].Value.ToString( );
                    commander.Parameters.AddWithValue("@codeQ", codeQ);
                    commander.Connection.Open( );
                    commander.ExecuteNonQuery( );
                    commander.Connection.Close( );
                    RefreshForm( );
                } catch (SqlException sexp) {
                    MessageBox.Show(sexp.ToString( ));
                }
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.SelectedCells.Count != 0) {
                DataGridViewRow row = dgv1.Rows[dgv1.SelectedCells[0].RowIndex];
                tbnom.Text = row.Cells["nom_quartier"].Value.ToString( );
                tbpop.Text = row.Cells["population_quartier"].Value.ToString( );
                tbtotal.Text = row.Cells["total_quartier"].Value.ToString( );
                int combo_index = (int.Parse(row.Cells["code_ville"].Value.ToString( )) - 1);
                comboville.Text = comboville.Items[combo_index].ToString( );
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close( );
        }
    }
}
