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
                TabRepresentanteLegalID.CssClass = "Clicked";
                MainViewID.ActiveViewIndex = 0;
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
    }
}


