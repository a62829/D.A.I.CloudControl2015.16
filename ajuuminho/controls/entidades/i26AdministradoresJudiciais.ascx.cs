using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i26AdministradoresJudiciais : System.Web.UI.UserControl
    {
        private Dictionary<String, d25AdministradorJudicialDto> lista = new Dictionary<string, d25AdministradorJudicialDto>();

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
            c27EdicaoAdministradorJudicial ws = new c27EdicaoAdministradorJudicial();
            ws.criarAdministradorJudicial(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Administrador Judicial criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaAdministradorJudicial();
            ClearAllText(this);
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial wsaj = new c27EdicaoAdministradorJudicial();
            string ajRl = ListBoxEntidadesID.SelectedValue.ToString();
            var aj = wsaj.getAdministradorJudicial(ajRl);
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
            //listaAdministradorJudicial();
            //ListBoxEntidadesID.DataBind();
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial WsERL = new c27EdicaoAdministradorJudicial();
            WsERL.editarAdministradorJudicial(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
            ClearAllText(this);
            string mystring = "Administrador Judicial criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void listaAdministradorJudicial()
        {
            ListBoxEntidadesID.ClearSelection();
            c27EdicaoAdministradorJudicial WsEAJ = new c27EdicaoAdministradorJudicial();
            this.lista = WsEAJ.getListaAdministradorJudicial();
            foreach (KeyValuePair<String, d25AdministradorJudicialDto> pair in lista)
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
            c28RemocaoAdministradorJudicial WsERL = new c28RemocaoAdministradorJudicial();
            WsERL.removerAdministradorJudicial(ListBoxEntidadesID.SelectedValue.ToString());
            ClearAllText(this);
            ListBoxEntidadesID.ClearSelection();
            ListBoxEntidadesID.Items.Clear();
            listaAdministradorJudicial();
            string mystring = "Administrador Judicial eliminado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarAdministradorJudicial_Click(object sender, EventArgs e)
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
            TabCriarAdministradorJudicialID.CssClass = "Clicked";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            TabPesquisarAdministradorJudicialID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEditarAdministradorJudicial_Click(object sender, EventArgs e)
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
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Clicked";
            TabEliminarAdministradorJudicialID.CssClass = "Initial";
            TabPesquisarAdministradorJudicialID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEliminarAdministradorJudicial_Click(object sender, EventArgs e)
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
            TabCriarAdministradorJudicialID.CssClass = "Initial";
            TabEditarAdministradorJudicialID.CssClass = "Initial";
            TabEliminarAdministradorJudicialID.CssClass = "Clicked";
            TabPesquisarAdministradorJudicialID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabPesquisarAdministradorJudicial_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
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
            ClearAllText(this);
        }
    }
}