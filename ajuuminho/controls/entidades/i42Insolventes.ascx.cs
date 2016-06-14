using _BusinessLayer;
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
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c43EdicaoInsolvente ws = new c43EdicaoInsolvente();
            ws.criarInsolvente(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaInsolvente();
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
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
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

        protected void TabCriarInsolvente_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarInsolventeID.CssClass = "Clicked";
            TabEditarInsolventeID.CssClass = "Initial";
            TabEliminarInsolventeID.CssClass = "Initial";
            TabPesquisarInsolventeID.CssClass = "Initial";
        }

        protected void TabEditarInsolvente_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarInsolventeID.CssClass = "Initial";
            TabEditarInsolventeID.CssClass = "Clicked";
            TabEliminarInsolventeID.CssClass = "Initial";
            TabPesquisarInsolventeID.CssClass = "Initial";
        }

        protected void TabEliminarInsolvente_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarInsolventeID.CssClass = "Initial";
            TabEditarInsolventeID.CssClass = "Initial";
            TabEliminarInsolventeID.CssClass = "Clicked";
            TabPesquisarInsolventeID.CssClass = "Initial";
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabPesquisarInsolvente_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarInsolventeID.CssClass = "Initial";
            TabEditarInsolventeID.CssClass = "Initial";
            TabEliminarInsolventeID.CssClass = "Initial";
            TabPesquisarInsolventeID.CssClass = "Clicked";
        }
    }
}