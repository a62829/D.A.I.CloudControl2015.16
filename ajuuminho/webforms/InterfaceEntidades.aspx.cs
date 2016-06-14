using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class InterfaceEntidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //TabRepresentanteLegalID.CssClass = "Clicked";
                //MainViewID.ActiveViewIndex = 0;
                //TabCriarRepresentanteGeralID.CssClass = "Clicked";
                //MainViewID2.ActiveViewIndex = 0;
                //TabCriarTribunalID.CssClass = "Clicked";
                //MultiViewID3.ActiveViewIndex = 0;
                //TabCriarJuizID.CssClass = "Clicked";
                //MultiViewID4.ActiveViewIndex = 0;
                //TabCriarCredorID.CssClass = "Clicked";
                //MultiViewID5.ActiveViewIndex = 0;
                //TabCriarInsolventeID.CssClass = "Clicked";
                //MultiViewID6.ActiveViewIndex = 0;
                //TabCriarPrestadorServicoID.CssClass = "Clicked";
                //MultiViewID7.ActiveViewIndex = 0;
                //TabCriarOutraEntidadeID.CssClass = "Clicked";
                //MultiViewID8.ActiveViewIndex = 0;
            }
        }

        protected void TabRepresentanteLegal_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Clicked";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 0;
        }

        protected void TabAdministradoresJudiciais_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Clicked";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 1;
        }

        protected void TabTribunais_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Clicked";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 2;
        }
        protected void TabJuizes_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Clicked";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 3;
        }
        protected void TabCredores_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Clicked";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 4;
        }
        protected void TabInsolventes_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Clicked";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 5;
        }
        protected void TabContabilistas_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Clicked";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 6;
        }
        protected void TabPrestadoresServico_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Clicked";
            TabOutrasEntidadesID.CssClass = "Initial";
            MainViewID.ActiveViewIndex = 7;
        }
        protected void TabOutrasEntidades_Click(object sender, EventArgs e)
        {
            TabRepresentanteLegalID.CssClass = "Initial";
            TabAdministradoresJudiciaisID.CssClass = "Initial";
            TabTribunaisID.CssClass = "Initial";
            TabJuizesID.CssClass = "Initial";
            TabCredoresID.CssClass = "Initial";
            TabInsolventesID.CssClass = "Initial";
            TabContabilistasID.CssClass = "Initial";
            TabPrestadoresServicoID.CssClass = "Initial";
            TabOutrasEntidadesID.CssClass = "Clicked";
            MainViewID.ActiveViewIndex = 8;
        }

        protected void TabCriarRepresentanteLegal_Click(object sender, EventArgs e)
        {
            TabCriarRepresentanteGeralID.CssClass = "Clicked";
            TabEditarRepresentanteGeralID.CssClass = "Initial";
            TabEliminarRepresentanteGeralID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 0;
        }

        protected void TabEditarRepresentanteLegal_Click(object sender, EventArgs e)
        {
            TabCriarRepresentanteGeralID.CssClass = "Initial";
            TabEditarRepresentanteGeralID.CssClass = "Clicked";
            TabEliminarRepresentanteGeralID.CssClass = "Initial";
            MainViewID1.ActiveViewIndex = 1;
        }

        protected void TabEliminarRepresentanteLegal_Click(object sender, EventArgs e)
        {
            TabCriarRepresentanteGeralID.CssClass = "Initial";
            TabEditarRepresentanteGeralID.CssClass = "Initial";
            TabEliminarRepresentanteGeralID.CssClass = "Clicked";
            MainViewID1.ActiveViewIndex = 2;
        }

        protected void TabCriarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            TabCriarAdministradorJudicialID.CssClass = "Clicked";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            MainViewID2.ActiveViewIndex = 0;
        }

        protected void TabEditarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Clicked";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            MainViewID2.ActiveViewIndex = 1;
        }

        protected void TabEliminarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Clicked";
            MainViewID2.ActiveViewIndex = 2;
        }

        protected void TabCriarTribunal_Click(object sender, EventArgs e)
        {
            TabCriarTribunalID.CssClass = "Clicked";
            TabEditarTribunalID.CssClass = "Initial";
            TabEliminarTribunalID.CssClass = "Initial";
            MainViewID3.ActiveViewIndex = 0;
        }

        protected void TabEditarTribunal_Click(object sender, EventArgs e)
        {
            TabCriarTribunalID.CssClass = "Initial";
            TabEditarTribunalID.CssClass = "Clicked";
            TabEliminarTribunalID.CssClass = "Initial";
            MainViewID3.ActiveViewIndex = 1;
        }

        protected void TabEliminarTribunal_Click(object sender, EventArgs e)
        {
            TabCriarTribunalID.CssClass = "Initial";
            TabEditarTribunalID.CssClass = "Initial";
            TabEliminarTribunalID.CssClass = "Clicked";
            MainViewID3.ActiveViewIndex = 2;
        }

        protected void TabCriarJuiz_Click(object sender, EventArgs e)
        {
            TabCriarJuizID.CssClass = "Clicked";
            TabEditarJuizID.CssClass = "Initial";
            TabEliminarJuizID.CssClass = "Initial";
            MainViewID4.ActiveViewIndex = 0;
        }

        protected void TabEditarJuiz_Click(object sender, EventArgs e)
        {
            TabCriarJuizID.CssClass = "Initial";
            TabEditarJuizID.CssClass = "Clicked";
            TabEliminarJuizID.CssClass = "Initial";
            MainViewID4.ActiveViewIndex = 1;
        }

        protected void TabEliminarJuiz_Click(object sender, EventArgs e)
        {
            TabCriarJuizID.CssClass = "Initial";
            TabEditarJuizID.CssClass = "Initial";
            TabEliminarJuizID.CssClass = "Clicked";
            MainViewID4.ActiveViewIndex = 2;
        }

        protected void TabCriarCredor_Click(object sender, EventArgs e)
        {
            TabCriarCredorID.CssClass = "Clicked";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Initial";
            MainViewID5.ActiveViewIndex = 0;
        }

        protected void TabEditarCredor_Click(object sender, EventArgs e)
        {
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Clicked";
            TabEliminarCredorID.CssClass = "Initial";
            MainViewID5.ActiveViewIndex = 1;
        }

        protected void TabEliminarCredor_Click(object sender, EventArgs e)
        {
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Clicked";
            MainViewID5.ActiveViewIndex = 2;
        }

        protected void TabCriarInsolvente_Click(object sender, EventArgs e)
        {
            TabCriarInsolventeID.CssClass = "Clicked";
            TabEditarInsolventeID.CssClass = "Initial";
            TabEliminarInsolventeID.CssClass = "Initial";
            MainViewID6.ActiveViewIndex = 0;
        }

        protected void TabEditarInsolvente_Click(object sender, EventArgs e)
        {
            TabCriarInsolventeID.CssClass = "Initial";
            TabEditarInsolventeID.CssClass = "Clicked";
            TabEliminarInsolventeID.CssClass = "Initial";
            MainViewID6.ActiveViewIndex = 1;
        }

        protected void TabEliminarInsolvente_Click(object sender, EventArgs e)
        {
            TabCriarInsolventeID.CssClass = "Initial";
            TabEditarInsolventeID.CssClass = "Initial";
            TabEliminarInsolventeID.CssClass = "Clicked";
            MainViewID6.ActiveViewIndex = 2;
        }

        protected void TabCriarContabilista_Click(object sender, EventArgs e)
        {
            TabCriarContabilistaID.CssClass = "Clicked";
            TabEditarContabilistaID.CssClass = "Initial";
            TabEliminarContabilistaID.CssClass = "Initial";
            MainViewID7.ActiveViewIndex = 0;
        }

        protected void TabEditarContabilista_Click(object sender, EventArgs e)
        {
            TabCriarContabilistaID.CssClass = "Initial";
            TabEditarContabilistaID.CssClass = "Clicked";
            TabEliminarContabilistaID.CssClass = "Initial";
            MainViewID7.ActiveViewIndex = 1;
        }

        protected void TabEliminarContabilista_Click(object sender, EventArgs e)
        {
            TabCriarContabilistaID.CssClass = "Initial";
            TabEditarContabilistaID.CssClass = "Initial";
            TabEliminarContabilistaID.CssClass = "Clicked";
            MainViewID7.ActiveViewIndex = 2;
        }

        protected void TabCriarPrestadorServico_Click(object sender, EventArgs e)
        {
            TabCriarPrestadorServicoID.CssClass = "Clicked";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            MainViewID8.ActiveViewIndex = 0;
        }

        protected void TabEditarPrestadorServico_Click(object sender, EventArgs e)
        {
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Clicked";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            MainViewID8.ActiveViewIndex = 1;
        }

        protected void TabEliminarPrestadorServico_Click(object sender, EventArgs e)
        {
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Clicked";
            MainViewID8.ActiveViewIndex = 2;
        }

        protected void TabCriarOutraEntidade_Click(object sender, EventArgs e)
        {
            TabCriarOutraEntidadeID.CssClass = "Clicked";
            TabEditarOutraEntidadeID.CssClass = "Initial";
            TabEliminarOutraEntidadeID.CssClass = "Initial";
            MainViewID9.ActiveViewIndex = 0;
        }

        protected void TabEditarOutraEntidade_Click(object sender, EventArgs e)
        {
            TabCriarOutraEntidadeID.CssClass = "Initial";
            TabEditarOutraEntidadeID.CssClass = "Clicked";
            TabEliminarOutraEntidadeID.CssClass = "Initial";
            MainViewID9.ActiveViewIndex = 1;
        }

        protected void TabEliminarOutraEntidade_Click(object sender, EventArgs e)
        {
            TabCriarOutraEntidadeID.CssClass = "Initial";
            TabEditarOutraEntidadeID.CssClass = "Initial";
            TabEliminarOutraEntidadeID.CssClass = "Clicked";
            MainViewID9.ActiveViewIndex = 2;
        }
    }
}


