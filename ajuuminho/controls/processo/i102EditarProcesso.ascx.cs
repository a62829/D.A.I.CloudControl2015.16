using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace ajuUminho.controls.processo
{
    public partial class i102EditarProcesso : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCrossPagePostBack)
            {
                listaProcesso();
            }else{

            }
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

        protected void ListBoxProcessosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var y = listaProcessoCompleto(ListBoxProcessosID.SelectedValue.ToString());
            Application["idProcesso"] = y.idProcesso.ToString();

        }

        protected void listaProcesso()
        {
            ListBoxProcessosID.Items.Clear();
            c87 WsERL = new c87();
            var lista = WsERL.getListaProcesso();
            foreach (KeyValuePair<String, d85ProcessoDto> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.idLegal.ToString();
                Item.Value = pair.Value.idProcesso.ToString();
                ListBoxProcessosID.Items.Add(Item);
                ListBoxProcessosID.DataBind();
            }
        }

        protected d85ProcessoDto listaProcessoCompleto(string idProcesso)
        {
            c87 wsp = new c87();
            d85ProcessoDto pdto = wsp.getProcessoCompleto(idProcesso);
            return pdto;
        }


    }
}