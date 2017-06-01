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
            bool isclosed = (commander.Connection.State == ConnectionState.Closed);

            if (isclosed) commander.Connection.Open( );

            commander.CommandText = "SELECT * FROM Formateur";
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataSet ds = new DataSet( );
            adapter.Fill(ds, "tFormateur");
            dgv.DataSource = ds.Tables["tFormateur"];

            commander.CommandText = "SELECT COUNT(*) FROM Formateur";
            count_f = (int)commander.ExecuteScalar( );

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            commander.CommandText = "INSERT INTO Formateur " +
                                    "VALUES (@numf, @nomf, @prenf, @telef, @addrf, @typef)";

            #region Setup Parameters
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@numf", ++lastnum);
            commander.Parameters.AddWithValue("@nomf", tbname.Text);
            commander.Parameters.AddWithValue("@prenf", tbpren.Text);
            commander.Parameters.AddWithValue("@telef", tbtele.Text);
            commander.Parameters.AddWithValue("@addrf", tbaddr.Text);
            commander.Parameters.AddWithValue("@typef", chboxtype.Text);
            #endregion

            commander.Connection.Open( );
            commander.ExecuteNonQuery( );

            Bind(dgv1);

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
    }
}
