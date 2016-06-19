using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BusinessLayer;
using ajuUminho.Ws;

namespace ajuUminho.webforms
{
    public partial class i60Eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                if (!IsPostBack)
                {
                listaEventos();
            }
                else {
                
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

        protected void ListBoxParaTabsProcessosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c61EdicaoEventos ee = new c61EdicaoEventos();
            string idEv = ListBoxParaTabsProcessosID.SelectedValue.ToString();
            d59EventoDto edto = ee.getEvento(idEv);
            TextBoxDataID.Text = edto.dataEvento;
            TextBoxDescricaoID.Text = edto.descricao;
            TextBoxTipoEventoID.Text = edto.idTipoEvento;
            //listaEventos();
            //ListBoxParaTabsProcessosID.DataBind();
        }

        protected void listaEventos()
        {
            ListBoxParaTabsProcessosID.Items.Clear();
            c61EdicaoEventos wsee = new c61EdicaoEventos();
            var x = wsee.getListaEventos((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d59EventoDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.descricao.ToString();
                Item.Value = pair.Value.idEvento.ToString();
                ListBoxParaTabsProcessosID.Items.Add(Item);
                ListBoxParaTabsProcessosID.DataBind();
            }
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c61EdicaoEventos wsee = new c61EdicaoEventos();
            wsee.editarEvento(ListBoxParaTabsProcessosID.SelectedValue.ToString(), (string)Session["idProcesso"], TextBoxTipoEventoID.Text, TextBoxDescricaoID.Text, TextBoxDataID.Text, (string)Session["userId"]);
            //ClearAllText(this);
            //ListBoxParaTabsProcessosID.ClearSelection();
            ListBoxParaTabsProcessosID.Items.Clear();
            listaEventos();
            ListBoxParaTabsProcessosID.DataBind();
        }
    }
}