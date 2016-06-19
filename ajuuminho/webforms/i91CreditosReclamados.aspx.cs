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
                listaCredor();
            }
            else
            {

            }

        }

        protected void TabCriar_Click(object sender, EventArgs e)
        {
            ContentListBox.Visible = false;
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
        }

        protected void TabEditar_Click(object sender, EventArgs e)
        {
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
        }

        protected void TabEliminar_Click(object sender, EventArgs e)
        {
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
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            c93EdicaoCreditosReclamados bdto = new c93EdicaoCreditosReclamados();
            //d37CredorDto cdto = new d37CredorDto();
            //var x = cdto.getListaCredorNoProcesso((string)Session["idProcesso"]);
            //foreach (KeyValuePair<String, d37CredorDto> pair in x)
            //{
            //    this.id = pair.Value.id.ToString();
            //}
            var y = bdto.getListaCreditosReclamados((string)Session["idProcesso"], DropDownListCredorID.SelectedValue.ToString());
            foreach (KeyValuePair<String, d90CreditosReclamadosDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.descricao.ToString();
                Item.Value = pair.Value.idCreditoReclamado.ToString();
                ListBoxParaTabsCreditosReclamadosID.Items.Add(Item);
                ListBoxParaTabsCreditosReclamadosID.DataBind();
            }
        }

        protected void listaCredor()
        {
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
                //TextBoxCredorID.Text = pair.Value.nome.ToString();
                //HiddenFieldCredorID.Value = pair.Value.id.ToString();
            }
        }

        protected void DropDownListCredorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxCredorID.Text = DropDownListCredorID.SelectedItem.Text.ToString();
            HiddenFieldCredorID.Value = DropDownListCredorID.SelectedValue.ToString();
            listaCreditosReclamados();
        }

        protected void ListBoxParaTabsCreditosReclamadosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c93EdicaoCreditosReclamados eb = new c93EdicaoCreditosReclamados();
            string idRl = ListBoxParaTabsCreditosReclamadosID.SelectedValue.ToString();
            d90CreditosReclamadosDto bdto = eb.getCreditoReclamado(idRl);
            TextBoxCredorID.Text = bdto.idCredorNoProcesso;
            TextBoxDescricaoID.Text = bdto.descricao;
            TextBoxValorDividaID.Text = bdto.valorDivida;
            TextBoxValorRecebidoID.Text = bdto.valorRecebido;
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            listaCreditosReclamados();
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
            //    c24RemocaoRepresentanteLegal WsERL = new c24RemocaoRepresentanteLegal();
            //    var y = ListBoxEntidadesID.SelectedValue.ToString();
            //    WsERL.removerRepresentanteLegal(y);
            //    listaRepresentanteLegal();
            //    ClearAllText(this);
            //    ListBoxEntidadesID.ClearSelection();
            //    string mystring = "Representante Legal eliminado com sucesso.";
            //    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c93EdicaoCreditosReclamados wseb = new c93EdicaoCreditosReclamados();
            wseb.criarCreditoReclamado(ListBoxParaTabsCreditosReclamadosID.SelectedValue.ToString(), HiddenFieldCredorID.Value.ToString(), TextBoxDescricaoID.Text, TextBoxValorDividaID.Text,
                TextBoxValorRecebidoID.Text, (string)Session["userId"]);
            listaCreditosReclamados();
            ListBoxParaTabsCreditosReclamadosID.DataBind();
            //ClearAllText(this);
            //ListBoxParaTabsCreditosReclamadosID.ClearSelection();
            //string mystring = "Representante Legal criado com sucesso.";
            //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);

            //ClearAllText(this);
            ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            listaCreditosReclamados();
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }
    }
}