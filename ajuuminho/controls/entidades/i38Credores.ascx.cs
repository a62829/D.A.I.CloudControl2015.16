using _BusinessLayer;
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
            ListBoxEntidadesID.Items.Clear();
            listaCredor();
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
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaCredor();
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
            c39EdicaoCredor WsERL = new c39EdicaoCredor();
            var lista = WsERL.getListaCredor();
            foreach (KeyValuePair<String, d37CredorDto> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarCredor_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarCredorID.CssClass = "Clicked";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Initial";
        }

        protected void TabEditarCredor_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Clicked";
            TabEliminarCredorID.CssClass = "Initial";
            TabPesquisarCredorID.CssClass = "Initial";
        }

        protected void TabEliminarCredor_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Clicked";
            TabPesquisarCredorID.CssClass = "Initial";
        }

        protected void TabPesquisarCredor_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Initial";
            TabPesquisarCredorID.CssClass = "Clicked";
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }
    }
}