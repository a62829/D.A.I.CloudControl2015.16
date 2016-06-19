using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ajuUminho.webforms
{
    public partial class i91CreditosReclamados : System.Web.UI.Page
    {
        public string id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                //listaCredor();
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

        protected void TabCriar_Click(object sender, EventArgs e)
        {
            listaCredor();
            EnableAllText(this);
            TextBoxCredorID.Enabled = false;
            ContentListBox.Visible = true;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Processos");
            DetailsTitleBox.Visible = false;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarID.CssClass = "Clicked";
            TabEditarID.CssClass = "Initial";
            TabEliminarID.CssClass = "Initial";
            TabPesquisarID.CssClass = "Initial";
            DropDownListCredorID.Visible = true;
            ListBoxParaTabsCreditosReclamadosID.Visible = false;
            ClearAllText(this);
        }



        protected void TabEditar_Click(object sender, EventArgs e)
        {
            listaCredor();
            EnableAllText(this);
            TextBoxCredorID.Enabled = false;
            ListBoxParaTabsCreditosReclamadosID.Visible = true;
            ContentListBox.Visible = true;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBoxProcessos");
            DetailsTitleBox.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = true;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarID.CssClass = "Initial";
            TabEditarID.CssClass = "Clicked";
            TabEliminarID.CssClass = "Initial";
            TabPesquisarID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabEliminar_Click(object sender, EventArgs e)
        {
            DisableAllText(this);
            ContentListBox.Visible = true;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBoxProcessos");
            DetailsTitleBox.Visible = true;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = true;
            ButtonPesquisarID.Visible = false;
            TabCriarID.CssClass = "Initial";
            TabEditarID.CssClass = "Initial";
            TabEliminarID.CssClass = "Clicked";
            TabPesquisarID.CssClass = "Initial";
            ClearAllText(this);
        }

        protected void TabPesquisar_Click(object sender, EventArgs e)
        {
            ContentListBox.Visible = false;
            ContentDetailsBox.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Processos");
            DetailsTitleBox.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarID.CssClass = "Initial";
            TabEditarID.CssClass = "Initial";
            TabEliminarID.CssClass = "Initial";
            TabPesquisarID.CssClass = "Clicked";
        }

        protected void listaCreditosReclamados()
        {
            c93EdicaoCreditosReclamados bdto = new c93EdicaoCreditosReclamados();
            var y = bdto.getListaCreditosReclamados((string)Session["idProcesso"], DropDownListCredorID.SelectedValue.ToString());
            ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            foreach (KeyValuePair<String, d90CreditosReclamadosDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.descricao.ToString();
                Item.Value = pair.Value.idCreditoReclamado.ToString();
                ListBoxParaTabsCreditosReclamadosID.Items.Add(Item);
                
            }
            ListBoxParaTabsCreditosReclamadosID.DataBind();
        }

        protected void listaCredor()
        {
            DropDownListCredorID.Items.Clear();
            var idProcesso = (string)Session["idProcesso"];
            d37CredorDto cdto = new d37CredorDto();
            var credor = cdto.getListaCredorNoProcesso(idProcesso);
            foreach (KeyValuePair<String, d37CredorDto> pair in credor)
            {

                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                DropDownListCredorID.Items.Add(Item);
                DropDownListCredorID.DataBind();
                TextBoxCredorID.Text = pair.Value.nome.ToString();
            }
        }

        protected void DropDownListCredorID_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxCredorID.Text = DropDownListCredorID.SelectedItem.Text.ToString();
            
            listaCreditosReclamados();
        }

        protected void ListBoxParaTabsCreditosReclamadosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c93EdicaoCreditosReclamados eb = new c93EdicaoCreditosReclamados();
            string idRl = ListBoxParaTabsCreditosReclamadosID.SelectedValue.ToString();
            d90CreditosReclamadosDto bdto = eb.getCreditoReclamado(idRl);
            HiddenFieldCredorID.Value = bdto.idCredorNoProcesso;
            TextBoxDescricaoID.Text = bdto.descricao;
            TextBoxValorDividaID.Text = bdto.valorDivida;
            TextBoxValorRecebidoID.Text = bdto.valorRecebido;
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            //listaCreditosReclamados();
            ListBoxParaTabsCreditosReclamadosID.DataBind();
            //listaCredor();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c93EdicaoCreditosReclamados wseb = new c93EdicaoCreditosReclamados();
            wseb.editarCreditosReclamados(ListBoxParaTabsCreditosReclamadosID.SelectedValue.ToString(), TextBoxDescricaoID.Text, TextBoxValorDividaID.Text,
                 TextBoxValorRecebidoID.Text, (string)Session["userId"]);
            //ClearAllText(this);
            //ListBoxParaTabsCreditosReclamadosID.ClearSelection();
            ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            listaCreditosReclamados();
            ListBoxParaTabsCreditosReclamadosID.DataBind();
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {
            c95RemocaoCreditosReclamados wseb = new c95RemocaoCreditosReclamados();
            var x = DropDownListCredorID.SelectedValue.ToString();
            wseb.removerCreditoReclamado(ListBoxParaTabsCreditosReclamadosID.SelectedValue.ToString());
            listaCreditosReclamados();
            ListBoxParaTabsCreditosReclamadosID.DataBind();
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d90CreditosReclamadosDto crdto = new d90CreditosReclamadosDto();
            c93EdicaoCreditosReclamados wseb = new c93EdicaoCreditosReclamados();
            var x = DropDownListCredorID.SelectedValue.ToString();
            var y = crdto.getIdCredorNoProcesso((string)Session["idProcesso"], x);
            wseb.criarCreditoReclamado(null, y, TextBoxDescricaoID.Text, TextBoxValorDividaID.Text,
                TextBoxValorRecebidoID.Text, (string)Session["userId"]);
            listaCreditosReclamados();
            ListBoxParaTabsCreditosReclamadosID.DataBind();
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            //listaCreditosReclamados();
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }
    }
}