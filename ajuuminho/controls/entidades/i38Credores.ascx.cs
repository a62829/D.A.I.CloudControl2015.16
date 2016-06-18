﻿using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i38Credores : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaCredor();
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
            c39EdicaoCredor ws = new c39EdicaoCredor();
            ws.criarCredor(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaCredor();
            ClearAllText(this);
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c39EdicaoCredor wsc = new c39EdicaoCredor();
            string idc = ListBoxEntidadesID.SelectedValue.ToString();
            d37CredorDto cdto = wsc.getCredor(idc);
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
            //listaCredor();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            ListBoxEntidadesID.ClearSelection();
            c39EdicaoCredor WsEC = new c39EdicaoCredor();
            WsEC.editarCredor(ListBoxEntidadesID.SelectedValue.ToString(), TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
            ClearAllText(this);
        }

        protected void listaCredor()
        {
            c39EdicaoCredor WsERL = new c39EdicaoCredor();
            var lista = WsERL.getListaCredor();
            foreach (KeyValuePair<String, d37CredorDto> pair in lista)
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
            ListBoxEntidadesID.ClearSelection();
            c40RemocaoCredor WsERL = new c40RemocaoCredor();
            WsERL.removerCredor(ListBoxEntidadesID.SelectedValue.ToString());
            ClearAllText(this);
        }

        protected void TabCriarCredor_Click(object sender, EventArgs e)
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
            TabCriarCredorID.CssClass = "Clicked";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEditarCredor_Click(object sender, EventArgs e)
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
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Clicked";
            TabEliminarCredorID.CssClass = "Initial";
            TabPesquisarCredorID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEliminarCredor_Click(object sender, EventArgs e)
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
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Clicked";
            TabPesquisarCredorID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabPesquisarCredor_Click(object sender, EventArgs e)
        {
            ViewsBoxNoPadding.Attributes.Add("class", "ViewsBox");
            ListBoxVisibility.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2");
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarCredorID.CssClass = "Initial";
            TabEditarCredorID.CssClass = "Initial";
            TabEliminarCredorID.CssClass = "Initial";
            TabPesquisarCredorID.CssClass = "Clicked";
            ClearAllText(this);
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }
    }
}