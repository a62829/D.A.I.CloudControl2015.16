using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class gestaoProcessos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabDadosGeraisID.CssClass = "Clicked";
                MainViewID.ActiveViewIndex = 0;
            }
        }

        protected void TabDadosGerais_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Clicked";
            TabContabilidadeID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabAnexosID.CssClass = "Initial";
            TabRelatoriosID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 0;
        }

        protected void TabContabilidade_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Initial";
            TabContabilidadeID.CssClass = "Clicked";
            TabCredoresID.CssClass = "Initial";
            TabAnexosID.CssClass = "Initial";
            TabRelatoriosID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 1;
        }

        protected void TabCredores_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Initial";
            TabContabilidadeID.CssClass = "Initial";
            TabCredoresID.CssClass = "Clicked";
            TabAnexosID.CssClass = "Initial";
            TabRelatoriosID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 2;
        }
        protected void TabAnexos_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Initial";
            TabContabilidadeID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabAnexosID.CssClass = "Clicked";
            TabRelatoriosID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 3;
        }
        protected void TabRelatorios_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Initial";
            TabContabilidadeID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabAnexosID.CssClass = "Initial";
            TabRelatoriosID.CssClass = "Clicked";
            TabEventosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 4;
        }
        protected void TabEventos_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Initial";
            TabContabilidadeID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabAnexosID.CssClass = "Initial";
            TabRelatoriosID.CssClass = "Initial";
            TabEventosID.CssClass = "Clicked";
            TabServicosExternosID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 5;
        }
        protected void TabServicosExternos_Click(object sender, EventArgs e)
        {
            TabDadosGeraisID.CssClass = "Initial";
            TabContabilidadeID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabAnexosID.CssClass = "Initial";
            TabRelatoriosID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Clicked";
            MainViewID.ActiveViewIndex = 6;
        }
    }
}


