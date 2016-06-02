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

namespace ajuUminho.controls
{
    public partial class header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User.Text = HttpContext.Current.Session["userName"].ToString();
        }

        protected void signOut(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            if (ws1.signOut() == true)
            {
                Response.Redirect("~/webforms/Login.aspx");
            }
            else
            {

            }
        }

        protected void ButtonGestaoEtidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/gestaoEntidades.aspx");
        }

        protected void ButtonGestaoIdentidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/gestaoIdentidades.aspx");
        }

        protected void ButtonGestaoProcessos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/gestaoProcessos.aspx");
        }
    }
}
