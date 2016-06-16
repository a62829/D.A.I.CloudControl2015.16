using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i54OutrasEntidades : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaOutraEntidade();
            }
            else
            {

            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c55RemocaoOutraEntidade oe = new c55RemocaoOutraEntidade();
            oe.criarOutraEntidade(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Outra Entidade criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c55RemocaoOutraEntidade wsoe = new c55RemocaoOutraEntidade();
            string oeid = ListBoxEntidadesID.SelectedValue.ToString();
            d53OutraEntidadeDto oedto = wsoe.getOutraEntidade(oeid);
            TextBoxNomeID.Text = oedto.nome;
            TextBoxMoradaID.Text = oedto.morada;
            TextBoxCodPostalID.Text = oedto.codPostal;
            TextBoxLocalidadeID.Text = oedto.localidade;
            TextBoxEmailID.Text = oedto.email;
            TextBoxTelefoneID.Text = oedto.telefone;
            TextBoxTelemovelID.Text = oedto.telemovel;
            TextBoxFaxID.Text = oedto.fax;
            TextBoxCcID.Text = oedto.cc;
            TextBoxIbanID.Text = oedto.iban;
            TextBoxNifID.Text = oedto.nif;
            TextBoxLastChangedID.Text = oedto.lastChangeBy;
            ListBoxEntidadesID.Items.Clear();
            listaOutraEntidade();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c55RemocaoOutraEntidade WsEOE = new c55RemocaoOutraEntidade();
            WsEOE.editarOutraEntidade(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaOutraEntidade()
        {
            c55RemocaoOutraEntidade WsEOE = new c55RemocaoOutraEntidade();
            var lista = WsEOE.getListaOutraEntidade();
            foreach (KeyValuePair<String, d53OutraEntidadeDto> pair in lista)
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
            c55RemocaoOutraEntidade WsERL = new c55RemocaoOutraEntidade();
            WsERL.removerOutraEntidade(ListBoxEntidadesID.SelectedValue.ToString());
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarOutraEntidade_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarOutraEntidadeID.CssClass = "Clicked";
            TabEditarOutraEntidadeID.CssClass = "Initial";
            TabEliminarOutraEntidadeID.CssClass = "Initial";
        }

        protected void TabEditarOutraEntidade_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarOutraEntidadeID.CssClass = "Initial";
            TabEditarOutraEntidadeID.CssClass = "Clicked";
            TabEliminarOutraEntidadeID.CssClass = "Initial";
            TabPesquisarOutraEntidadeID.CssClass = "Initial";
        }

        protected void TabEliminarOutraEntidade_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarOutraEntidadeID.CssClass = "Initial";
            TabEditarOutraEntidadeID.CssClass = "Initial";
            TabEliminarOutraEntidadeID.CssClass = "Clicked";
            TabPesquisarOutraEntidadeID.CssClass = "Initial";
        }

        protected void TabPesquisarOutraEntidade_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarOutraEntidadeID.CssClass = "Initial";
            TabEditarOutraEntidadeID.CssClass = "Initial";
            TabEliminarOutraEntidadeID.CssClass = "Initial";
            TabPesquisarOutraEntidadeID.CssClass = "Clicked";
        }

    }
}