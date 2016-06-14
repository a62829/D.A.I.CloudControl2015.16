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
            c43EdicaoInsolvente wsi = new c43EdicaoInsolvente();
            string idi = ListBoxEntidadesID.SelectedValue.ToString();
            d41InsolventeDto idto = wsi.getInsolvente(idi);
            TextBoxNomeID.Text = idto.nome;
            TextBoxMoradaID.Text = idto.morada;
            TextBoxCodPostalID.Text = idto.codPostal;
            TextBoxLocalidadeID.Text = idto.localidade;
            TextBoxEmailID.Text = idto.email;
            TextBoxTelefoneID.Text = idto.telefone;
            TextBoxTelemovelID.Text = idto.telemovel;
            TextBoxFaxID.Text = idto.fax;
            TextBoxCcID.Text = idto.cc;
            TextBoxIbanID.Text = idto.iban;
            TextBoxNifID.Text = idto.nif;
            TextBoxLastChangedID.Text = idto.lastChangeBy;
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
            WsEI.editarInsolvente(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaInsolvente()
        {
            c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
            var lista = WsEI.getListaInsolvente();
            foreach (KeyValuePair<String, d41InsolventeDto> pair in lista)
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