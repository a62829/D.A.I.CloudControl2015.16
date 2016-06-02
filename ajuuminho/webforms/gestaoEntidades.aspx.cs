using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;

namespace ajuUminho.webforms
{
    public partial class gestaoEntidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            ControloDeEntidades cde = new ControloDeEntidades();
            cde.setEntidade(DropDownListTipoID.SelectedValue, TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text, TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text, TextBoxNifID.Text, TextBoxLastChangedID.Text);

        }

        protected void DropDownListTipoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxEntidadesID.Items.Clear();
            ControloDeEntidades cde = new ControloDeEntidades();
            var lista = cde.getListaEntidade(DropDownListTipoID.SelectedItem.Value);
            //ListBox1.DataSource = lista;
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControloDeEntidades cde = new ControloDeEntidades();
            var lista = cde.getEntidade(ListBoxEntidadesID.SelectedValue, DropDownListTipoID.SelectedItem.Value);
            TextBoxNomeID.Text = lista[0];
            TextBoxMoradaID.Text = lista[1];
            TextBoxCodPostalID.Text = lista[2];
            TextBoxLocalidadeID.Text = lista[3];
            TextBoxEmailID.Text = lista[4];
            TextBoxTelefoneID.Text = lista[5];
            TextBoxTelemovelID.Text = lista[6];
            TextBoxFaxID.Text = lista[7];
            TextBoxCcID.Text = lista[8];
            TextBoxIbanID.Text = lista[9];
            TextBoxNifID.Text = lista[10];
            TextBoxLastChangedID.Text = lista[11];
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            ControloDeEntidades cde = new ControloDeEntidades();
            cde.editarEntidade(ListBoxEntidadesID.SelectedValue, DropDownListTipoID.SelectedValue, TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text, TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text, TextBoxNifID.Text, TextBoxLastChangedID.Text);

        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

        }
    }
}