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
    public partial class FormConsultation: Form
    {
        SqlConnection connection = new SqlConnection("Server = WINXP\\SQLEXPRESS;" +
                                                     "Initial catalog = ff2016;" +
                                                     "Integrated security = yes;");
        SqlCommand command = new SqlCommand( );
        SqlDataReader reader = null;

        public FormConsultation()
        {
            InitializeComponent( );
            command.Connection = connection;
        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            connection.Open( );

            #region Fill the Categories ListView
            command.CommandText = "SELECT nomcateg FROM Categorie";
            reader = command.ExecuteReader( );

            while (reader.Read( ))
                listview_categ.Items.Add(reader["nomcateg"].ToString( ));
            reader.Close( );
            #endregion

            connection.Close( );
        }

        private void listview_categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            // break if there is no selected elements, yet!
            // i don't know why but i guess it has something
            // to do with a .net framework. 
            // don't believe me, comment this line!
            if (listview_categ.SelectedItems.Count == 0) return;
            
            string nomcateg = listview_categ.SelectedItems[0].Text;
            List<object> view = new List<object>( );

            connection.Open( );

            #region Fill the `view`
            command.CommandText = "SELECT c.nomCamp, SUM(pp.montantPart) AS Montant, " +
                                         "DAY(GETDATE() - c.dateDernierePart) AS Jours " +
                                  "FROM Campagne c, Participation pp, Categorie cc " +
                                  "WHERE c.idCamp = pp.idComp AND " +
                                        "c.idCategorie = cc.idcateg AND " +
                                        "cc.nomcateg = @categ " +
                                  "GROUP BY c.nomCamp, dateDernierePart"; /* i don't know why it does not
                                                                           * work if i remove this line! */

            #region command parameters
            command.Parameters.Clear( );
            command.Parameters.AddWithValue("@categ", nomcateg);
            #endregion

            reader = command.ExecuteReader( );
            while (reader.Read( )) {
                view.Add(new {
                    Nom_Campagne = reader["nomCamp"].ToString( ),
                    Montant_Total = reader["Montant"].ToString( ),
                    Jours_Avant_La_Fin = reader["Jours"].ToString( )
                });
            }
            reader.Close( );
            #endregion

            dgv_comp.DataSource = view;

            connection.Close( );

        }
    }
}