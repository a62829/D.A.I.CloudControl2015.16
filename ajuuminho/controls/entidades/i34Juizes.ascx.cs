using ajuUminho.App_Code;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i34Juizes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaJuiz();
            }
            else
            {
                listaJuiz();
            }
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d33Juiz j = new d33Juiz();
            j.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Juiz criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c35EdicaoJuiz ej = new c35EdicaoJuiz();
            string idj = ListBoxEntidadesID.SelectedValue.ToString();
            d33JuizDto j = ej.getJuiz(idj);
            TextBoxNomeID.Text = j.nome;
            TextBoxMoradaID.Text = j.morada;
            TextBoxCodPostalID.Text = j.codPostal;
            TextBoxLocalidadeID.Text = j.localidade;
            TextBoxEmailID.Text = j.email;
            TextBoxTelefoneID.Text = j.telefone;
            TextBoxTelemovelID.Text = j.telemovel;
            TextBoxFaxID.Text = j.fax;
            TextBoxCcID.Text = j.cc;
            TextBoxIbanID.Text = j.iban;
            TextBoxNifID.Text = j.nif;
            TextBoxLastChangedID.Text = j.lastChangeBy;
            ListBoxEntidadesID.Items.Clear();
            listaJuiz();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c35EdicaoJuiz WsEJ = new c35EdicaoJuiz();
            WsEJ.editarJuiz(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaJuiz()
        {
            c35EdicaoJuiz WsEJ = new c35EdicaoJuiz();
            var lista = WsEJ.getListaJuiz();
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