using ajuUminho.App_Code;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i46Contabilistas : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaContabilista();
            }
            else
            {
                listaContabilista();
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d45Contabilista c = new d45Contabilista();
            c.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Contabilista criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c47EdicaoContabilista ec = new c47EdicaoContabilista();
            string idc = ListBoxEntidadesID.SelectedValue.ToString();
            d45ContabilistaDto c = ec.getContabilista(idc);
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
            listaContabilista();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c47EdicaoContabilista WsEC = new c47EdicaoContabilista();
            WsEC.editarContabilista(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaContabilista()
        {
            c47EdicaoContabilista WsEC = new c47EdicaoContabilista();
            var lista = WsEC.getListaContabilista();
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
