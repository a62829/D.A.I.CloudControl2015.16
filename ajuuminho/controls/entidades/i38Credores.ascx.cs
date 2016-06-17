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
            c39EdicaoCredor wsc = new c39EdicaoCredor();
            string idc = ListBoxEntidadesID.SelectedValue.ToString();
            d37CredorDto cdto = wsc.getCredor(idc);
            TextBoxNomeID.Text = cdto.nome;
            TextBoxMoradaID.Text = cdto.morada;
            TextBoxCodPostalID.Text = cdto.codPostal;
            TextBoxLocalidadeID.Text = cdto.localidade;
            TextBoxEmailID.Text = cdto.email;
            TextBoxTelefoneID.Text = cdto.telefone;
            TextBoxTelemovelID.Text = cdto.telemovel;
            TextBoxFaxID.Text = cdto.fax;
            TextBoxCcID.Text = cdto.cc;
            TextBoxIbanID.Text = cdto.iban;
            TextBoxNifID.Text = cdto.nif;
            TextBoxLastChangedID.Text = cdto.lastChangeBy;
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaCredor();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c39EdicaoCredor WsEC = new c39EdicaoCredor();
            WsEC.editarCredor(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaCredor()
        {
            ListBoxEntidadesID.Items.Clear();
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
            c40RemocaoCredor WsERL = new c40RemocaoCredor();
            var y = ListBoxEntidadesID.SelectedValue.ToString();
            WsERL.removerCredor(y);
            listaCredor();
        }

        protected void TabCriarCredor_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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