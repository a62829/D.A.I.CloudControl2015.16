using ajuUminho.App_Code;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.entidades
{
    public partial class i22RepresentanteLegal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ListBoxEntidadesID.Items.Add(new ListItem("Escolher Representante Legal", ""));
            //ListBoxEntidadesID.AppendDataBoundItems = true;
            if (!IsPostBack)
            {
                listaRepresentanteLegal();
                //ListBoxEntidadesID.ClearSelection();
            }
            else
            {
                listaRepresentanteLegal();
            }
            //c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            //DataTable dt = ws.listarRepresentantesLegais();
            //ListBoxEntidadesID.DataSource = dt;
            //ListBoxEntidadesID.DataTextField = "nome";
            //ListBoxEntidadesID.DataValueField = "cc";
            //ListBoxEntidadesID.DataBind();
            //dt.AsEnumerable().Select(
            //    row => dt.Columns.Cast<DataColumn>().ToDictionary(
            //        column => column.ColumnName,
            //        column => row[column] as string)
            //        );
            
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            rl.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);

            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            //s.criarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
            //   TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
            //   TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            gestaoIdentidade ws1 = new gestaoIdentidade();
            //            var obj = ListBoxIdentidadesID.SelectedItem.Text;
            //            var dtable = ws1.getUserDetail(obj);
            //            TextBoxNomeID.Text = Convert.ToString(dtable.Rows[0]["UserName"]);
            //            TextBoxEmailID.Text = Convert.ToString(dtable.Rows[0]["Email"]);
            //            TextBoxTelefoneID.Text = Convert.ToString(dtable.Rows[0]["PhoneNumber"]);
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            var obj = ListBoxEntidadesID.SelectedValue.ToString();
            var rl = ws.getRepresentanteLegal(obj);
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
            listaRepresentanteLegal();
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