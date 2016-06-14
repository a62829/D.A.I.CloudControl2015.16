using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.administracao
{
    public partial class i3AdministradorUtilizadores : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TabCriarUtilizador_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            TabCriarUtilizadorID.CssClass = "Clicked";
            TabEditarUtilizadorID.CssClass = "Initial";
            TabEliminarUtilizadorID.CssClass = "Initial";
        }

        protected void TabEditarUtilizador_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            TabCriarUtilizadorID.CssClass = "Initial";
            TabEditarUtilizadorID.CssClass = "Clicked";
            TabEliminarUtilizadorID.CssClass = "Initial";
        }

        protected void TabEliminarUtilizador_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            TabCriarUtilizadorID.CssClass = "Initial";
            TabEditarUtilizadorID.CssClass = "Initial";
            TabEliminarUtilizadorID.CssClass = "Clicked";
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

        }

    }
}