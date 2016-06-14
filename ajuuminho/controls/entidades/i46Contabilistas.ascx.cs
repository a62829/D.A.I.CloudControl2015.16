using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i46Contabilistas : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaContabilista();
            }
            else
            {
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c47EdicaoContabilista ws = new c47EdicaoContabilista();
            ws.criarContabilista(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaContabilista();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c47EdicaoContabilista wsc = new c47EdicaoContabilista();
            string cid = ListBoxEntidadesID.SelectedValue.ToString();
            d45ContabilistaDto cdto = wsc.getContabilista(cid);
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
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaContabilista();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c47EdicaoContabilista WsEC = new c47EdicaoContabilista();
            WsEC.editarContabilista(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaContabilista()
        {
            c47EdicaoContabilista WsEC = new c47EdicaoContabilista();
            var lista = WsEC.getListaContabilista();
            foreach (KeyValuePair<String, d45ContabilistaDto> pair in lista)
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

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void TabCriarContabilista_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarContabilistaID.CssClass = "Clicked";
            TabEditarContabilistaID.CssClass = "Initial";
            TabEliminarContabilistaID.CssClass = "Initial";
        }

        protected void TabEditarContabilista_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarContabilistaID.CssClass = "Initial";
            TabEditarContabilistaID.CssClass = "Clicked";
            TabEliminarContabilistaID.CssClass = "Initial";
            TabPesquisarContabilistaID.CssClass = "Initial";
        }

        protected void TabEliminarContabilista_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarContabilistaID.CssClass = "Initial";
            TabEditarContabilistaID.CssClass = "Initial";
            TabEliminarContabilistaID.CssClass = "Clicked";
            TabPesquisarContabilistaID.CssClass = "Initial";
        }

        protected void TabPesquisarContabilista_Click(object sender, EventArgs e)
        {
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarContabilistaID.CssClass = "Initial";
            TabEditarContabilistaID.CssClass = "Initial";
            TabEliminarContabilistaID.CssClass = "Initial";
            TabPesquisarContabilistaID.CssClass = "Clicked";
        }
    }
}
