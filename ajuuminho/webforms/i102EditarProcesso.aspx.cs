using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace ajuUminho.webforms
{
    public partial class i102EditarProcesso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                listaProcesso();
            }
            else
            {

            }
        }

        protected void TabDadosBase_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i103DadosBase.aspx");
        }

        protected void TabEntidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i56AtribuicaoEntidades.aspx");
        }

        protected void TabCredores_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i72Credores.aspx");
        }

        protected void TabArquivo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i86Arquivo.aspx");
        }

        protected void TabEventos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i60Eventos.aspx");
        }

        protected void TabBens_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i64Bens.aspx");
        }

        protected void TabMovimentosFinanceiros_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i68MovimentosFinanceiros.aspx");
        }

        protected void TabServicosExternos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i75ServicosExternos.aspx");
        }

        protected void TabFicheirosMultimedia_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i80FicheirosMultimedia.aspx");
        }

        protected void TabFicheirosTexto_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webforms/i83FicheirosTexto.aspx");
        }

        protected void ListBoxProcessosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["idProcesso"] = ListBoxProcessosID.SelectedItem.Value.ToString();
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