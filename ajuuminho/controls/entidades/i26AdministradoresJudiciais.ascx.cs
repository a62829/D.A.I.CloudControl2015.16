using ajuUminho.App_Code;
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
                listaAdministradorJudicial();
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            aj.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Administrador Judicial criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial erl = new c27EdicaoAdministradorJudicial();
            string idRl = ListBoxEntidadesID.SelectedValue.ToString();
            d25AdministradorJudicialDto rl = erl.getAdministradorJudicial(idRl);
            TextBoxNomeID.Text = rl.nome;
            TextBoxMoradaID.Text = rl.morada;
            TextBoxCodPostalID.Text = rl.codPostal;
            TextBoxLocalidadeID.Text = rl.localidade;
            TextBoxEmailID.Text = rl.email;
            TextBoxTelefoneID.Text = rl.telefone;
            TextBoxTelemovelID.Text = rl.telemovel;
            TextBoxFaxID.Text = rl.fax;
            TextBoxCcID.Text = rl.cc;
            TextBoxIbanID.Text = rl.iban;
            TextBoxNifID.Text = rl.nif;
            TextBoxLastChangedID.Text = rl.lastChangeBy;
            ListBoxEntidadesID.Items.Clear();
            listaAdministradorJudicial();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c27EdicaoAdministradorJudicial WsERL = new c27EdicaoAdministradorJudicial();
            WsERL.editarAdministradorJudicial(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaAdministradorJudicial()
        {
            c27EdicaoAdministradorJudicial WsERL = new c27EdicaoAdministradorJudicial();
            var lista = WsERL.getListaAdministradorJudicial();
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