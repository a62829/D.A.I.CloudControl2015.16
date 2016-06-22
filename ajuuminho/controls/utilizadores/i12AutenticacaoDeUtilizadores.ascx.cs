using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;

namespace ajuUminho.controls.utilizadores
{
    public partial class i12AutenticacaoDeUtilizadores : System.Web.UI.UserControl
    {
        protected void SignIn(object sender, EventArgs e)
        {
            c11Autenticacao ws1 = new c11Autenticacao();
            if (ws1.signIn(TextBoxUserNameID.Text, TextBoxPasswordID.Text) == true)
            {
                Response.Redirect("~/webforms/home.aspx");
            }
            else
            {
                string mystring = "Nome de utilizador ou palavra pass inválida.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }

        }

    }
}