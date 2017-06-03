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
    public partial class Form1: Form
    {
        private SqlCommand commander = new SqlCommand( );
        // this is for the `add` and `save` buttons.
        // i found that i did t the wrong way.
        private List<SqlCommand> list_commanders = new List<SqlCommand>( );
        private SqlDataReader reader = null;

        private int lastnum,
                    currentindex,
                    count_f;

        public Form1()
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2016_v33;" +
                                                     "Integrated Security = yes;");
            InitializeComponent( );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblstate.Text = "";
            commander.Connection.Open( );
            #region Get `lastnum`
            commander.CommandText = "SELECT TOP 1 f.numFormateur " +
                                    "FROM Formateur f " +
                                    "ORDER BY f.numFormateur DESC";

            lastnum = int.Parse(commander.ExecuteScalar( ).ToString( ));
            #endregion

            chboxtype.Text = chboxtype.Items[0].ToString( );
            commander.Connection.Close( );
            Bind(dgv1);
        }

        private void Bind(DataGridView dgv)
        {
            List<object> view = new List<object>( );

            bool isclosed = (commander.Connection.State == ConnectionState.Closed);

            if (isclosed) commander.Connection.Open( );

            commander.CommandText = "SELECT * FROM Formateur";
            reader = commander.ExecuteReader( );

            while (reader.Read( )) {
                ++count_f;
                //
                view.Add(new {
                    numFormateur = reader["numFormateur"].ToString( ),
                    nomFormateur = reader["nomFormateur"].ToString( ),
                    prenFormateur = reader["prenFormateur"].ToString( ),
                    teleFormateur = reader["teleFormateur"].ToString( ),
                    addrFormateur = reader["AddrFormateur"].ToString( ),
                    typeFormateur = reader["typeFormateur"].ToString( )
                });
            }

            dgv1.DataSource = view;
            if (isclosed) commander.Connection.Close( );
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbname.Text = tbaddr.Text = tbpren.Text = tbtele.Text = "";
            chboxtype.Text = chboxtype.Items[0].ToString( );
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose( );
            this.Close( );
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Bind(dgv1);
        }

        #region CRUD
        private void btnadd_Click(object sender, EventArgs e)
        {
            // [create a commander with the custom parameters]
            //                    vv
            if (tbname.Text != string.Empty &&
                tbpren.Text != string.Empty &&
                tbtele.Text != string.Empty) {

                string query = "INSERT INTO Formateur " +
                               "VALUES (@numf, @nomf, @prenf, @telef, @addrf, @typef)";

                SqlCommand foocommander = new SqlCommand(query, commander.Connection);

                #region Setup Parameters
                foocommander.Parameters.AddWithValue("@numf", ++lastnum);
                foocommander.Parameters.AddWithValue("@nomf", tbname.Text);
                foocommander.Parameters.AddWithValue("@prenf", tbpren.Text);
                foocommander.Parameters.AddWithValue("@telef", tbtele.Text);
                foocommander.Parameters.AddWithValue("@addrf", tbaddr.Text);
                foocommander.Parameters.AddWithValue("@typef", chboxtype.Text);
                #endregion

                #region Update dgv
                List<object> view = (List<object>)dgv1.DataSource;

                view.Add(new {
                    numFormateur = lastnum.ToString(),
                    nomFormateur = tbname.Text,
                    prenFormateur = tbpren.Text,
                    teleFormateur = tbtele.Text,
                    addrFormateur = tbaddr.Text,
                    typeFormateur = chboxtype.Text
                });
                
                dgv1.DataSource = null; // this is fucking helarious! (stack it!)
                dgv1.DataSource = view;
                #endregion 

                list_commanders.Add(foocommander);
                lblstate.Text = "CHANGED!";
            } else {
                MessageBox.Show("FILL ALL THE REQUIRED-FEILDS (RED)!");
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            commander.Connection.Open( );

            foreach (SqlCommand cmd in list_commanders) {
                cmd.ExecuteNonQuery( );
            }

            list_commanders.Clear( ); // clear the list
            lblstate.Text = "";
            commander.Connection.Close( );
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            int numformateur = 0;

            #region Get `numFormateur`
            int index = dgv1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv1.Rows[index];
            numformateur = int.Parse(row.Cells["numFormateur"].Value.ToString( ));
            #endregion

            commander.CommandText = "UPDATE Formateur " +
                                    "SET nomFormateur = @nomf, prenFormateur = @prenf," +
                                    "    teleFormateur = @telef, AddrFormateur = @addrf," +
                                    "    typeFormateur = @typef " +
                                    "WHERE numFormateur = @numf";

            #region Setup Parameters
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@nomf", tbname.Text);
            commander.Parameters.AddWithValue("@prenf", tbpren.Text);
            commander.Parameters.AddWithValue("@telef", tbtele.Text);
            commander.Parameters.AddWithValue("@addrf", tbaddr.Text);
            commander.Parameters.AddWithValue("@typef", chboxtype.Text);
            commander.Parameters.AddWithValue("@numf", numformateur);
            #endregion

            commander.Connection.Open( );
            commander.ExecuteNonQuery( );

            Bind(dgv1);

            commander.Connection.Close( );
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            int numFormateur = 0;

            int index = dgv1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv1.Rows[index];
            numFormateur = int.Parse(row.Cells["numFormateur"].Value.ToString( ));

            commander.CommandText = "DELETE FROM Formateur WHERE numFormateur = @numf";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numf", numFormateur);

            commander.Connection.Open( );

            try {
                commander.ExecuteNonQuery( );
                Bind(dgv1);
            } catch (SqlException sqlexp) {
                MessageBox.Show(sqlexp.ToString( ));
            }
            commander.Connection.Close( );
        }
        #endregion

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            // get a row and then extract the content from the it.
            if ((index = dgv1.SelectedCells[0].RowIndex) >= 0) { // !!
                DataGridViewRow row = dgv1.Rows[index];
                foreach (DataGridViewCell cell in row.Cells) {
                    cell.Selected = true;
                }
                tbname.Text = row.Cells["nomFormateur"].Value.ToString( );
                tbpren.Text = row.Cells["prenFormateur"].Value.ToString( );
                tbtele.Text = row.Cells["teleFormateur"].Value.ToString( );
                tbaddr.Text = row.Cells["AddrFormateur"].Value.ToString( );
                chboxtype.Text = row.Cells["typeFormateur"].Value.ToString( );
            }
        }

        #region Navigation buttons
        private void SetupFeilds(int index)
        {
            commander.Connection.Open( );
            commander.CommandText = "SELECT * FROM Formateur";
            reader = commander.ExecuteReader( );

            int i = 0;
            while (true) {
                reader.Read( );

                if (i == index) break;
                else ++i;
            }

            tbname.Text = reader["nomFormateur"].ToString( );
            tbpren.Text = reader["prenFormateur"].ToString( );
            tbtele.Text = reader["teleFormateur"].ToString( );
            tbaddr.Text = reader["AddrFormateur"].ToString( );
            chboxtype.Text = reader["typeFormateur"].ToString( );

            reader.Close( );
            commander.Connection.Close( );
        }

        private void nextf(object sender, EventArgs e)
        {
            if ((currentindex + 1) <= (count_f - 1)) {
                SetupFeilds((currentindex += 1));
            }
        }

        private void lastf(object sender, EventArgs e)
        {
            SetupFeilds((currentindex = count_f - 1));
        }

        private void firstf(object sender, EventArgs e)
        {
            SetupFeilds((currentindex = 0));
        }

        private void prevf(object sender, EventArgs e)
        {
            if ((currentindex - 1) >= 0) {
                SetupFeilds((currentindex -= 1));
            }
        }
        #endregion



    }
}
