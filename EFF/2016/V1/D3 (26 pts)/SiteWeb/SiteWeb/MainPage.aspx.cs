using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class MainPage: System.Web.UI.Page
    {
        private bool isOrg, isGuest;
        private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            string pMain = string.Empty;

            #region Initializisation
            isOrg = isGuest = false;
            email = string.Empty;
            #endregion

            #region Identify the user
            try {
                if (isGuest = bool.Parse(Request.QueryString["user"])) {
                    isOrg = bool.Parse(Request.QueryString["isorg"]);
                    email = Request.QueryString["email"];
                } else email = "GUEST";
            } catch (Exception) { Response.Redirect("~/ERR.aspx"); }

            lblusername.Style.Value = "font-style: bold; font-size: 15px;";
            lblusername.Text = "<br /><br />User: " + email;
            #endregion

            if (isOrg) pMain += "<h2> Organisateur </h2>" +
                "<ul>" + " <li> <a href=\"#\"> Vos Campagnes</a></li>" + "</ul>";
            else pMain += "<h2> Participation </h2> " +
                "<ul>" + " <li> <a href=\"#\">Participer a une Campagne</a></li>"+
                "</ul>";

            if (isGuest) pMain += "<br /> <h2>Other</h2> " +
                "<ul>" + " <li><a href=\"#\">List de campagnes existantes</a></li>" + 
                "</ul>";

            Response.Write(pMain);
        }
    }
}