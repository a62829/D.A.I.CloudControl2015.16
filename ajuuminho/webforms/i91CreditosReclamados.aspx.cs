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
                //listaBens();
            }
            else
            {

            }

        }

        protected void TabCriar_Click(object sender, EventArgs e)
        {
            ContentListBox.Visible = false;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Bens");
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
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Bens");
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
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Bens");
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
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Bens");
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
            //ListBoxParaTabsProcessosID.Items.Clear();
            c93EdicaoCreditosReclamados bdto = new c93EdicaoCreditosReclamados();
            d37CredorDto cdto = new d37CredorDto();
            var x = cdto.getListaCredorNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d37CredorDto> pair in x)
            {
                this.id = pair.Value.id.ToString();
            }
            var y = bdto.getListaCreditosReclamados((string)Session["idProcesso"], this.id);
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
                TextBoxCredorID.Text = pair.Value.nome.ToString();
                HiddenFieldCredorID.Value = pair.Value.id.ToString();
            }
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
            //ListBoxParaTabsProcessosID.Items.Clear();
            listaCreditosReclamados();
            ListBoxParaTabsCreditosReclamadosID.DataBind();
            listaCredor();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c65EdicaoBens wseb = new c65EdicaoBens();
            wseb.editarBens(ListBoxParaTabsProcessosID.SelectedValue.ToString(), TextBoxTipoAtivoID.Text, TextBoxDescricaoID.Text, TextBoxValorAquisicaoID.Text,
                TextBoxValorMercadoID.Text, TextBoxValorLiquidacaoID.Text, (string)Session["userId"]);
            //ClearAllText(this);
            //ListBoxParaTabsProcessosID.ClearSelection();
            ListBoxParaTabsProcessosID.Items.Clear();
            listaBens();
            ListBoxParaTabsProcessosID.DataBind();
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

        protected void ButtonGuardarID_Click(object sender, EventArgs e)
        {
            c65EdicaoBens wseb = new c65EdicaoBens();
            wseb.criarBens(ListBoxParaTabsProcessosID.SelectedValue.ToString(), HiddenFieldInsolventeID.Value.ToString(), TextBoxTipoAtivoID.Text, TextBoxDescricaoID.Text, TextBoxValorAquisicaoID.Text,
                TextBoxValorMercadoID.Text, TextBoxValorLiquidacaoID.Text, (string)Session["userId"]);
            listaBens();
            ListBoxParaTabsProcessosID.DataBind();
            //ClearAllText(this);
            //ListBoxParaTabsProcessosID.ClearSelection();
            //string mystring = "Representante Legal criado com sucesso.";
            //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);

            //ClearAllText(this);
            ListBoxParaTabsProcessosID.Items.Clear();
            listaBens();
        }
    }
}