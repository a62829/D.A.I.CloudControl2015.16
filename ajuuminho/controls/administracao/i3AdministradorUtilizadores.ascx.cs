using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.administracao
{
    public partial class i3AdministradorUtilizadores : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void listaUser()
        {
            ListBoxUtilizadoresID.Items.Clear();
            gestaoIdentidade cde = new gestaoIdentidade();
            var lista = cde.getListaUsers();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxUtilizadoresID.Items.Add(Item);

            }
            ListBoxUtilizadoresID.DataBind();
        }

        protected void listaUserDetail ()
        {
            gestaoIdentidade cde = new gestaoIdentidade();
            var dt = cde.getUserDetailById(ListBoxUtilizadoresID.SelectedValue.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TextBoxUsernameID.Text = Convert.ToString(dt.Rows[i]["UserName"]);
                TextBoxTelefoneID.Text = Convert.ToString(dt.Rows[i]["PhoneNumber"]);
                TextBoxEmailID.Text = Convert.ToString(dt.Rows[i]["Email"]);
            }
        }

        protected void TabCriarUtilizador_Click(object sender, EventArgs e)
        {
            EnableAllText(this);
            ClearAllText(this);
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            TrPasswordID.Visible = true;
            TrConfirmarPasswordID.Visible = true;
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            TabCriarUtilizadorID.CssClass = "Clicked";
            TabEditarUtilizadorID.CssClass = "Initial";
            TabEliminarUtilizadorID.CssClass = "Initial";
        }

        protected void TabEditarUtilizador_Click(object sender, EventArgs e)
        {
            listaUser();
            EnableAllText(this);
            ClearAllText(this);
            TrPasswordID.Visible = false;
            TrConfirmarPasswordID.Visible = false;
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            TabCriarUtilizadorID.CssClass = "Initial";
            TabEditarUtilizadorID.CssClass = "Clicked";
            TabEliminarUtilizadorID.CssClass = "Initial";
        }

        protected void TabEliminarUtilizador_Click(object sender, EventArgs e)
        {
            listaUser();
            DisableAllText(this);
            ClearAllText(this);
            TrPasswordID.Visible = false;
            TrConfirmarPasswordID.Visible = false;
            ListBoxVisibility.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox");
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            TabCriarUtilizadorID.CssClass = "Initial";
            TabEditarUtilizadorID.CssClass = "Initial";
            TabEliminarUtilizadorID.CssClass = "Clicked";
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.criarUtilizador(TextBoxUsernameID.Text, TextBoxPasswordID.Text, TextBoxEmailID.Text, TextBoxTelefoneID.Text);
            string mystring = "Utilizador criado com sucesso";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            ClearAllText(this);

        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            if (ListBoxUtilizadoresID.SelectedIndex == -1)
            {
                string mystring = "Primeiro deve seleccionar um utilizador que deseje eliminar.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else
            {
                gestaoIdentidade ws1 = new gestaoIdentidade();
                ws1.editarUtilizador(TextBoxUsernameID.Text, TextBoxEmailID.Text, TextBoxTelefoneID.Text, ListBoxUtilizadoresID.SelectedValue.ToString());
            ClearAllText(this);
            }
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

            if (ListBoxUtilizadoresID.SelectedIndex == -1)
            {
                string mystring = "Primeiro deve seleccionar um utilizador que deseje eliminar.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else
            {
                gestaoIdentidade ws1 = new gestaoIdentidade();
                ws1.eliminarUtilizador(ListBoxUtilizadoresID.SelectedValue.ToString());
                ClearAllText(this);
            }
        }

        protected void TextBoxConfirmarPasswordID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ListBoxUtilizadoresID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaUserDetail();
        }
    }
}