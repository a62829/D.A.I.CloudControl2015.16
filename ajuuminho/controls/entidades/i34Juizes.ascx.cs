using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using _BusinessLayer;

namespace ajuUminho.controls.entidades
{
    public partial class i34Juizes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaJuiz();
            }
            else
            {

            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c35EdicaoJuiz ws = new c35EdicaoJuiz();
            ws.criarJuiz(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaJuiz();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c35EdicaoJuiz wsj = new c35EdicaoJuiz();
            string idj = ListBoxEntidadesID.SelectedValue.ToString();
            d33JuizDto jdto = wsj.getJuiz(idj);
            TextBoxNomeID.Text = jdto.nome;
            TextBoxMoradaID.Text = jdto.morada;
            TextBoxCodPostalID.Text = jdto.codPostal;
            TextBoxLocalidadeID.Text = jdto.localidade;
            TextBoxEmailID.Text = jdto.email;
            TextBoxTelefoneID.Text = jdto.telefone;
            TextBoxTelemovelID.Text = jdto.telemovel;
            TextBoxFaxID.Text = jdto.fax;
            TextBoxCcID.Text = jdto.cc;
            TextBoxIbanID.Text = jdto.iban;
            TextBoxNifID.Text = jdto.nif;
            TextBoxLastChangedID.Text = jdto.lastChangeBy;
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c35EdicaoJuiz WsEJ = new c35EdicaoJuiz();
            WsEJ.editarJuiz(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaJuiz()
        {
            ListBoxEntidadesID.Items.Clear();
            c35EdicaoJuiz WsEJ = new c35EdicaoJuiz();
            var lista = WsEJ.getListaJuiz();
            foreach (KeyValuePair<String, d33JuizDto> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {
            c36RemocaoJuiz WsERL = new c36RemocaoJuiz();
            var y = ListBoxEntidadesID.SelectedValue.ToString();
            WsERL.removerJuiz(y);
            listaJuiz();
        }

        protected void TabCriarJuiz_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarJuizID.CssClass = "Clicked";
            TabEditarJuizID.CssClass = "Initial";
            TabEliminarJuizID.CssClass = "Initial";
            TabPesquisarJuizID.CssClass = "Initial";
        }

        protected void TabEditarJuiz_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarJuizID.CssClass = "Initial";
            TabEditarJuizID.CssClass = "Clicked";
            TabEliminarJuizID.CssClass = "Initial";
            TabPesquisarJuizID.CssClass = "Initial";
        }

        protected void TabEliminarJuiz_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarJuizID.CssClass = "Initial";
            TabEditarJuizID.CssClass = "Initial";
            TabEliminarJuizID.CssClass = "Clicked";
            TabPesquisarJuizID.CssClass = "Initial";
        }

        protected void TabPesquisarJuiz_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarJuizID.CssClass = "Initial";
            TabEditarJuizID.CssClass = "Initial";
            TabEliminarJuizID.CssClass = "Initial";
            TabPesquisarJuizID.CssClass = "Clicked";
        }
    }
}