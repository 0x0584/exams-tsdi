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
    public partial class ListUtils: Form
    {
        private SqlCommand commander = new SqlCommand( );

        public ListUtils()
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial Catalog = ff2017_v11;" +
                                                     "Integrated Security = True;");
            commander.CommandText = "SELECT u.nomUtil, u.prenUtil FROM Utilisateur u, Stationnement s " +
                                    "WHERE s.dateStat = @d AND " +
                                    "      (SELECT COUNT(s.idUtil) " +
                                    "       FROM Utilisateur u, Stationnement s " +
                                    "       WHERE s.idUtil = u.idUtil) >= 10";
            InitializeComponent( );
        }

        private void ListUtils_Load(object sender, EventArgs e)
        {
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@d", DateTime.Parse(dpicker.Value.ToShortDateString( )));

            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataSet ds = new DataSet( );
            adapter.Fill(ds, "tUtils");
            dgv1.DataSource = null;
            dgv1.DataSource = ds.Tables["tUtils"];
        }

        private void dpicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@d", DateTime.Parse(dpicker.Value.ToShortDateString( )));

            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataSet ds = new DataSet("Utils");
            adapter.Fill(ds, "tUtils");
            ds.Tables["tUtils"].WriteXmlSchema("C:\\Utils.xsd");
            ds.Tables["tUtils"].WriteXml("C:\\Utils.xml");
        }

        private void btnetat_Click(object sender, EventArgs e)
        {
            Imprimer imp = new Imprimer( );

            imp.ShowDialog( );

            if (!(imp.IsDisposed)) {
                imp.Dispose( );
                imp.Close( );
            }

        }
    }
}
