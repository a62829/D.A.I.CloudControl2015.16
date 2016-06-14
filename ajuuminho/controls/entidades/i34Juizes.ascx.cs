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
            c35EdicaoJuiz ej = new c35EdicaoJuiz();
            string idj = ListBoxEntidadesID.SelectedValue.ToString();
            d33JuizDto j = ej.getJuiz(idj);
            TextBoxNomeID.Text = j.nome;
            TextBoxMoradaID.Text = j.morada;
            TextBoxCodPostalID.Text = j.codPostal;
            TextBoxLocalidadeID.Text = j.localidade;
            TextBoxEmailID.Text = j.email;
            TextBoxTelefoneID.Text = j.telefone;
            TextBoxTelemovelID.Text = j.telemovel;
            TextBoxFaxID.Text = j.fax;
            TextBoxCcID.Text = j.cc;
            TextBoxIbanID.Text = j.iban;
            TextBoxNifID.Text = j.nif;
            TextBoxLastChangedID.Text = j.lastChangeBy;
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c35EdicaoJuiz WsEJ = new c35EdicaoJuiz();
            WsEJ.editarJuiz(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaJuiz()
        {
            c35EdicaoJuiz WsEJ = new c35EdicaoJuiz();
            var lista = WsEJ.getListaJuiz();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarJuiz_Click(object sender, EventArgs e)
        {
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