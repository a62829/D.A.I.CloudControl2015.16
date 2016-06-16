using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class InterfaceAdministracao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void TabAdministradorUtilizadores_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPaddingID.Attributes.Add("class", "ViewsBox");
            ViewsBoxNoPaddingID.Visible = true;
            TabAdministradorUtilizadoresID.CssClass = "Clicked";
            TabAtribuirPerfilID.CssClass = "Initial";
            TabConfirmarPerfilID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 0;
        }

        protected void TabAtribuirPerfil_Click(object sender, EventArgs e)
        {
            ViewBoxVisibleID1.Visible = true;
            TabAdministradorUtilizadoresID.CssClass = "Initial";
            TabAtribuirPerfilID.CssClass = "Clicked";
            TabConfirmarPerfilID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 1;
        }

        protected void TabConfirmarPerfil_Click(object sender, EventArgs e)
        {
            ViewBoxVisibleID2.Visible = true;
            TabAdministradorUtilizadoresID.CssClass = "Initial";
            TabAtribuirPerfilID.CssClass = "Initial";
            TabConfirmarPerfilID.CssClass = "Clicked";
            MainViewID.ActiveViewIndex = 2;
        }
    }
}