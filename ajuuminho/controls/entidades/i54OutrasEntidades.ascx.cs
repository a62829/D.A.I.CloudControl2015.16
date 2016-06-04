using ajuUminho.App_Code;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i54OutrasEntidades : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    if (!IsPostBack)
            //    {
            //        listaOutraEntidade();
            //    }
            //    else
            //    {
            //        listaOutraEntidade();
            //    }
            //}

            //protected void ButtonCriarID_Click(object sender, EventArgs e)
            //{
            //    d53OutraEntidade oe = new d53OutraEntidade();
            //    oe.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
            //        TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
            //        TextBoxNifID.Text, TextBoxLastChangedID.Text);

            //    string mystring = "Outra Entidade criado com sucesso.";
            //    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            //    foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            //    {
            //        textbox.Text = string.Empty;
            //    }
            //}

            //protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    c56EdicaoOutraEntidade eoe = new c56EdicaoOutraEntidade();
            //    string idoe = ListBoxEntidadesID.SelectedValue.ToString();
            //    d53OutraEntidadeDto oe = eoe.getOutraEntidade(idoe);
            //    TextBoxNomeID.Text = oe.nome;
            //    TextBoxMoradaID.Text = oe.morada;
            //    TextBoxCodPostalID.Text = oe.codPostal;
            //    TextBoxLocalidadeID.Text = oe.localidade;
            //    TextBoxEmailID.Text = oe.email;
            //    TextBoxTelefoneID.Text = oe.telefone;
            //    TextBoxTelemovelID.Text = oe.telemovel;
            //    TextBoxFaxID.Text = oe.fax;
            //    TextBoxCcID.Text = oe.cc;
            //    TextBoxIbanID.Text = oe.iban;
            //    TextBoxNifID.Text = oe.nif;
            //    TextBoxLastChangedID.Text = oe.lastChangeBy;
            //    ListBoxEntidadesID.Items.Clear();
            //    listaOutraEntidade();
            //}

            //protected void ButtonEditarID_Click(object sender, EventArgs e)
            //{
            //    c56EdicaoOutraEntidade WsEOE = new c56EdicaoOutraEntidade();
            //    WsEOE.editarOutraEntidade(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
            //        TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
            //        TextBoxNifID.Text, TextBoxLastChangedID.Text);
            //}

            //protected void listaOutraEntidade()
            //{
            //    c56EdicaoOutraEntidade WsEOE = new c56EdicaoOutraEntidade();
            //    var lista = WsEOE.getListaOutraEntidade();
            //    foreach (KeyValuePair<String, String> pair in lista)
            //    {
            //        ListItem Item = new ListItem();
            //        Item.Text = pair.Value.ToString();
            //        Item.Value = pair.Key.ToString();
            //        ListBoxEntidadesID.Items.Add(Item);
            //        ListBoxEntidadesID.DataBind();
            //    }
        }
    }
}