using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace ajuUminho.controls.entidades
{
    public partial class i22RepresentanteLegal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaRepresentanteLegal();
            }
            else
            {
            }          
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            ws.criarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            ListBoxEntidadesID.Items.Clear();
            listaRepresentanteLegal();
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal erl = new c23EditarRepresentanteLegal();
            string idRl = ListBoxEntidadesID.SelectedValue.ToString();
            var rl = erl.getRepresentanteLegal(idRl);
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
            ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal WsERL = new c23EditarRepresentanteLegal();
            WsERL.editarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void listaRepresentanteLegal()
        {
            c23EditarRepresentanteLegal WsERL = new c23EditarRepresentanteLegal();
            var lista = WsERL.getListaRepresentantesLegais();
            foreach (KeyValuePair<String, d21RepresentanteLegalDto> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }
    }
}