using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SiteWeb
{
    /// <summary>
    /// Description résumée de ServiceUV
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceUV: System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string InfoFormation(int numF)
        {
            string str = "";

            using (var cmd = new System.Data.SqlClient.SqlCommand( )) {
                cmd.Connection = new System.Data.SqlClient.SqlConnection( );
                cmd.Connection.ConnectionString = "Server = WINXP\\SQLEXPRESS;" +
                                                  "Initial Catalog = ff2016_v33;" +
                                                  "Integrated Security = TRUE;";
                cmd.Connection.Open( );
                cmd.CommandText = "info";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idf", numF);
                using (var reader = cmd.ExecuteReader( )) {
                    reader.Read( );
                    str = string.Format("NB UV: {0} | F PERM: {1} | F VACA {2} ",
                                                reader["nombreUV"].ToString( ),
                                                reader["nb_per"].ToString( ),
                                                reader["nb_vac"].ToString( ));
                    reader.Close( );
                }
                cmd.Connection.Close( );
            }

            return str;
        }
    }
}
