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
        d85ProcessoDto lista;
        protected void Page_Load(object sender, EventArgs e)
        {

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

        //protected d85ProcessoDto deserializeobj()
        //{
        //    string path = @"C:\Users\Tiago Silva\Desktop\AjuUminho Final\ajuuminho\bin\ProcessoDto.txt";
        //    IFormatter formatter = new BinaryFormatter();
        //    Stream stream = new FileStream(path,
        //                              FileMode.Open,
        //                              FileAccess.Read,
        //                              FileShare.Read);
        //    this.lista = (d85ProcessoDto)formatter.Deserialize(stream);
        //    stream.Close();
        //    return lista;
        //}

        //protected d85ProcessoDto listaProcessoDto()
        //{
        //    this.lista = deserializeobj();
        //    return lista;
        //}

        protected void DropDownListEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    var x = listaProcessoDto();
            //    if (DropDownListEntidadesID.Text == "Insolvente")
            //    {
            //        foreach (KeyValuePair<String, d41InsolventeDto> pair in x.listaIDtoNoProcesso)
            //        {
            //            ListItem Item = new ListItem();
            //            Item.Text = pair.Value.ToString();
            //            Item.Value = pair.Key.ToString();
            //            ListBoxEntidadesAssociadosID.Items.Add(Item);
            //            ListBoxEntidadesAssociadosID.DataBind();
            //        }
            //    }
        }
    }
}