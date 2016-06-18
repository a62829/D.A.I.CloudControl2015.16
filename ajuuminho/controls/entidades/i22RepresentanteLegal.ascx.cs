using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i22RepresentanteLegal : System.Web.UI.UserControl
    {
        private Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<string, d21RepresentanteLegalDto>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                listaRepresentanteLegal();
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
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
                ws.criarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                    TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                    TextBoxNifID.Text, TextBoxLastChangedID.Text);
                string mystring = "Representante Legal criado com sucesso.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);

                ClearAllText(this);

                ListBoxEntidadesID.Items.Clear();
                listaRepresentanteLegal();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal erl = new c23EditarRepresentanteLegal();
            string idRl = ListBoxEntidadesID.SelectedValue.ToString();
            d21RepresentanteLegalDto rl = erl.getRepresentanteLegal(idRl);
            TextBoxNomeID.Text = rl.nome;
            TextBoxMoradaID.Text = rl.morada;
            TextBoxCodPostalID.Text = rl.codPostal;
            TextBoxLocalidadeID.Text = rl.localidade;
            TextBoxEmailID.Text = rl.email;
            TextBoxTelefoneID.Text = rl.telefone;
            TextBoxTelemovelID.Text = rl.telemovel;
            TextBoxFaxID.Text = rl.fax;
            TextBoxCcID.Text = rl.cc;
            TextBoxIbanID.Text = rl.iban;
            TextBoxNifID.Text = rl.nif;
            TextBoxLastChangedID.Text = rl.lastChangeBy;
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal WsERL = new c23EditarRepresentanteLegal();
            WsERL.editarRepresentanteLegal(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            ListBoxEntidadesID.Items.Clear();
            listaRepresentanteLegal();
            ListBoxEntidadesID.DataBind();
            ClearAllText(this);
            //ListBoxEntidadesID.ClearSelection();
        }

        protected void listaRepresentanteLegal()
        {
            ListBoxEntidadesID.Items.Clear();
            c23EditarRepresentanteLegal WsERL = new c23EditarRepresentanteLegal();
            this.lista = WsERL.getListaRepresentanteLegal();
            foreach (KeyValuePair<String, d21RepresentanteLegalDto> pair in lista)
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
            c24RemocaoRepresentanteLegal WsERL = new c24RemocaoRepresentanteLegal();
            var y = ListBoxEntidadesID.SelectedValue.ToString();
            WsERL.removerRepresentanteLegal(y);
            listaRepresentanteLegal();
            ClearAllText(this);
            //ListBoxEntidadesID.ClearSelection();
            string mystring = "Representante Legal eliminado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void TabCriarRepresentanteLegal_Click(object sender, EventArgs e)
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
            TabCriarRepresentanteLegalID.CssClass = "Clicked";
            TabEditarRepresentanteLegalID.CssClass = "Initial";
            TabEliminarRepresentanteLegalID.CssClass = "Initial";
            TabPesquisarRepresentanteLegalID.CssClass = "Initial";

            ClearAllText(this);
        }

        protected void TabEditarRepresentanteLegal_Click(object sender, EventArgs e)
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
            TabCriarRepresentanteLegalID.CssClass = "Initial";
            TabEditarRepresentanteLegalID.CssClass = "Clicked";
            TabEliminarRepresentanteLegalID.CssClass = "Initial";
            TabPesquisarRepresentanteLegalID.CssClass = "Initial";

            ClearAllText(this);
        }

        protected void TabEliminarRepresentanteLegal_Click(object sender, EventArgs e)
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
            TabCriarRepresentanteLegalID.CssClass = "Initial";
            TabEditarRepresentanteLegalID.CssClass = "Initial";
            TabEliminarRepresentanteLegalID.CssClass = "Clicked";
            TabPesquisarRepresentanteLegalID.CssClass = "Initial";

            ClearAllText(this);
        }

        protected void TabPesquisarRepresentanteLegal_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarRepresentanteLegalID.CssClass = "Initial";
            TabEditarRepresentanteLegalID.CssClass = "Initial";
            TabEliminarRepresentanteLegalID.CssClass = "Initial";
            TabPesquisarRepresentanteLegalID.CssClass = "Clicked";

            ClearAllText(this);
        }
    }
}