using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i26AdministradoresJudiciais : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaAdministradorJudicial();
            }
            else
            {

            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial ws = new c27EdicaoAdministradorJudicial();
            ws.criarAdministradorJudicial(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaAdministradorJudicial();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial eaj = new c27EdicaoAdministradorJudicial();
            string idaj = ListBoxEntidadesID.SelectedValue.ToString();
            d25AdministradorJudicialDto aj = eaj.getAdministradorJudicial(idaj);
            TextBoxNomeID.Text = aj.nome;
            TextBoxMoradaID.Text = aj.morada;
            TextBoxCodPostalID.Text = aj.codPostal;
            TextBoxLocalidadeID.Text = aj.localidade;
            TextBoxEmailID.Text = aj.email;
            TextBoxTelefoneID.Text = aj.telefone;
            TextBoxTelemovelID.Text = aj.telemovel;
            TextBoxFaxID.Text = aj.fax;
            TextBoxCcID.Text = aj.cc;
            TextBoxIbanID.Text = aj.iban;
            TextBoxNifID.Text = aj.nif;
            TextBoxLastChangedID.Text = aj.lastChangeBy;
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial WsEAJ = new c27EdicaoAdministradorJudicial();
            WsEAJ.editarAdministradorJudicial(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaAdministradorJudicial()
        {
            c27EdicaoAdministradorJudicial WsEAJ = new c27EdicaoAdministradorJudicial();
            var lista = WsEAJ.getListaAdministradorJudicial();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarAdministradorJudicialID.CssClass = "Clicked";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            TabPesquisarAdministradorJudicialID.CssClass = "Initial";
        }

        protected void TabEditarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Clicked";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            TabPesquisarAdministradorJudicialID.CssClass = "Initial";
        }

        protected void TabEliminarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Clicked";
            TabPesquisarAdministradorJudicialID.CssClass = "Initial";
        }

        protected void TabPesquisarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            TabPesquisarAdministradorJudicialID.CssClass = "Clicked";
        }
    }
}