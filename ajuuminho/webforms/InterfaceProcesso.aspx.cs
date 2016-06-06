using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class InterfaceProcesso : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        TabEventosID.CssClass = "Clicked";
        //        MainViewID.ActiveViewIndex = 0;
        //    }
        //}

        //protected void TabEventos_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Clicked";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 0;
        //}

        //protected void TabBens_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Clicked";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 1;
        //}

        //protected void TabMovimentosFinanceiros_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Clicked";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 2;
        //}
        //protected void TabCredores_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Clicked";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";;
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 3;
        //}
        //protected void TabServicosExternos_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Clicked";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 4;
        //}
        //protected void TabFicheirosMultimedia_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Clicked";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 5;
        //}
        //protected void TabFicheirosTexto_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Clicked";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 6;
        //}
        //protected void TabCreditosReclamados_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Clicked";
        //    TabAtribuicaoEntidadesID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 7;
        //}
        //protected void TabAtribuicaoEntidades_Click(object sender, EventArgs e)
        //{
        //    TabEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    TabCreditosReclamadosID.CssClass = "Initial";
        //    TabAtribuicaoEntidadesID.CssClass = "Clicked";
        //    MainViewID.ActiveViewIndex = 8;
        //}
    }
}


