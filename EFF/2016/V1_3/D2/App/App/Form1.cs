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
        SqlDataReader reader = null;
        private int lastid, // check Constructure
            currentid,      // check dgv1_CellClick()
            navindex,       // check Navigation()
            count;          // check RefreshForm()
        public Form1()
        {
            currentid = navindex = 0;
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS ; " +
                                                      "Initial catalog = ff2016_v13;" +
                                                      "Integrated Security = yes;");
            commander.Connection.Open( );
            commander.CommandText = "SELECT TOP 1 p.idPlan FROM Planificateur p ORDER BY p.idPlan DESC";
            lastid = (int)commander.ExecuteScalar( );
            commander.Connection.Close( );
            InitializeComponent( );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm( );
        }

        private void RefreshForm()
        {
            commander.CommandText = "SELECT COUNT(*) FROM Planificateur";
            commander.Connection.Open( );
            count = (int)commander.ExecuteScalar( );
            commander.Connection.Close( );
            commander.CommandText = "SELECT * FROM Planificateur";

            DataSet ds = new DataSet( );
            SqlDataAdapter adapter = new SqlDataAdapter(commander);

            adapter.Fill(ds, "tPlanificateur");

            dgv1.DataSource = null;
            dgv1.DataSource = ds.Tables["tPlanificateur"];
        }
        private bool VerifyInput()
        {
            bool isvalid = (tbemail.Text != "" || tbname.Text != "" ||
                            tbpasswd.Text != "" || tbpren.Text != "");

            #region Required feilds
            if (!(isvalid)) {
                lberremail.Text = "FILL ALL REQUIRED FEILDS";
                return isvalid;
            } else lberremail.Text = "";
            #endregion

            #region Password
            if (!(isvalid &= tbpasswd.Text.Length >= 6)) {
                lberrpasswd.Text = "PASSWORD MUST HAS MORE THAN 6 CHARACTERS";
                return isvalid;
            } else lberrpasswd.Text = "";
            #endregion

            #region Email
            Regex regex = new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)(\\.(([\\w]{2,3}))+)$");
            Match match = regex.Match(tbemail.Text);

            if (!(isvalid &= match.Success)) {
                lberremail.Text = "CHECK YOUR EMAIL";
                return isvalid;
            } else lberremail.Text = "";
            #endregion

            return isvalid;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bool isvalid = VerifyInput( );

            if (isvalid) {
                commander.CommandText = "INSERT INTO Planificateur " +
                                        "VALUES (@idp, @nomp, @prenp, @emailp, @passwdp)";
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@idp", ++lastid);
                commander.Parameters.AddWithValue("@nomp", tbname.Text);
                commander.Parameters.AddWithValue("@prenp", tbpren.Text);
                commander.Parameters.AddWithValue("@emailp", tbemail.Text);
                commander.Parameters.AddWithValue("@passwdp", tbpasswd.Text);
                try {

                    commander.Connection.Open( );
                    commander.ExecuteNonQuery( );
                    RefreshForm( );
                    commander.Connection.Close( );

                } catch (SqlException sexp) {
                    MessageBox.Show(sexp.ToString( ));
                }
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            bool isvalid = VerifyInput( );

            if (isvalid) {

                commander.CommandText = "UPDATE Planificateur " +
                                        "SET nomPlan = @nomp, prenomPlan = @prenp, " +
                                        "    emailPlan = @emailp, passPlan = @passwdp " +
                                        "WHERE idPlan = @idp";
                commander.Parameters.Clear( );
                commander.Parameters.AddWithValue("@idp", currentid);
                commander.Parameters.AddWithValue("@nomp", tbname.Text);
                commander.Parameters.AddWithValue("@prenp", tbpren.Text);
                commander.Parameters.AddWithValue("@emailp", tbemail.Text);
                commander.Parameters.AddWithValue("@passwdp", tbpasswd.Text);

                try {
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
                int rowindex = dgv1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgv1.Rows[rowindex];
                for (int i = 0; i < row.Cells.Count; ++i)
                    dgv1.Rows[rowindex].Cells[i].Selected = true;

                tbname.Text = row.Cells["nomPlan"].Value.ToString( );
                tbpren.Text = row.Cells["prenomPlan"].Value.ToString( );
                tbemail.Text = row.Cells["emailPlan"].Value.ToString( );
                tbpasswd.Text = row.Cells["passPlan"].Value.ToString( );
                currentid = int.Parse(row.Cells["idPlan"].Value.ToString( ));
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            commander.CommandText = "DELETE FROM Planificateur WHERE idPlan = @idp";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@idp", currentid);

            try {
                commander.Connection.Open( );
                commander.ExecuteNonQuery( );
                commander.Connection.Close( );
                RefreshForm( );
            } catch (SqlException sexp) {
                MessageBox.Show(sexp.ToString( ));
            }
        }

        private void Navigation(int index)
        {
            commander.CommandText = "SELECT * FROM Planificateur";
            commander.Connection.Open( );
            reader = commander.ExecuteReader( );

            int i = 0;
            while (reader.Read( )) {
                if (i == index) break;
                else ++i;
            }

            tbname.Text = reader["nomPlan"].ToString( );
            tbpren.Text = reader["prenomPlan"].ToString( );
            tbemail.Text = reader["emailPlan"].ToString( );
            tbpasswd.Text = reader["passPlan"].ToString( );

            reader.Close( );
            commander.Connection.Close( );
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Navigation(navindex = 0);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Navigation((navindex = (count - 1)));
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (navindex - 1 >= 0) Navigation(--navindex);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (navindex + 1 < count) Navigation(++navindex);
        }
    }
}
