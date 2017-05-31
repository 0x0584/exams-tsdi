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
    public partial class FormListComp: Form
    {
        SqlConnection connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial catalog = ff2016 ;" +
                                                     "Integrated security = yes; ");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader = null;

        public FormListComp()
        {
            InitializeComponent( );
            command.Connection = connection;
        }

        private void FormListComp_Load(object sender, EventArgs e)
        {
            List<object> view = new List<object>( );

            connection.Open( );

            #region Setup the `reader`
            command.CommandText = "SELECT c.nomCamp, c.dateCreation, " +
                                        "SUM(p.montantPart) AS 'MontantVoulu' " +
                                  "FROM Participation p, Campagne c " +
                                  "WHERE YEAR(p.datePartt) = 2015 AND " + 
                                        "c.idCamp = p.idComp " +
                                  "GROUP BY c.nomCamp, c.dateCreation";

            reader = command.ExecuteReader( );

            while (reader.Read( )) {
                view.Add(new {
                    NomComp = reader["nomCamp"].ToString( ),
                    DateCreation = reader["dateCreation"].ToString(),
                    MontantVoulu = reader["MontantVoulu"].ToString()
                });
            }
            reader.Close( );
            #endregion

            dataGridView1.DataSource = view;
            connection.Close( );
        }
    }
}
