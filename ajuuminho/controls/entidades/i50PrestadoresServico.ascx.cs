using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i50PrestadoresServico : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaPrestadorServico();
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
            c51EdicaoPrestadorServico ws = new c51EdicaoPrestadorServico();
            ws.criarPrestadorServico(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Prestador de Serviço criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaPrestadorServico();
            ClearAllText(this);
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c51EdicaoPrestadorServico wsps = new c51EdicaoPrestadorServico();
            string psid = ListBoxEntidadesID.SelectedValue.ToString();
            d49PrestadorServicoDto psdto = wsps.getPrestadorServico(psid);
            TextBoxNomeID.Text = psdto.nome;
            TextBoxMoradaID.Text = psdto.morada;
            TextBoxCodPostalID.Text = psdto.codPostal;
            TextBoxLocalidadeID.Text = psdto.localidade;
            TextBoxEmailID.Text = psdto.email;
            TextBoxTelefoneID.Text = psdto.telefone;
            TextBoxTelemovelID.Text = psdto.telemovel;
            TextBoxFaxID.Text = psdto.fax;
            TextBoxCcID.Text = psdto.cc;
            TextBoxIbanID.Text = psdto.iban;
            TextBoxNifID.Text = psdto.nif;
            TextBoxLastChangedID.Text = psdto.lastChangeBy;
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c51EdicaoPrestadorServico WsEPS = new c51EdicaoPrestadorServico();
            WsEPS.editarPrestadorServico(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
            ClearAllText(this);
            ListBoxEntidadesID.ClearSelection();
            ListBoxEntidadesID.Items.Clear();
            listaPrestadorServico();
            string mystring = "Prestador de Serviço editado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void listaPrestadorServico()
        {
            c51EdicaoPrestadorServico WsEPS = new c51EdicaoPrestadorServico();
            var lista = WsEPS.getListaPrestadorServico();
            foreach (KeyValuePair<String, d49PrestadorServicoDto> pair in lista)
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
            c52RemocaoPrestadorServico WsERL = new c52RemocaoPrestadorServico();
            WsERL.removerPrestadorServico(ListBoxEntidadesID.SelectedValue.ToString());
            ClearAllText(this);
            ListBoxEntidadesID.ClearSelection();
            ListBoxEntidadesID.Items.Clear();
            listaPrestadorServico();
            string mystring = "Prestador de Serviço eliminado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarPrestadorServico_Click(object sender, EventArgs e)
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
            TabCriarPrestadorServicoID.CssClass = "Clicked";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            TabPesquisarPrestadorServicoID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEditarPrestadorServico_Click(object sender, EventArgs e)
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
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Clicked";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            TabPesquisarPrestadorServicoID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEliminarPrestadorServico_Click(object sender, EventArgs e)
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
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Clicked";
            TabPesquisarPrestadorServicoID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabPesquisarPrestadorServico_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            TabPesquisarPrestadorServicoID.CssClass = "Clicked";
            ClearAllText(this);
        }
    }
}
