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
    public partial class i75ServicosExternos : System.Web.UI.Page
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
            listaPrestadorServico();
            EnableAllText(this);
            TextBoxPrestadorServicosID.Enabled = false;
            ContentListBox.Visible = true;
            ContentListBox.Attributes.Add("class", "i91CreditosReclamados");
            br1.Visible = false;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "i91CreditosReclamadosDropdown");
            DetailsTitleBox2.Visible = false;
            DetailsTitleBox2.Visible = false;
            DetailsTitleBoxCriar.Visible = true;
            ButtonCriarID.Visible = true;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarID.CssClass = "Clicked";
            TabEditarID.CssClass = "Initial";
            TabEliminarID.CssClass = "Initial";
            TabPesquisarID.CssClass = "Initial";
            DropDownListPrestadorServicoID.Visible = true;
            ListBoxParaTabsPrestacaoServicosID.Visible = false;
            ClearAllText(this);
        }



        protected void TabEditar_Click(object sender, EventArgs e)
        {
            listaPrestadorServico();
            EnableAllText(this);
            TextBoxPrestadorServicosID.Enabled = false;
            ListBoxParaTabsPrestacaoServicosID.Visible = true;
            ContentListBox.Visible = true;
            ContentListBox.Attributes.Add("class", "InsideViewsTableBoxBens");
            br1.Visible = true;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBoxProcessos");
            DetailsTitleBox1.Visible = true;
            DetailsTitleBox2.Visible = true;
            DetailsTitleBoxCriar.Visible = false;
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
            ContentListBox.Attributes.Add("class", "InsideViewsTableBoxBens");
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBoxProcessos");
            br1.Visible = true;
            DetailsTitleBox1.Visible = true;
            DetailsTitleBox2.Visible = true;
            DetailsTitleBoxCriar.Visible = false;
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
            ContentListBox.Attributes.Add("class", "InsideViewsTableBoxBens");
            ContentDetailsBox.Visible = false;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Processos");
            br1.Visible = false;
            DetailsTitleBox1.Visible = false;
            DetailsTitleBox2.Visible = false;
            DetailsTitleBoxCriar.Visible = false;
            ButtonCriarID.Visible = false;
            ButtonEditarID.Visible = false;
            ButtonEliminarID.Visible = false;
            ButtonPesquisarID.Visible = false;
            TabCriarID.CssClass = "Initial";
            TabEditarID.CssClass = "Initial";
            TabEliminarID.CssClass = "Initial";
            TabPesquisarID.CssClass = "Clicked";
        }

        protected void listaPrestacoesServicos()
        {
            c76EdicaoServicosExternos wsse = new c76EdicaoServicosExternos();
            var y = wsse.getListaPrestacoesServicos((string)Session["idProcesso"], DropDownListPrestadorServicoID.SelectedValue.ToString());
            ListBoxParaTabsPrestacaoServicosID.Items.Clear();
            foreach (KeyValuePair<String, d74ServicosExternosDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.descricao.ToString();
                Item.Value = pair.Value.idPrestacaoServico.ToString();
                ListBoxParaTabsPrestacaoServicosID.Items.Add(Item);

            }
            ListBoxParaTabsPrestacaoServicosID.DataBind();
        }

        protected void listaPrestadorServico()
        {
            DropDownListPrestadorServicoID.Items.Clear();
            var idProcesso = (string)Session["idProcesso"];
            d49PrestadorServicoDto psdto = new d49PrestadorServicoDto();
            var prestadorServico = psdto.getListaPrestadorServicoNoProcesso(idProcesso);
            foreach (KeyValuePair<String, d49PrestadorServicoDto> pair in prestadorServico)
            {

                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                DropDownListPrestadorServicoID.Items.Add(Item);
                DropDownListPrestadorServicoID.DataBind();
                TextBoxPrestadorServicosID.Text = pair.Value.nome.ToString();
            }
        }

        protected void DropDownListPrestadorServicoID_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxPrestadorServicosID.Text = DropDownListPrestadorServicoID.SelectedItem.Text.ToString();

            listaPrestacoesServicos();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c76EdicaoServicosExternos wsps = new c76EdicaoServicosExternos();
            wsps.editarServicosExternos(ListBoxParaTabsPrestacaoServicosID.SelectedValue.ToString(), TextBoxDescricaoID.Text, TextBoxValorPagarID.Text,
                 TextBoxValorPagoID.Text, (string)Session["userId"]);
            //ClearAllText(this);
            //ListBoxParaTabsCreditosReclamadosID.ClearSelection();
            ListBoxParaTabsPrestacaoServicosID.Items.Clear();
            listaPrestacoesServicos();
            ListBoxParaTabsPrestacaoServicosID.DataBind();
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {
            c77RemocaoServicosExternos wseb = new c77RemocaoServicosExternos();
            var x = DropDownListPrestadorServicoID.SelectedValue.ToString();
            wseb.removerPrestacaoServico(ListBoxParaTabsPrestacaoServicosID.SelectedValue.ToString());
            listaPrestacoesServicos();
            ListBoxParaTabsPrestacaoServicosID.DataBind();
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d74ServicosExternosDto crdto = new d74ServicosExternosDto();
            c76EdicaoServicosExternos wseb = new c76EdicaoServicosExternos();
            var x = DropDownListPrestadorServicoID.SelectedValue.ToString();
            var y = crdto.getIdPrestadorServicoNoProcesso((string)Session["idProcesso"], x);
            wseb.criarPrestacaoServico(null, y, TextBoxDescricaoID.Text, TextBoxValorPagarID.Text,
                TextBoxValorPagoID.Text, (string)Session["userId"]);
            listaPrestacoesServicos();
            ListBoxParaTabsPrestacaoServicosID.DataBind();
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            //listaCreditosReclamados();
        }

        protected void ButtonPesquisarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEditarID_Click1(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminarID_Click1(object sender, EventArgs e)
        {

        }

        protected void ButtonPesquisarID_Click1(object sender, EventArgs e)
        {

        }

        protected void ListBoxParaTabsPrestacaoServicosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c76EdicaoServicosExternos wsps = new c76EdicaoServicosExternos();
            string idRl = ListBoxParaTabsPrestacaoServicosID.SelectedValue.ToString();
            d74ServicosExternosDto bdto = wsps.getServicoExterno(idRl);
            HiddenFieldPrestadorServicosID.Value = bdto.idPrestadorServicoNoProcesso;
            TextBoxDescricaoID.Text = bdto.descricao;
            TextBoxValorPagarID.Text = bdto.valorPagar;
            TextBoxValorPagoID.Text = bdto.valorPago;
            //ListBoxParaTabsCreditosReclamadosID.Items.Clear();
            //listaCreditosReclamados();
            ListBoxParaTabsPrestacaoServicosID.DataBind();
            //listaCredor();
        }
    }
}