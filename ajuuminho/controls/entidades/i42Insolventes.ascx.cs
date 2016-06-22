using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
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

        protected void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
                else
                    ClearAllText(c);
            }
        }

        protected void EnableAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Enabled = true;
                else
                    EnableAllText(c);
            }
        }

        protected void DisableAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Enabled = false;
                else
                    DisableAllText(c);
            }
        }



        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c43EdicaoInsolvente ws = new c43EdicaoInsolvente();
            ws.criarInsolvente(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Insolvente criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaInsolvente();
            ClearAllText(this);
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
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
            WsEI.editarInsolvente(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
            ClearAllText(this);
            ListBoxEntidadesID.ClearSelection();
            ListBoxEntidadesID.Items.Clear();
            listaInsolvente();
            string mystring = "Insolvente editado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void listaInsolvente()
        {
            c43EdicaoInsolvente WsEI = new c43EdicaoInsolvente();
            var lista = WsEI.getListaInsolvente();
            foreach (KeyValuePair<String, d41InsolventeDto> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void TabCriarInsolvente_Click(object sender, EventArgs e)
        {
            EnableAllText(this);
            TextBoxLastChangedID.Enabled = false;
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ClearAllText(this);
        }

        protected void TabEditarInsolvente_Click(object sender, EventArgs e)
        {
            ListBoxEntidadesID.ClearSelection();
            EnableAllText(this);
            TextBoxLastChangedID.Enabled = false;
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ClearAllText(this);
        }

        protected void TabEliminarInsolvente_Click(object sender, EventArgs e)
        {
            ListBoxEntidadesID.ClearSelection();
            DisableAllText(this);
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ClearAllText(this);
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {
            c44RemocaoInsolvente WsERL = new c44RemocaoInsolvente();
            WsERL.removerInsolvente(ListBoxEntidadesID.SelectedValue.ToString());
            ClearAllText(this);
            ListBoxEntidadesID.ClearSelection();
            ListBoxEntidadesID.Items.Clear();
            listaInsolvente();
            string mystring = "Insolvente eliminado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void TabPesquisarInsolvente_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ClearAllText(this);
        }
    }
}