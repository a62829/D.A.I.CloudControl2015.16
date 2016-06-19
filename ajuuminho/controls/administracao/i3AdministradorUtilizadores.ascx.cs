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

            //if ( (TextBoxUsernameID.Text=="") ||
            //     (TextBoxPasswordID.Text == "") ||
            //     (TextBoxConfirmarPasswordID.Text == "") ||
            //     (TextBoxEmailID.Text == "") ||
            //     (TextBoxTelefoneID.Text == ""))

            //    {
            //    string mystring = "Deve preencher todos os campos.";
            //    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);

            //    }

            //else
            //{
                gestaoIdentidade ws1 = new gestaoIdentidade();
                //if (TextBoxPasswordID.Text == TextBoxConfirmarPasswordID.Text)
                //{
                    ws1.criarUtilizador(TextBoxUsernameID.Text, TextBoxPasswordID.Text, TextBoxEmailID.Text, TextBoxTelefoneID.Text);
                    string mystring = "Utilizador criado com sucesso";
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
                    ClearAllText(this);
                //}
                //else {
                //    string mystring = "Confirmação da Password incorrecta";
                //    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
                //}
            //}
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            if (ListBoxEntidadesID.SelectedIndex == -1)
            {
                string mystring = "Primeiro deve seleccionar um utilizador que deseje editar.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else
            {

                if ((TextBoxUsernameID.Text == "") ||
                    (TextBoxEmailID.Text == "") ||
                    (TextBoxTelefoneID.Text == ""))
                {
                    string mystring = "Todos os campos devem estar preenchidos.";
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
                }
                else
                {
                    //////// CODIGO AQUI
                    ClearAllText(this);

                }


            }
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

            if (ListBoxEntidadesID.SelectedIndex == -1)
            {
                string mystring = "Primeiro deve seleccionar um utilizador que deseje eliminar.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else
            {
                //////// CODIGO AQUI
                ClearAllText(this);
            }
        }

        protected void TextBoxConfirmarPasswordID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}