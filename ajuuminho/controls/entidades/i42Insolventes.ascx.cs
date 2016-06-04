using ajuUminho.App_Code;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i42Insolventes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaInsolvente();
            }
            else
            {
                listaInsolvente();
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d41Insolvente i = new d41Insolvente();
            i.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Insolvente criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c43EdicaoInsolvente ei = new c43EdicaoInsolvente();
            string idi = ListBoxEntidadesID.SelectedValue.ToString();
            d41InsolventeDto i = ei.getInsolvente(idi);
            TextBoxNomeID.Text = i.nome;
            TextBoxMoradaID.Text = i.morada;
            TextBoxCodPostalID.Text = i.codPostal;
            TextBoxLocalidadeID.Text = i.localidade;
            TextBoxEmailID.Text = i.email;
            TextBoxTelefoneID.Text = i.telefone;
            TextBoxTelemovelID.Text = i.telemovel;
            TextBoxFaxID.Text = i.fax;
            TextBoxCcID.Text = i.cc;
            TextBoxIbanID.Text = i.iban;
            TextBoxNifID.Text = i.nif;
            TextBoxLastChangedID.Text = i.lastChangeBy;
            ListBoxEntidadesID.Items.Clear();
            listaInsolvente();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
            WsEI.editarInsolvente(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaInsolvente()
        {
            c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
            var lista = WsEI.getListaInsolvente();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }
    }
}