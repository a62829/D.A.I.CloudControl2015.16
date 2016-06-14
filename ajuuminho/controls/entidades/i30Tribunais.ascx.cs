using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i30Tribunais : System.Web.UI.UserControl
    {
        private Dictionary<String, d29TribunalDto> lista = new Dictionary<string, d29TribunalDto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaTribunal();
            }
            else
            {

            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c31EdicaoTribunal ws = new c31EdicaoTribunal();
            ws.criarTribunal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaTribunal();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c31EdicaoTribunal et = new c31EdicaoTribunal();
            string idt = ListBoxEntidadesID.SelectedValue.ToString();
            d29TribunalDto t = et.getTribunal(idt);
            TextBoxNomeID.Text = t.nome;
            TextBoxMoradaID.Text = t.morada;
            TextBoxCodPostalID.Text = t.codPostal;
            TextBoxLocalidadeID.Text = t.localidade;
            TextBoxEmailID.Text = t.email;
            TextBoxTelefoneID.Text = t.telefone;
            TextBoxTelemovelID.Text = t.telemovel;
            TextBoxFaxID.Text = t.fax;
            TextBoxIbanID.Text = t.iban;
            TextBoxNifID.Text = t.nif;
            TextBoxLastChangedID.Text = t.lastChangeBy;
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c31EdicaoTribunal WsET = new c31EdicaoTribunal();
            WsET.editarTribunal(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaTribunal()
        {
            c31EdicaoTribunal WsET = new c31EdicaoTribunal();
            this.lista = WsET.getListaTribunal();
            foreach (KeyValuePair<String, d29TribunalDto> pair in lista)
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

        protected void TabCriarTribunal_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarTribunalID.CssClass = "Clicked";
            TabEditarTribunalID.CssClass = "Initial";
            TabEliminarTribunalID.CssClass = "Initial";
        }

        protected void TabEditarTribunal_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarTribunalID.CssClass = "Initial";
            TabEditarTribunalID.CssClass = "Clicked";
            TabEliminarTribunalID.CssClass = "Initial";
            TabPesquisarTribunalID.CssClass = "Initial";
        }

        protected void TabEliminarTribunal_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarTribunalID.CssClass = "Initial";
            TabEditarTribunalID.CssClass = "Initial";
            TabEliminarTribunalID.CssClass = "Clicked";
            TabPesquisarTribunalID.CssClass = "Initial";
        }

        protected void TabPesquisarTribunal_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarTribunalID.CssClass = "Initial";
            TabEditarTribunalID.CssClass = "Initial";
            TabEliminarTribunalID.CssClass = "Initial";
            TabPesquisarTribunalID.CssClass = "Clicked";
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }
    }
}