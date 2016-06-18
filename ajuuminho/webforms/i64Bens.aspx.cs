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
    public partial class i64Bens : System.Web.UI.Page
    {
        public string id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

                if (!IsPostBack)
                {
                listaBens();
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

        protected void listaBens()
        {
            //ListBoxParaTabsProcessosID.Items.Clear();
            c65EdicaoBens bdto = new c65EdicaoBens();
            d41InsolventeDto idto = new d41InsolventeDto();
            var x = idto.getListaInsolventeNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d41InsolventeDto> pair in x)
            {
               this.id = pair.Value.id.ToString();
            }
            var y = bdto.getListaBens((string)Session["idProcesso"], this.id);
            foreach (KeyValuePair<String, d63BensDto> pair in y) 
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.descricao.ToString();
                Item.Value = pair.Value.idBens.ToString();
                ListBoxParaTabsProcessosID.Items.Add(Item);
                ListBoxParaTabsProcessosID.DataBind();
            }
        }


        protected void ListBoxParaTabsProcessosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c65EdicaoBens eb = new c65EdicaoBens();
            string idRl = ListBoxParaTabsProcessosID.SelectedValue.ToString();
            d63BensDto bdto = eb.getBem(idRl);
            TextBoxDescricaoID.Text = bdto.descricao;
            TextBoxTipoAtivoID.Text = bdto.idTipoAtivo;
            TextBoxValorAquisicaoID.Text = bdto.valorAquisicao;
            TextBoxValorMercadoID.Text = bdto.valorMercado;
            TextBoxValorLiquidacaoID.Text = bdto.valorLiquidacao;
            //ListBoxParaTabsProcessosID.Items.Clear();
            listaBens();
            ListBoxParaTabsProcessosID.DataBind();
            listaInsolvente();
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

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c65EdicaoBens wseb = new c65EdicaoBens();
            wseb.criarBens(ListBoxParaTabsProcessosID.SelectedValue.ToString(),HiddenFieldInsolventeID.Value.ToString(), TextBoxTipoAtivoID.Text, TextBoxDescricaoID.Text, TextBoxValorAquisicaoID.Text,
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

        protected void DropDownListInsolventeID_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void listaInsolvente()
        {
            var idProcesso = (string)Session["idProcesso"];
            d41InsolventeDto idto = new d41InsolventeDto();
            var insolvente = idto.getListaInsolventeNoProcesso(idProcesso);
            foreach (KeyValuePair<String, d41InsolventeDto> pair in insolvente)
            {
                TextBoxInsolventeID.Text = pair.Value.nome.ToString();
                HiddenFieldInsolventeID.Value = pair.Value.id.ToString();
            }
        }
    }
}