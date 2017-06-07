using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class Consultation: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );
        SqlDataReader reader = null;

        protected object BindGridView()
        {
            List<object> view = new List<object>( );
            string id = ddlist.Text.Split(new char[] { '(', ')' })[1]; // <--- ([id_X]) Famille_X
            //        ^^^^
            commander.CommandText = "SELECT * FROM Operation WHERE idFamille = @idf";
            commander.Parameters.AddWithValue("@idf", id);

            commander.Connection.Open( );
            reader = commander.ExecuteReader( );
            while (reader.Read( )) {
                DateTime date = DateTime.Parse(reader["DateCreation"].ToString( ));
                int ndays = int.Parse(reader["datefin"].ToString( ));
                // en cours
                if (DateTime.Today.CompareTo(date.AddDays(ndays)) < 0) {
                    view.Add(new {
                        idOp = reader["idOp"].ToString( ),
                        nomOp = reader["nomOp"].ToString( ),
                        cumulMontant = reader["cumulMontant"].ToString( ),
                        nomBeneficiaire = reader["nomBeneficiare"].ToString( )
                    });
                }
            }
            reader.Close( );
            commander.Connection.Close( );

            return view;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                         "Database = ff2016_v13; " +
                                                         "Integrated Security = YES; ");
            if (IsPostBack) return;

            if (Session["Email"] != null && Session["Type"] != null) {
                #region Retreive the user email
                if (Session["Email"].ToString( ) != "none")
                    lblemail.Text = string.Format("Email: {0}", Session["Email"].ToString( ));
                else lblemail.Text = "Anonyme";
                #endregion

                commander.Connection.Open( );
                commander.CommandText = "SELECT * FROM Famille";
                reader = commander.ExecuteReader( );
                while (reader.Read( )) {
                    ddlist.Items.Add(string.Format("({0}) {1}",
                                     reader[0].ToString( ),
                                     reader[1].ToString( )));
                }
                reader.Close( );
                commander.Connection.Close( );
                gv1.DataSource = BindGridView();
                gv1.DataBind( );
            } else {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnrefresh_Click(object sender, EventArgs e)
        {
            gv1.DataSource = BindGridView( );
            gv1.DataBind( );
        }
    }
}