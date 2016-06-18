using _BusinessLayer;
using ajuUminho.Ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class i56AtribuicaoEntidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonMoreID_Click(object sender, EventArgs e)
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            pdto.getProcessoCompleto((string)Session["idProcesso"]);
            if (ListBoxEntidadesID.SelectedIndex == -1)
            {
                string mystring = "Selecione item a adicionar";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            }
            else {

                if (DropDownListEntidadesID.Text == "Insolvente")
                {
                    c43EdicaoInsolvente ci = new c43EdicaoInsolvente();
                    ci.adicionarInsolventeAoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaInsolventes();
                }
                else if (DropDownListEntidadesID.Text == "Representante Legal")
                {
                    c23EditarRepresentanteLegal crl = new c23EditarRepresentanteLegal();
                    if (RadioButtonList1.SelectedItem.Text == "Insolvente")
                    {
                        crl.adicionarRepresentanteLegalAoInsolventeNoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString(), pdto.listaIDtoNoProcesso.Values.ToString());
                        ListBoxEntidadesAssociadosID.Items.Clear();
                        ListBoxEntidadesID.Items.Clear();
                        listaRepresentantesLegais();
                    }
                    else
                    {
                       // crl.adicionarRepresentanteLegalAoCredorNoProcesso(pdto.idProcesso.ToString(), ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString(), pdto.listaIDtoNoProcesso.Values.ToString());
                    }

                }
                else if (DropDownListEntidadesID.Text == "Credor")
                {
                    c39EdicaoCredor ccr = new c39EdicaoCredor();
                    ccr.adicionarCredorAoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaCredores();

                }
                else if (DropDownListEntidadesID.Text == "Juiz")
                {
                    c35EdicaoJuiz cj = new c35EdicaoJuiz();
                    cj.adicionarJuizAoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaJuizes();

                }
                else if (DropDownListEntidadesID.Text == "Prestador de Serviços")
                {
                    c51EdicaoPrestadorServico cps = new c51EdicaoPrestadorServico();
                    cps.adicionarPrestadorServicoAoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaPrestadoresDeServicos();
                }
                else if (DropDownListEntidadesID.Text == "Outras Entidades")
                {
                    c55RemocaoOutraEntidade coe = new c55RemocaoOutraEntidade();
                    coe.adicionarOutraEntidadeAoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaOutrasEntidades();
                }
                else if (DropDownListEntidadesID.Text == "Contabilista")
                {
                    c47EdicaoContabilista c = new c47EdicaoContabilista();

                        c.adicionarContabilistaAoInsolventeNoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString(), pdto.listaIDtoNoProcesso.Values.ToString());
                        ListBoxEntidadesAssociadosID.Items.Clear();
                        ListBoxEntidadesID.Items.Clear();
                        listaContabilistas();
                }
                else if (DropDownListEntidadesID.Text == "Tribunal")
                {
                    c31EdicaoTribunal ct = new c31EdicaoTribunal();
                    ct.adicionarTribunalAoProcesso((string)Session["idProcesso"], ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaTribunais();
                }
            }
        }

        protected void ButtonLessID_Click(object sender, EventArgs e)
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            pdto.getProcessoCompleto((string)Session["idProcesso"]);
            if (ListBoxEntidadesAssociadosID.SelectedIndex == -1)
            {
                string mystring = "Selecione item a remover";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else {

                if (DropDownListEntidadesID.Text == "Insolvente")
                {
                    c44RemocaoInsolvente ci = new c44RemocaoInsolvente();
                    ci.removerInsolventeDoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaInsolventes();
                }
                else if (DropDownListEntidadesID.Text == "Representante Legal")
                {
                    c23EditarRepresentanteLegal crl = new c23EditarRepresentanteLegal();
                    if (RadioButtonList1.SelectedItem.Text == "Insolvente")
                    {
                        crl.adicionarRepresentanteLegalAoInsolventeNoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString(), pdto.listaIDtoNoProcesso.Values.ToString());
                        ListBoxEntidadesAssociadosID.Items.Clear();
                        ListBoxEntidadesID.Items.Clear();
                        listaRepresentantesLegais();
                    }
                    else
                    {
                        // crl.adicionarRepresentanteLegalAoCredorNoProcesso(pdto.idProcesso.ToString(), ListBoxEntidadesID.SelectedItem.Value.ToString(), Session["userId"].ToString(), pdto.listaIDtoNoProcesso.Values.ToString());
                    }

                }
                else if (DropDownListEntidadesID.Text == "Credor")
                {
                    c39EdicaoCredor ccr = new c39EdicaoCredor();
                    ccr.adicionarCredorAoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaCredores();

                }
                else if (DropDownListEntidadesID.Text == "Juiz")
                {
                    c35EdicaoJuiz cj = new c35EdicaoJuiz();
                    cj.adicionarJuizAoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaJuizes();

                }
                else if (DropDownListEntidadesID.Text == "Prestador de Serviços")
                {
                    c51EdicaoPrestadorServico cps = new c51EdicaoPrestadorServico();
                    cps.adicionarPrestadorServicoAoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaPrestadoresDeServicos();
                }
                else if (DropDownListEntidadesID.Text == "Outras Entidades")
                {
                    c55RemocaoOutraEntidade coe = new c55RemocaoOutraEntidade();
                    coe.adicionarOutraEntidadeAoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaOutrasEntidades();
                }
                else if (DropDownListEntidadesID.Text == "Contabilista")
                {
                    c47EdicaoContabilista c = new c47EdicaoContabilista();
                        c.adicionarContabilistaAoInsolventeNoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString(), pdto.listaIDtoNoProcesso.Values.ToString());
                        ListBoxEntidadesAssociadosID.Items.Clear();
                        ListBoxEntidadesID.Items.Clear();
                        listaContabilistas();
                }
                else if (DropDownListEntidadesID.Text == "Tribunal")
                {
                    c32RemocaoTribunal ct = new c32RemocaoTribunal();
                    ct.removerTribunalDoProcesso((string)Session["idProcesso"], ListBoxEntidadesAssociadosID.SelectedItem.Value.ToString(), Session["userId"].ToString());
                    ListBoxEntidadesAssociadosID.Items.Clear();
                    ListBoxEntidadesID.Items.Clear();
                    listaTribunais();
                }
            }
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBoxEntidadesAssociadosID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownListEntidadesID.Text == "Insolvente")
            {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaInsolventes();
            }else if (DropDownListEntidadesID.Text == "Representante Legal") {
                RadioButtonList1.Visible = true;
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaRepresentantesLegais();
            }
            else if (DropDownListEntidadesID.Text == "Credor")  {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaCredores();
            }
            else if (DropDownListEntidadesID.Text == "Juiz") {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaJuizes();
            }
            else if (DropDownListEntidadesID.Text == "Prestador de Serviços"){
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaPrestadoresDeServicos();
            }
            else if (DropDownListEntidadesID.Text == "Outras Entidades")
            {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaOutrasEntidades();
            }
            else if (DropDownListEntidadesID.Text == "Contabilista")
            {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaContabilistas();
            }
            else if (DropDownListEntidadesID.Text == "Tribunal")
            {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaTribunais();
            }else if (DropDownListEntidadesID.Text == "Administrador Judicial")
            {
                ListBoxEntidadesAssociadosID.Items.Clear();
                ListBoxEntidadesID.Items.Clear();
                listaAdministradoresJudiciais();
            }
        }

        protected void listaRepresentantesLegais()
        {
            ListBoxEntidadesAssociadosID.Items.Clear();
            ListBoxEntidadesID.Items.Clear();
            if (RadioButtonList1.SelectedItem.Text == "Insolvente")
            {
                d21RepresentanteLegalDto idto = new d21RepresentanteLegalDto();
                var x = idto.getListaRepresentanteLegalNoInsolventeNoProcesso((string)Session["idProcesso"]);
                foreach (KeyValuePair<String, d21RepresentanteLegalDto> pair in x)
                {
                    ListItem Item = new ListItem();
                    Item.Text = pair.Value.nome.ToString();
                    Item.Value = pair.Value.id.ToString();
                    ListBoxEntidadesAssociadosID.Items.Add(Item);
                    ListBoxEntidadesAssociadosID.DataBind();
                }
                var y = idto.getListaRepresentanteLegalForaDoInsolventeNoProcesso((string)Session["idProcesso"]);
                foreach (KeyValuePair<String, d21RepresentanteLegalDto> pair in y)
                {
                    ListItem Item = new ListItem();
                    Item.Text = pair.Value.nome.ToString();
                    Item.Value = pair.Value.id.ToString();
                    ListBoxEntidadesID.Items.Add(Item);
                    ListBoxEntidadesID.DataBind();
                }

            } else {
                d21RepresentanteLegalDto idto = new d21RepresentanteLegalDto();
                var x = idto.getListaRepresentanteLegalNoCredorNoProcesso((string)Session["idProcesso"]);
                foreach (KeyValuePair<String, d21RepresentanteLegalDto> pair in x)
                {
                    ListItem Item = new ListItem();
                    Item.Text = pair.Value.nome.ToString();
                    Item.Value = pair.Value.id.ToString();
                    ListBoxEntidadesAssociadosID.Items.Add(Item);
                    ListBoxEntidadesAssociadosID.DataBind();
                }
                var y = idto.getListaRepresentanteLegalForaDoCredorNoProcesso((string)Session["idProcesso"]);
                foreach (KeyValuePair<String, d21RepresentanteLegalDto> pair in y)
                {
                    ListItem Item = new ListItem();
                    Item.Text = pair.Value.nome.ToString();
                    Item.Value = pair.Value.id.ToString();
                    ListBoxEntidadesID.Items.Add(Item);
                    ListBoxEntidadesID.DataBind();
                }
            }


        }

        protected void listaAdministradoresJudiciais()
        {
            d25AdministradorJudicialDto idto = new d25AdministradorJudicialDto();
            var x = idto.getListaAdministradorJudicialNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d25AdministradorJudicialDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaAdministradorJudicialForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d25AdministradorJudicialDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaTribunais()
        {
            d29TribunalDto idto = new d29TribunalDto();
            var x = idto.getListaTribunalNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d29TribunalDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaTribunalForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d29TribunalDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaJuizes()
        {
            d33JuizDto idto = new d33JuizDto();
            var x = idto.getListaJuizNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d33JuizDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaJuizForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d33JuizDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaCredores()
        {
            d37CredorDto idto = new d37CredorDto();
            var x = idto.getListaCredorNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d37CredorDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaCredorForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d37CredorDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaInsolventes()
        {
            d41InsolventeDto idto = new d41InsolventeDto();
            var x = idto.getListaInsolventeNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d41InsolventeDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaInsolventeForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d41InsolventeDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaContabilistas()
        {
            d45ContabilistaDto idto = new d45ContabilistaDto();
            var x = idto.getListaContabilistaNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d45ContabilistaDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaContabilistaForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d45ContabilistaDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaPrestadoresDeServicos()
        {
            d49PrestadorServicoDto idto = new d49PrestadorServicoDto();
            var x = idto.getListaPrestadorServicoNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d49PrestadorServicoDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaPrestadorServicoForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d49PrestadorServicoDto> pair in y)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesID.Items.Add(Item);
                ListBoxEntidadesID.DataBind();
            }
        }

        protected void listaOutrasEntidades()
        {
            d53OutraEntidadeDto idto = new d53OutraEntidadeDto();
            var x = idto.getListaOutraEntidadeNoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d53OutraEntidadeDto> pair in x)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.nome.ToString();
                Item.Value = pair.Value.id.ToString();
                ListBoxEntidadesAssociadosID.Items.Add(Item);
                ListBoxEntidadesAssociadosID.DataBind();
            }
            var y = idto.getListaOutraEntidadeForaDoProcesso((string)Session["idProcesso"]);
            foreach (KeyValuePair<String, d53OutraEntidadeDto> pair in y)
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