using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class ListCampagnes: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                            "Initial Catalog = ff2016; " +
                                            "Integrated security = yes;");
            if (!IsPostBack) {
                commander.Connection.Open( );

                #region Fill the DDList
                commander.CommandText = "SELECT nomcateg FROM Categorie";
                reader = commander.ExecuteReader( );
                while (reader.Read( )) {
                    ddlist.Items.Add(reader["nomcateg"].ToString( ));
                }
                reader.Close( );
                #endregion

                commander.Connection.Close( );
                btnrefresh_Click(sender, e);
            }
        }

        protected void btnrefresh_Click(object sender, EventArgs e)
        {
            List<object> view = new List<object>( );

            commander.Connection.Open( );

            #region Setup the `view` list
            #region Setup teh commander
            commander.CommandText = "SELECT idCamp, nomCamp, montantCamp, nomBeneficiare " +
                                    "FROM Campagne c, Categorie cc " +
                                    "WHERE cc.idcateg = c.idCategorie AND cc.nomcateg = @CategName";
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@CategName", ddlist.Text);
            #endregion

            reader = commander.ExecuteReader( );

            while (reader.Read( )) {
                view.Add(new {
                    ID_Camp = reader["idCamp"].ToString( ),
                    Nom_Camp = reader["nomCamp"].ToString( ),
                    Montant_Camp = reader["montantCamp"].ToString(),
                    Nom_beneficiare = reader["nomBeneficiare"].ToString( )
                });
            }
            reader.Close( );
            #endregion

            GridView1.DataSource = view;
            GridView1.DataBind( );

            commander.Connection.Close( );
        }
    }
}