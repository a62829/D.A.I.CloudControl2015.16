using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.processo
{
    public partial class i102EditarProcesso : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TabDadosBase_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Clicked";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 0;
        }

        protected void TabEntidades_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Clicked";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 1;
        }

        protected void TabCredores_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Clicked";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 2;
        }

        protected void TabArquivo_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Clicked";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 3;
        }

        protected void TabEventos_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Clicked";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 4;
        }

        protected void TabBens_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Clicked";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 5;
        }

        protected void TabMovimentosFinanceiros_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Clicked";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 6;
        }

        protected void TabServicosExternos_Click(object sender, EventArgs e)
        {
            TabEventosID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Clicked";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 7;
        }

        protected void TabFicheirosMultimedia_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Clicked";
            TabFicheirosTextoID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 8;
        }

        protected void TabFicheirosTexto_Click(object sender, EventArgs e)
        {
            TabDadosBaseID.CssClass = "Initial";
            TabEntidadesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabArquivoID.CssClass = "Initial";
            TabEventosID.CssClass = "Initial";
            TabBensID.CssClass = "Initial";
            TabMovimentosFinanceirosID.CssClass = "Initial";
            TabServicosExternosID.CssClass = "Initial";
            TabFicheirosMultimediaID.CssClass = "Initial";
            TabFicheirosTextoID.CssClass = "Clicked";
            MainViewID1.ActiveViewIndex = 9;
        }
    }
}