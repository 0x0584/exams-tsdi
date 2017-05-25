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
    public partial class Organisateur: Form
    {
        SqlConnection connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial catalog = ff2016;" +
                                                     "Integrated security = yes;");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader;

        DataSet ds = new DataSet( );
        SqlDataAdapter adapter;

        int currentindex = 0;
        public Organisateur()
        {
            InitializeComponent( );
        }

        private void Organisateur_Load(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Organisateur";
            adapter = new SqlDataAdapter(command);
            ds = new DataSet( );
            try {
                //connection.Open( );
                adapter.Fill(ds, "tOrganisateur");
                //adapter.Update(ds, "tOrganisateur");
                dataGridView1.DataSource = ds.Tables["tOrganisateur"];

                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (row.Cells[0].Value != null)
                        combox_ids.Items.Add(row.Cells[0].Value.ToString( ));

                combox_ids.Text = combox_ids.Items[0].ToString( );
                //connection.Close( );
            } catch (SqlException) {
                throw;
            }
        }

        #region Methodes
        private void Bind()
        {
            command.CommandText = "SELECT * FROM Organisateur";
            adapter = new SqlDataAdapter(command);

            ds = new DataSet( );

            try {
                //ds.Tables["tOrganisateur"].Clear( );
                //connection.Open( );
                adapter.Fill(ds, "tOrganisateur");
                //adapter.Update(ds, "tOrganisateur");
                dataGridView1.DataSource = ds.Tables["tOrganisateur"];

                combox_ids.Items.Clear( );
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (row.Cells[0].Value != null)
                        combox_ids.Items.Add(row.Cells[0].Value.ToString( ));

                //connection.Close( );
            } catch (SqlException) {
                throw;
            }
        }

        private bool Verify_Input()
        {
            // textfields are not empty and the password 
            // has more-than-or-equal 6 characters
            bool isvalid = false;

            #region Password verification
            if (!(isvalid = (tbpasswd.Text.Length >= 6)))
                label1.Text = "password must has more than 6 characters";
            else label5.Text = string.Empty;

            #endregion

            #region Email Verification
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(tbemail.Text);

            if (!(isvalid &= match.Success))
                label6.Text = "incorrect";
            else label6.Text = string.Empty;
            #endregion

            #region Required feilds verification
            isvalid &= (tbemail.Text != "" ||
                       tbnom.Text != "" ||
                       tbpasswd.Text != "" ||
                       tbpren.Text != "");
            #endregion

            return isvalid;
        }

        private void FindElement(int id)
        {
            command.CommandText = "SELECT * FROM Organisateur WHERE idOrg = @id";
            command.Parameters.Clear( );
            command.Parameters.AddWithValue("@id", id);

            connection.Open( );
            while ((reader = command.ExecuteReader( )).Read( )) {
                tbemail.Text = reader["emailOrg"].ToString( );
                tbnom.Text = reader["nomOrg"].ToString( );
                tbpasswd.Text = reader["passOrg"].ToString( );
                tbpren.Text = reader["prenomOrg"].ToString( );
                break;
            }
            reader.Close( );
            connection.Close( );
        }
        #endregion

        #region CRUD
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Verify_Input( )) {
                try {
                    connection.Open( );
                    int lastid = 0;

                    #region Get the `lastid`
                    command.CommandText = "SELECT idOrg FROM Organisateur";
                    reader = command.ExecuteReader( );
                    // at the end of this loop, `lastid` would have 
                    // the last readed-value from the reader
                    while (reader.Read( ))
                        lastid = int.Parse(reader["idOrg"].ToString( ));
                    reader.Close( );
                    #endregion

                    command.CommandText = "INSERT INTO Organisateur(idOrg, nomOrg, prenomOrg, emailOrg, passOrg) " +
                                          "VALUES(@id, @nom, @pren, @email, @pass)";

                    #region Setup command parameters
                    command.Parameters.Clear( );
                    command.Parameters.AddWithValue("@id", ++lastid);
                    command.Parameters.AddWithValue("@nom", tbnom.Text);
                    command.Parameters.AddWithValue("@pren", tbpren.Text);
                    command.Parameters.AddWithValue("@email", tbemail.Text);
                    command.Parameters.AddWithValue("pass", tbpasswd.Text);
                    #endregion

                    command.ExecuteNonQuery( );

                    Bind( );
                    connection.Close( );
                } catch { MessageBox.Show("CONNECTION_ERR"); }
            } else {
                MessageBox.Show("FILL ALL THE FEILDS");
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (Verify_Input( )) {
                try {
                    connection.Open( );

                    #region Get the id
                    int index = int.Parse(dataGridView1.SelectedCells[0].Value.ToString( ));
                    DataGridViewRow row = dataGridView1.Rows[index];
                    id = int.Parse(row.Cells["idOrg"].Value.ToString( ));
                    #endregion

                    command.CommandText = "UPDATE Organisateur " +
                                          "SET nomOrg = @nom, prenomOrg = @pren, " +
                                          "emailOrg = @email, passOrg = @passwd " +
                            string.Format("WHERE idOrg = {0}", id);

                    #region Setup Parameters
                    command.Parameters.Clear( );
                    command.Parameters.AddWithValue("@nom", tbnom.Text);
                    command.Parameters.AddWithValue("@pren", tbnom.Text);
                    command.Parameters.AddWithValue("@email", tbnom.Text);
                    command.Parameters.AddWithValue("@passwd", tbnom.Text);
                    #endregion

                    command.ExecuteNonQuery( );
                    connection.Close( );
                } catch { MessageBox.Show("CONNECTION_ERR"); }
            } else {
                MessageBox.Show("FILL ALL THE FEILDS");
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            int rowindex;

            if ((rowindex = dataGridView1.SelectedCells[0].RowIndex) >= 0) {
                DataGridViewRow row = dataGridView1.Rows[rowindex];
                int index = int.Parse(row.Cells[0].Value.ToString( ));

                try {
                    connection.Open( );
                    command.CommandText = string.Format("DELETE FROM Organisateur " +
                                                        "WHERE idOrg = {0}", index);
                    command.ExecuteNonQuery( );
                    Bind( );
                    connection.Close( );
                } catch { MessageBox.Show(string.Format("idOrg:{0} IS FK", index)); }

            }
        }
        #endregion

        #region Events
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            if ((index = dataGridView1.SelectedCells[0].RowIndex) >= 0) {
                DataGridViewRow row = dataGridView1.Rows[index];

                tbemail.Text = row.Cells["emailOrg"].Value.ToString( );
                tbnom.Text = row.Cells["nomOrg"].Value.ToString( );
                tbpren.Text = row.Cells["prenomOrg"].Value.ToString( );
                tbpasswd.Text = row.Cells["passOrg"].Value.ToString( );
            }
        }

        private void combox_ids_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = combox_ids.SelectedItem;

            if (selected != null) {

                foreach (DataGridViewRow row in dataGridView1.Rows) {

                    object cell = row.Cells[0].Value;

                    if (cell != null && cell.ToString( ) == selected.ToString( )) {
                        tbemail.Text = row.Cells["emailOrg"].Value.ToString( );
                        tbnom.Text = row.Cells["nomOrg"].Value.ToString( );
                        tbpren.Text = row.Cells["prenomOrg"].Value.ToString( );
                        tbpasswd.Text = row.Cells["passOrg"].Value.ToString( );

                        break;
                    }

                }
            }

        }
        #endregion

        #region Navigation
        private void btn_first_Click(object sender, EventArgs e)
        {
            int id = int.Parse(combox_ids.Items[(currentindex = 0)].ToString( ));
            combox_ids.Text = id.ToString( );
            FindElement(id);

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int count = currentindex = combox_ids.Items.Count - 1;
            int id = int.Parse(combox_ids.Items[count].ToString( ));
            combox_ids.Text = id.ToString( );
            FindElement( id );
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // pass the array boundries
            if ((currentindex + 1) == combox_ids.Items.Count) return;

            int id = int.Parse(combox_ids.Items[++currentindex].ToString( ));
            combox_ids.Text = id.ToString( );
            FindElement(id);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if ((currentindex - 1) < 0) return;

            int id = int.Parse(combox_ids.Items[--currentindex].ToString( ));
            combox_ids.Text = id.ToString( );
            FindElement(id);
        }
        #endregion
    }
}
