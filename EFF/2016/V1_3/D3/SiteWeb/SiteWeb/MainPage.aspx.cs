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
        protected string FillPageContent(IUser.Type type)
        {
            string content = "";

            switch (type) {
                case IUser.Type.GUEST:
                content += "<a href=\"~/Consultation.aspx\">Consultation</a>";
                content += "<br />";
                break;

                case IUser.Type.BIEN:
                content += "<a href=\"~/Consultation.aspx\">Consultation</a>";
                content += "<br />";
                content += "<a href=\"~/Participation.aspx\">Participer</a>";
                content += "<br />";
                break;

                case IUser.Type.PLAN:
                content += "<a href=\"~/Consultation.aspx\">Consultation</a>";
                content += "<br />";
                content += "<a href=\"~/Participation.aspx\">Participer</a>";
                content += "<br />";
                break;

                default: break;
            }
            return content;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null && Session["Type"] != null) {
                lblemail.Text = Session["Email"].ToString( );
                Response.Write(FillPageContent((IUser.Type)Session["Type"]));
            }
        }
    }
}