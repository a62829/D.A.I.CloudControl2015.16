using System;
using _BusinessLayer;
using ajuUminho.Ws;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.processos
{
    public partial class i86Arquivo : System.Web.UI.UserControl
    {
        private d21RepresentanteLegalDto rldto;
        private d25AdministradorJudicialDto ajdto;
        private d29TribunalDto tdto;
        private d33JuizDto jdto;
        private d37CredorDto crdto;
        private d41InsolventeDto idto;
        private d45ContabilistaDto ctbdto;
        private d49PrestadorServicoDto psdto;
        private d53OutraEntidadeDto oedto;

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

        //protected void ButtonEditarID_Click(object sender, EventArgs e)
        //{
        //    c23EditarRepresentanteLegal WsERL = new c23EditarRepresentanteLegal();
        //    WsERL.editarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
        //        TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
        //        TextBoxNifID.Text, TextBoxLastChangedID.Text);
        //}

        protected void listaProcesso()
        {
            c23EditarRepresentanteLegal WsERL = new c23EditarRepresentanteLegal();
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

        protected void ListBoxProcessosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //c23EditarRepresentanteLegal erl = new c23EditarRepresentanteLegal();
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