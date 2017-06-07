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
                content += "<a href=\"Consultation.aspx\">Consultation</a>";
                content += "<br />";
                break;

                case IUser.Type.BIEN:
                content += "<a href=\"Consultation.aspx\">Consultation</a>";
                content += "<br />";
                content += "<a href=\"Participation.aspx\">Participer</a>";
                content += "<br />";
                break;

                case IUser.Type.PLAN:
                content += "<a href=\"Consultation.aspx\">Consultation</a>";
                content += "<br />";
                content += "<a href=\"Participation.aspx\">Participer</a>";
                content += "<br />";
                break;

                default: break;
            }

            return (content += "<br />");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["Email"] != null && Session["Type"] != null) {
                Session.Timeout += 15;
                if (Session["Email"].ToString( ) != "none")
                    lblemail.Text = string.Format("Email: {0}", Session["Email"].ToString( ));
                else lblemail.Text = "Anonyme";
                Response.Write(FillPageContent((IUser.Type)Session["Type"]));
            } else {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session["Email"] = Session["Type"] = null;
            Response.Redirect("~/Default.aspx");
        }
    }
}