using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class i103DadosBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaEstados();
                listaTipoProcesso();
                listaProcesso();
            }
            else {
                //listaEstados();
                //listaTipoProcesso();
            }
        }

        protected void listaEstados()
        {
            c87SuspenderProcesso WsERL = new c87SuspenderProcesso();
            var lista = WsERL.getListaEstado();
            DropDownListIdEstadoID.Items.Clear();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                DropDownListIdEstadoID.Items.Add(Item);
            }
            DropDownListIdEstadoID.DataBind();
        }

        protected void listaTipoProcesso()
        {
            c87SuspenderProcesso WsERL = new c87SuspenderProcesso();
            var lista = WsERL.getListaTipoProcesso();
            DropDownListIdTipoProcessoID.Items.Clear();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                DropDownListIdTipoProcessoID.Items.Add(Item);
            }
            DropDownListIdTipoProcessoID.DataBind();
        }

        protected void listaProcesso()
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
             var x = pdto.getProcessoCompleto((string)Session["idProcesso"]);
            //DropDownListIdEstadoID.SelectedItem.Value = x.idEstado;
            //DropDownListIdTipoProcessoID.SelectedItem.Value = x.idTipoProcesso;

        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c87SuspenderProcesso wsp = new c87SuspenderProcesso();
            wsp.setProcesso(DropDownListIdEstadoID.SelectedValue.ToString(), DropDownListIdTipoProcessoID.SelectedValue.ToString(), (string)Session["userId"], (string)Session["idProcesso"]);
        }

    }
}