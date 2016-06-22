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
    public partial class i101CriarProcesso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                if (!IsPostBack)
                {
                    listaEstados();
                    listaTipoProcesso();
                    listaInsolvente();

                }
                else {

                }
            
        }

protected void ButtonCriarID_Click1(object sender, EventArgs e)
{
    c87SuspenderProcesso ws = new c87SuspenderProcesso();
    ws.criarProcesso(TextBoxIdLegalID.Text, DropDownListIdEstadoID.SelectedItem.Value, DropDownListIdTipoProcessoID.SelectedItem.Value, "1111", ListBoxInsolventesID.SelectedItem.Value);

    string mystring = "Processo criado com sucesso";
    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
    foreach (TextBox textbox in this.Controls.OfType<TextBox>())
    {
        textbox.Text = string.Empty;
    }
    //ListBoxEntidadesID.Items.Clear();
    //listaRepresentanteLegal();
}

protected void listaEstados()
{
    //DropDownListIdEstadoID.Items.Clear();
    c87SuspenderProcesso wsp = new c87SuspenderProcesso();
    var lista = wsp.getListaEstado();
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
    DropDownListIdTipoProcessoID.Items.Clear();
    c87SuspenderProcesso wsp = new c87SuspenderProcesso();
    var lista = wsp.getListaTipoProcesso();
    foreach (KeyValuePair<String, String> pair in lista)
    {
        ListItem Item = new ListItem();
        Item.Text = pair.Value.ToString();
        Item.Value = pair.Key.ToString();
        DropDownListIdTipoProcessoID.Items.Add(Item);
        DropDownListIdTipoProcessoID.DataBind();
    }
}

protected void listaInsolvente()
{
    ListBoxInsolventesID.Items.Clear();
    c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
    var lista = WsEI.getListaInsolvente();
    foreach (KeyValuePair<String, d41InsolventeDto> pair in lista)
    {
        ListItem Item = new ListItem();
        Item.Text = pair.Value.nome.ToString();
        Item.Value = pair.Value.id.ToString();
        ListBoxInsolventesID.Items.Add(Item);
        ListBoxInsolventesID.DataBind();
    }
}
    }
}