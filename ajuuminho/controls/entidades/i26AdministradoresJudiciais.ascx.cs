using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i26AdministradoresJudiciais : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaAdministradorJudicial();
            }
            else
            {

            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial ws = new c27EdicaoAdministradorJudicial();
            ws.criarAdministradorJudicial(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaAdministradorJudicial();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial eaj = new c27EdicaoAdministradorJudicial();
            string idaj = ListBoxEntidadesID.SelectedValue.ToString();
            d25AdministradorJudicialDto aj = eaj.getAdministradorJudicial(idaj);
            TextBoxNomeID.Text = aj.nome;
            TextBoxMoradaID.Text = aj.morada;
            TextBoxCodPostalID.Text = aj.codPostal;
            TextBoxLocalidadeID.Text = aj.localidade;
            TextBoxEmailID.Text = aj.email;
            TextBoxTelefoneID.Text = aj.telefone;
            TextBoxTelemovelID.Text = aj.telemovel;
            TextBoxFaxID.Text = aj.fax;
            TextBoxCcID.Text = aj.cc;
            TextBoxIbanID.Text = aj.iban;
            TextBoxNifID.Text = aj.nif;
            TextBoxLastChangedID.Text = aj.lastChangeBy;
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial WsEAJ = new c27EdicaoAdministradorJudicial();
            WsEAJ.editarAdministradorJudicial(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaAdministradorJudicial()
        {
            c27EdicaoAdministradorJudicial WsEAJ = new c27EdicaoAdministradorJudicial();
            var lista = WsEAJ.getListaAdministradorJudicial();
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }
    }
}