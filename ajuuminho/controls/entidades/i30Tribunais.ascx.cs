using BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i30Tribunais : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaTribunal();
            }
            else
            {
                listaTribunal();
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c31EdicaoTribunal ws = new c31EdicaoTribunal();
            ws.criarTribunal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c31EdicaoTribunal et = new c31EdicaoTribunal();
            string idt = ListBoxEntidadesID.SelectedValue.ToString();
            d29TribunalDto t = et.getTribunal(idt);
            TextBoxNomeID.Text = t.nome;
            TextBoxMoradaID.Text = t.morada;
            TextBoxCodPostalID.Text = t.codPostal;
            TextBoxLocalidadeID.Text = t.localidade;
            TextBoxEmailID.Text = t.email;
            TextBoxTelefoneID.Text = t.telefone;
            TextBoxTelemovelID.Text = t.telemovel;
            TextBoxFaxID.Text = t.fax;
            TextBoxIbanID.Text = t.iban;
            TextBoxNifID.Text = t.nif;
            TextBoxLastChangedID.Text = t.lastChangeBy;
            ListBoxEntidadesID.Items.Clear();
            listaTribunal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c31EdicaoTribunal WsET = new c31EdicaoTribunal();
            WsET.editarTribunal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaTribunal()
        {
            c31EdicaoTribunal WsET = new c31EdicaoTribunal();
            var lista = WsET.getListaTribunal();
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