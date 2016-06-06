using BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i38Credores : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaCredor();
            }
            else
            {
                listaCredor();
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c39EdicaoCredor ws = new c39EdicaoCredor();
            ws.criarCredor(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
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
            c39EdicaoCredor ec = new c39EdicaoCredor();
            string idc = ListBoxEntidadesID.SelectedValue.ToString();
            d37CredorDto c = ec.getCredor(idc);
            TextBoxNomeID.Text = c.nome;
            TextBoxMoradaID.Text = c.morada;
            TextBoxCodPostalID.Text = c.codPostal;
            TextBoxLocalidadeID.Text = c.localidade;
            TextBoxEmailID.Text = c.email;
            TextBoxTelefoneID.Text = c.telefone;
            TextBoxTelemovelID.Text = c.telemovel;
            TextBoxFaxID.Text = c.fax;
            TextBoxCcID.Text = c.cc;
            TextBoxIbanID.Text = c.iban;
            TextBoxNifID.Text = c.nif;
            TextBoxLastChangedID.Text = c.lastChangeBy;
            ListBoxEntidadesID.Items.Clear();
            listaCredor();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c39EdicaoCredor WsEC = new c39EdicaoCredor();
            WsEC.editarCredor(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaCredor()
        {
            c39EdicaoCredor WsEC = new c39EdicaoCredor();
            var lista = WsEC.getListaCredor();
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