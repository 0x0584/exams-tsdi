using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SiteWeb
{
    public partial class AddOperation: System.Web.UI.Page
    {
        SqlCommand commander = new SqlCommand( );

        protected void Page_Load(object sender, EventArgs e)
        {
            #region Setup Connection
            commander.Connection = new SqlConnection( );
            commander.Connection.ConnectionString = "Server = WINXP\\SQLEXPRESS;" +
                                                    "Initial Catalog = ff2016_v13;" +
                                                    "Integrated Security = YES;";
            #endregion

            if (Session["Type"] == null ||
                ((IUser.Type)Session["Type"]) != IUser.Type.PLAN)
                Response.Redirect("~/Default.aspx");

            if (IsPostBack) return;

            commander.CommandText = "SELECT * FROM Famille";

            #region Fill ddlist
            commander.Connection.Open( );
            using (var reader = commander.ExecuteReader( )) {
                while (reader.Read( )) {
                    string item = string.Format("({0}) {1}",
                                                reader["idFamille"].ToString( ),
                                                reader["nomFamille"].ToString( ));
                    ddlistfamill.Items.Add(item);
                }
                reader.Close( );
            }
            commander.Connection.Close( );
            #endregion
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            commander.Connection.Open( );

            int lastid = 00;
            string idfamille = ddlistfamill.Text.Split(new char[] { '(', ')' })[1];

            #region get `lastid`
            commander.CommandText = "SELECT TOP 1 idOp FROM Operation ORDER BY idOp DESC";
            lastid = (int)commander.ExecuteScalar( );
            #endregion

            commander.CommandText = "INSERT INTO Operation " +
                                    "VALUES(@idop, @nomop, @descri, " +
                                    "       @datec, @datef, @montant, " +
                                    "       @nomb, @prenb, @idf, @idplan," +
                                    "       @cum)";
            #region Setup Parameters
            commander.Parameters.Clear( );
            commander.Parameters.AddWithValue("@nomop", tbnomop.Text);
            commander.Parameters.AddWithValue("@descri", tbdescri.Text);
            commander.Parameters.AddWithValue("@datef", tbdateFin.Text);
            commander.Parameters.AddWithValue("@montant", tbmontantOp.Text);
            commander.Parameters.AddWithValue("@nomb", tbnomBene.Text);
            commander.Parameters.AddWithValue("@prenb", tbprenBene.Text);
            commander.Parameters.AddWithValue("@idf", idfamille);
            commander.Parameters.AddWithValue("@cum", tbcumul.Text);
            //
            commander.Parameters.AddWithValue("@datec", DateTime.Today.ToShortDateString( ));
            commander.Parameters.AddWithValue("@idplan", Session["IdPlan"].ToString( )); // Default.aspx (Line 79)
            commander.Parameters.AddWithValue("@idop", ++lastid);
            #endregion

            commander.ExecuteNonQuery( );
            commander.Connection.Close( );

            Response.Redirect("~/Consultation.aspx");
        }
        
    }
    
}