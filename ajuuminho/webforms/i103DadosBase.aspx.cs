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
            }
            else {
                listaEstados();
                listaTipoProcesso();
            }
        }

        protected void listaEstados()
        {
            DropDownListIdEstadoID.Items.Clear();
            c87 WsERL = new c87();
            var lista = WsERL.getListaEstado();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                DropDownListIdEstadoID.Items.Add(Item);
                DropDownListIdEstadoID.DataBind();
            }
        }

        protected void listaTipoProcesso()
        {
            DropDownListIdTipoProcessoID.Items.Clear();
            c87 WsERL = new c87();
            var lista = WsERL.getListaTipoProcesso();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                DropDownListIdTipoProcessoID.Items.Add(Item);
                DropDownListIdTipoProcessoID.DataBind();
            }
        }

        protected void listaProcesso()
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            pdto.getProcessoCompleto((string)Session["idProcesso"]);

        }
    }
}