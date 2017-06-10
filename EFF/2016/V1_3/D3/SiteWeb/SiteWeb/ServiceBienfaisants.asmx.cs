using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace SiteWeb
{
    /// <summary>
    /// Description résumée de Bienfaisants
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Bienfaisants: System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int nb_Bienfaisants()
        {
            SqlCommand commander = new SqlCommand( );
            commander.Connection = new SqlConnection("Server = WINXP\\SQLEXPRESS; " +
                                                     "Initial Catalog = ff2016_v13; " +
                                                     "Integrated Security = TRUE;");
            commander.CommandType = System.Data.CommandType.StoredProcedure;
            commander.CommandText = "NB_BIENFAISANTS";
            commander.Connection.Open();
            int nb = (int)commander.ExecuteScalar( );
            commander.Connection.Close();

            return nb;
        }
    }
}
