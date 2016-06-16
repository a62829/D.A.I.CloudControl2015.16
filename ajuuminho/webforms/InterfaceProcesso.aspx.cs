using ajuUminho.controls.processo;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //TabEventosID.CssClass = "Clicked";
                //MainViewID.ActiveViewIndex = 0;

                //TabCriarProcessoID.CssClass = "Clicked";
                //MainViewID.ActiveViewIndex = 0;

            }
        }

        protected void TabCriarProcesso_Click(object sender, EventArgs e)
        {
            TabCriarProcessoID.CssClass = "Clicked";
            TabEditarProcessoID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 0;
        }


        //protected void TabAtribuirEntidades_Click(object sender, EventArgs e)
        //{
        //    TabCriarProcessoID.CssClass = "Initial";
        //    TabAtribuirEntidadesID.CssClass = "Clicked";
        //    TabEditarProcessoID.CssClass = "Initial";
        //    TabListarProcessoID.CssClass = "Initial";
        //    TabPararProcessoID.CssClass = "Initial";
        //    TabCategorizarProcessoID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 1;
        //}

        protected void TabEditarProcesso_Click(object sender, EventArgs e)
        {
            TabCriarProcessoID.CssClass = "Initial";
            TabEditarProcessoID.CssClass = "Clicked";
            MainViewID.ActiveViewIndex = 1;
        }

        //protected void TabListarProcesso_Click(object sender, EventArgs e)
        //{
        //    TabCriarProcessoID.CssClass = "Initial";
        //    TabAtribuirEntidadesID.CssClass = "Initial";
        //    TabEditarProcessoID.CssClass = "Initial";
        //    TabListarProcessoID.CssClass = "Clicked";
        //    TabPararProcessoID.CssClass = "Initial";
        //    TabCategorizarProcessoID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 3;
        //}

        //protected void TabPararProcesso_Click(object sender, EventArgs e)
        //{
        //    TabCriarProcessoID.CssClass = "Initial";
        //    TabAtribuirEntidadesID.CssClass = "Initial";
        //    TabEditarProcessoID.CssClass = "Initial";
        //    TabListarProcessoID.CssClass = "Initial";
        //    TabPararProcessoID.CssClass = "Clicked";
        //    TabCategorizarProcessoID.CssClass = "Initial";
        //    MainViewID.ActiveViewIndex = 4;
        //}

        //protected void TabCategorizarProcesso_Click(object sender, EventArgs e)
        //{
        //    TabCriarProcessoID.CssClass = "Initial";
        //    TabAtribuirEntidadesID.CssClass = "Initial";
        //    TabEditarProcessoID.CssClass = "Initial";
        //    TabListarProcessoID.CssClass = "Initial";
        //    TabPararProcessoID.CssClass = "Initial";
        //    TabCategorizarProcessoID.CssClass = "Clicked";
        //    MainViewID.ActiveViewIndex = 5;
        //}

        //protected void TabAtribuirEventos_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Clicked";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabEditarCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    MainViewID1.ActiveViewIndex = 0;
        //}

        //protected void TabBens_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Clicked";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabEditarCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    MainViewID1.ActiveViewIndex = 1;
        //}

        //protected void TabMovimentosFinanceiros_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Clicked";
        //    TabEditarCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    MainViewID1.ActiveViewIndex = 2;
        //}

        //protected void TabCredores_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabEditarCredoresID.CssClass = "Clicked";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    MainViewID1.ActiveViewIndex = 3;
        //}

        //protected void TabServicosExternos_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabEditarCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Clicked";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    MainViewID1.ActiveViewIndex = 4;
        //}

        //protected void TabFicheirosMultimedia_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabEditarCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Clicked";
        //    TabFicheirosTextoID.CssClass = "Initial";
        //    MainViewID1.ActiveViewIndex = 5;
        //}

        //protected void TabFicheirosTexto_Click(object sender, EventArgs e)
        //{
        //    TabAtribuirEventosID.CssClass = "Initial";
        //    TabBensID.CssClass = "Initial";
        //    TabMovimentosFinanceirosID.CssClass = "Initial";
        //    TabEditarCredoresID.CssClass = "Initial";
        //    TabServicosExternosID.CssClass = "Initial";
        //    TabFicheirosMultimediaID.CssClass = "Initial";
        //    TabFicheirosTextoID.CssClass = "Clicked";
        //    MainViewID1.ActiveViewIndex = 6;
        //}




        //        protected void TabEventos_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Clicked";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 0;
        //        }

        //        protected void TabBens_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Clicked";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 1;
        //        }

        //        protected void TabMovimentosFinanceiros_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Clicked";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 2;
        //        }
        //        protected void TabCredores_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Clicked";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial"; ;
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 3;
        //        }
        //        protected void TabServicosExternos_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Clicked";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 4;
        //        }
        //        protected void TabFicheirosMultimedia_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Clicked";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 5;
        //        }
        //        protected void TabFicheirosTexto_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Clicked";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 6;
        //        }
        //        protected void TabCreditosReclamados_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Clicked";
        //            TabAtribuicaoEntidadesID.CssClass = "Initial";
        //            MainViewID.ActiveViewIndex = 7;
        //        }
        //        protected void TabAtribuicaoEntidades_Click(object sender, EventArgs e)
        //        {
        //            TabEventosID.CssClass = "Initial";
        //            TabBensID.CssClass = "Initial";
        //            TabMovimentosFinanceirosID.CssClass = "Initial";
        //            TabCredoresID.CssClass = "Initial";
        //            TabServicosExternosID.CssClass = "Initial";
        //            TabFicheirosMultimediaID.CssClass = "Initial";
        //            TabFicheirosTextoID.CssClass = "Initial";
        //            TabCreditosReclamadosID.CssClass = "Initial";
        //            TabAtribuicaoEntidadesID.CssClass = "Clicked";
        //            MainViewID.ActiveViewIndex = 8;
        //        }
    }
}


