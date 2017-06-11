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
    public partial class GestionTarifParking: Form
    {
        private SqlCommand commander = new SqlCommand( );
        private SqlDataReader reader = null;
        private int count = 0, current_index = 0;

        public GestionTarifParking()
        {
            InitializeComponent( );
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2017_v11;" +
                                                     "Integrated Security = True;");
        }

        private void GestionTarifParking_Load(object sender, EventArgs e)
        {
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM TypeTarif";
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                comboType.Items.Add(reader["idType"].ToString( ));
            }
            reader.Close( );

            comboType.Text = comboType.Items[0].ToString( );
            commander.CommandText = "Select * from Parking";
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                comboPark.Items.Add(reader["idPark"].ToString( ));
            }
            reader.Close( );

            comboPark.Text = comboPark.Items[0].ToString( );
            commander.Connection.Close( );

            BindDGV(dgv1);
        }

        private bool IsValidInput()
        {
            return new Regex("^[0-9]*([\\.,]([0-9]*))?$").Match(tbprix.Text).Success;
        }
        private void BindDGV(DataGridView dgv)
        {
            List<object> view = new List<object>( );

            commander.CommandText = "SELECT * FROM TarifParking";
            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            count = 0;
            while (reader.Read( )) {
                view.Add(new {
                    idPark = reader["idPark"].ToString( ),
                    idType = reader["idType"].ToString( ),
                    Prix = reader["prix"].ToString( )
                });
                ++count;
            }
            reader.Close( );
            commander.Connection.Close( );

            dgv.DataSource = null;
            dgv.DataSource = view;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (IsValidInput( )) {
                commander.CommandText = "INSERT INTO TarifParking " +
                                        "VALUES(@idt, @p)";
                //commander.Parameters.AddWithValue("@idp", comboPark.Text);
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@idt", comboType.Text);
                commander.Parameters.AddWithValue("@p", tbprix.Text);

                try {
                    commander.Connection.Open( );
                    commander.ExecuteNonQuery( );
                    commander.Connection.Close( );
                    BindDGV(dgv1);
                } catch (SqlException sexp) {
                    MessageBox.Show(sexp.ToString( ));
                }
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (IsValidInput( )) {
                commander.CommandText = "UPDATE TarifParking SET idType = @idt, prix = @p WHERE idPark = @idp";
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@p", tbprix.Text);
                commander.Parameters.AddWithValue("@idt", comboType.Text);
                commander.Parameters.AddWithValue("@idp", comboPark.Text);
                try {
                    commander.Connection.Open( );
                    commander.ExecuteNonQuery( );
                    commander.Connection.Close( );
                    BindDGV(dgv1);
                } catch (SqlException sexp) {
                    MessageBox.Show(sexp.ToString( ));
                }
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.SelectedCells.Count != 0) {
                DataGridViewRow row = dgv1.Rows[dgv1.SelectedCells[0].RowIndex];

                tbprix.Text = row.Cells["prix"].Value.ToString( );
                comboType.Text = row.Cells["idType"].Value.ToString( );
                comboPark.Text = row.Cells["idPark"].Value.ToString( );
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("ARE YOU SURE?", "Confirm", MessageBoxButtons.YesNo);

            if (dlg == System.Windows.Forms.DialogResult.Yes) {
                commander.CommandText = "DELETE FROM TarifParking WHERE idPark = @idp";
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@idp", comboPark.Text);
                try {
                    commander.Connection.Open( );
                    commander.ExecuteNonQuery( );
                    commander.Connection.Close( );
                    BindDGV(dgv1);
                } catch (SqlException sexp) {
                    MessageBox.Show(sexp.ToString( ));
                }
            }

        }
        private void Nav(int index)
        {
            commander.CommandText = "SELECT * FROM TarifParking";
            commander.Connection.Open( );
            reader = commander.ExecuteReader( );

            int i = 0;
            while (reader.Read( )) {
                if (index == i) break;
                else ++i;
            }

            tbprix.Text = reader["prix"].ToString( );
            comboType.Text = reader["idType"].ToString( );
            comboPark.Text = reader["idPark"].ToString( );

            reader.Close( );
            commander.Connection.Close( );
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Nav(current_index = 0);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Nav(current_index = (count - 1));
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (current_index - 1 >= 0) {
                Nav(--current_index);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (current_index + 1 < count) {
                Nav(++current_index);
            }
        }
    }
}
