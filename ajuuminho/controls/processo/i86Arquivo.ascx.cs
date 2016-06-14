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

        protected void ListBoxProcessosID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c87 erl = new c87();
            string idRl = ListBoxProcessosID.SelectedValue.ToString();
            var rl = erl.getProcesso(idRl);
            TextBoxIdLegalID.Text = rl.idLegal;
            TextBoxNomeTipoProcessoID.Text = rl.idTipoProcesso;
            TextBoxEstadoID.Text = rl.idEstado;
            TextBoxDataInicioID.Text = rl.dataInicio;
            TextBoxDataEncerramentoID.Text = rl.dataEncerramento;
            listaProcesso();
        }
    }
}