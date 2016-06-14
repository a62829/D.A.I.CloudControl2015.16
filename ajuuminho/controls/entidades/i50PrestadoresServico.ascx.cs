﻿using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c51EdicaoPrestadorServico ws = new c51EdicaoPrestadorServico();
            ws.criarPrestadorServico(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaPrestadorServico();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c51EdicaoPrestadorServico eps = new c51EdicaoPrestadorServico();
            string idps = ListBoxEntidadesID.SelectedValue.ToString();
            d49PrestadorServicoDto ps = eps.getPrestadorServico(idps);
            TextBoxNomeID.Text = ps.nome;
            TextBoxMoradaID.Text = ps.morada;
            TextBoxCodPostalID.Text = ps.codPostal;
            TextBoxLocalidadeID.Text = ps.localidade;
            TextBoxEmailID.Text = ps.email;
            TextBoxTelefoneID.Text = ps.telefone;
            TextBoxTelemovelID.Text = ps.telemovel;
            TextBoxFaxID.Text = ps.fax;
            TextBoxCcID.Text = ps.cc;
            TextBoxIbanID.Text = ps.iban;
            TextBoxNifID.Text = ps.nif;
            TextBoxLastChangedID.Text = ps.lastChangeBy;
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c51EdicaoPrestadorServico WsEPS = new c51EdicaoPrestadorServico();
            WsEPS.editarPrestadorServico(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaPrestadorServico()
        {
            c51EdicaoPrestadorServico WsEPS = new c51EdicaoPrestadorServico();
            var lista = WsEPS.getListaPrestadorServico();
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

        protected void TabCriarPrestadorServico_Click(object sender, EventArgs e)
        {
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarPrestadorServicoID.CssClass = "Clicked";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            TabPesquisarPrestadorServicoID.CssClass = "Initial";
        }

        protected void TabEditarPrestadorServico_Click(object sender, EventArgs e)
        {
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Clicked";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            TabPesquisarPrestadorServicoID.CssClass = "Initial";
        }

        protected void TabEliminarPrestadorServico_Click(object sender, EventArgs e)
        {
            ViewBoxVisible.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Clicked";
            TabPesquisarPrestadorServicoID.CssClass = "Initial";
        }

        protected void TabPesquisarPrestadorServico_Click(object sender, EventArgs e)
        {
            ViewBoxVisible.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarPrestadorServicoID.CssClass = "Initial";
            TabEditarPrestadorServicoID.CssClass = "Initial";
            TabEliminarPrestadorServicoID.CssClass = "Initial";
            TabPesquisarPrestadorServicoID.CssClass = "Clicked";
        }
    }
}
