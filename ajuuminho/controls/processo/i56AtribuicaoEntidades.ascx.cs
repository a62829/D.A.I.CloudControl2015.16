using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.processos
{
    public partial class i56AtribuicaoEntidades : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {

                if (!IsPostBack)
                {
                    if (Session["idProcesso"] != null)
                    {
                    string idProcesso = Session["idProcesso"].ToString();
                    }
                    else {
                    Label1.Text = Session["idProcesso"].ToString();
                    }
                }else{

                }

        }

        protected void ButtonMoreID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonLessID_Click(object sender, EventArgs e)
        {

        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBoxEntidadesAssociadosID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void listaEntidadeForaDoProcesso(string tipoEntidade)
        {


        }



        protected void listaProcessoDto()
        {
        }

        protected void DropDownListEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (DropDownListEntidadesID.Text == "Insolvente")
            //{
            //    foreach (KeyValuePair<String, d41InsolventeDto> pair in x.listaIDtoNoProcesso)
            //    {
            //        ListItem Item = new ListItem();
            //        Item.Text = pair.Value.nome.ToString();
            //        Item.Value = pair.Value.id.ToString();
            //        ListBoxEntidadesAssociadosID.Items.Add(Item);
            //        ListBoxEntidadesAssociadosID.DataBind();
            //    }
            //    d41InsolventeDto idto = new d41InsolventeDto();
            //    var y = idto.getListaInsolventeForaDoProcesso(x.idProcesso);
            //    foreach (KeyValuePair<String, d41InsolventeDto> pair in y)
            //    {
            //        ListItem Item = new ListItem();
            //        Item.Text = pair.Value.nome.ToString();
            //        Item.Value = pair.Value.id.ToString();
            //        ListBoxEntidadesAssociadosID.Items.Add(Item);
            //        ListBoxEntidadesAssociadosID.DataBind();
            //    }

            //}
        }
    }
}