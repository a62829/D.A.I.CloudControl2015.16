using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace ajuUminho.controls.utilizadores
{
    public partial class i14TerminoDeSessao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User.Text = HttpContext.Current.Session["userName"].ToString();
        }

        protected void signOut(object sender, EventArgs e)
        {
            c13TerminoSessao ws1 = new c13TerminoSessao();
            if (ws1.signOut() == true)
            {
                Response.Redirect("~/webforms/login.aspx");
            }
            else
            {

            }
        }

    protected void ButtonEntidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/InterfaceEntidades.aspx");
        }

        protected void ButtonAdministracao_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/InterfaceAdministracao.aspx");
        }

        protected void ButtonProcessos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/InterfaceProcesso.aspx");
        }
    }
}
