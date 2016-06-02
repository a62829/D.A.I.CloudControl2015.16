using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;

namespace ajuUminho.webforms
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            if (ws1.signIn(TextBoxUserNameID.Text, TextBoxPasswordID.Text) == true)
            {
                Response.Redirect("~/webforms/home.aspx");
            }
            else
            {
                //StatusText.Text = "Invalid username or password.";
                //LoginStatus.Visible = true;
            }

        }

    }
}