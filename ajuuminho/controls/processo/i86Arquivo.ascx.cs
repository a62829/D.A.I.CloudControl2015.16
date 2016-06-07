using System;
using _BusinessLayer;
using ajuUminho.Ws;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.processos
{
    public partial class i86Arquivo : System.Web.UI.UserControl
    {
        private d85ProcessoDto PDTO;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaProcesso();
            }
            else
            {
            }
        }

        protected void listaProcesso()
        {
            c87 WsERL = new c87();
            var lista = WsERL.getListaProcesso();
            foreach (KeyValuePair<String, d85ProcessoDto> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.idLegal.ToString();
                Item.Value = pair.Value.idProcesso.ToString();
                ListBoxProcessosID.Items.Add(Item);
                ListBoxProcessosID.DataBind();
            }
        }

        protected void ListBoxProcessosID_SelectedIndexChanged1(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal erl = new c23EditarRepresentanteLegal();
            //string idRl = ListBoxEntidadesID.SelectedValue.ToString();
            //var rl = erl.getRepresentanteLegal(idRl);
            //TextBoxNomeID.Text = rl.nome;
            //TextBoxMoradaID.Text = rl.morada;
            //TextBoxCodPostalID.Text = rl.codPostal;
            //TextBoxLocalidadeID.Text = rl.localidade;
            //TextBoxEmailID.Text = rl.email;
            //TextBoxTelefoneID.Text = rl.telefone;
            //TextBoxTelemovelID.Text = rl.telemovel;
            //TextBoxFaxID.Text = rl.fax;
            //TextBoxCcID.Text = rl.cc;
            //TextBoxIbanID.Text = rl.iban;
            //TextBoxNifID.Text = rl.nif;
            //TextBoxLastChangedID.Text = rl.lastChangeBy;
            //ListBoxEntidadesID.ClearSelection();
            //ListBoxEntidadesID.Items.Clear();
            //listaRepresentanteLegal();
        }
    }
}