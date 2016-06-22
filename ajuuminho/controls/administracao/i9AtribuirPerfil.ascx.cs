using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Windows;

namespace ajuUminho.controls.administracao
{
    public partial class i9AtribuirPerfil : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listarUtilizador();
                listarPerfis();
            } else
            {

            }
            


        }

        protected void ButtonAdicionarPerfilID_Click(object sender, EventArgs e)
        {
            if (TextBoxAdicionarPerfilID.Text == "")
            {
                string mystring = "Deve primeiro definir um nome para o novo perfil de sistema.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else
            {
                string roleName = TextBoxAdicionarPerfilID.Text;
                c7AtribuicaoDePerfil ws1 = new c7AtribuicaoDePerfil();
                ws1.insertRole(roleName);
                ListBoxPerfisID.DataBind();
                listarPerfis();
            }
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {
            if (ListBoxPerfisID.SelectedIndex == -1)
            {
                string mystring = "Primeiro deve seleccionar um perfil do sistema que pretende remover.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else
            {
               
                string role = ListBoxPerfisID.SelectedItem.Text;
                c7AtribuicaoDePerfil ws1 = new c7AtribuicaoDePerfil();
                //ws1.removeRoleFromSystem(role); metodo para remover role do sistem
                
                ListBoxPerfisID.DataBind();
                
                listarPerfis();
            }
        }

        protected void ButtonMoreID_Click(object sender, EventArgs e)
        {
            if (ListBoxPerfisID.SelectedIndex == -1)
            {
                string mystring = "Primeiro deve seleccionar um utilizador e o perfil do sistema que pretende atribuir-lhe.";
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
            }
            else {
                string user = ListBoxIdentidadesID.SelectedValue;
                string role = ListBoxPerfisID.SelectedItem.Text;
                c7AtribuicaoDePerfil ws1 = new c7AtribuicaoDePerfil();
                ws1.atribuirPerfil(user, role);
                ListBoxPerfisAssociadosID.DataBind();
                ListBoxPerfisID.DataBind();
                listarPerfisNaoAtribuidos();
                listarPerfisAtribuidos();
            }
        }


        protected void ButtonLessID_Click(object sender, EventArgs e)
        {
            if (ListBoxPerfisAssociadosID.SelectedIndex == -1)
            {
                    string mystring = "Primeiro deve seleccionar um perfil associado ao utilizador.";
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('" + mystring + "');", true);
                }
            else
            {
                string user = ListBoxIdentidadesID.SelectedValue;
                string role = ListBoxPerfisAssociadosID.SelectedItem.Text;
                c7AtribuicaoDePerfil ws1 = new c7AtribuicaoDePerfil();
                ws1.removerPerfilDoUtilizador(user, role);
                ListBoxPerfisAssociadosID.DataBind();
                ListBoxPerfisID.DataBind();
                listarPerfisNaoAtribuidos();

                listarPerfisAtribuidos();
            }
        }

        protected void ListBoxIdentidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarPerfisAtribuidos();
            listarPerfisNaoAtribuidos();
        }
        protected void listarUtilizador()
        {
            ListBoxIdentidadesID.Items.Clear();
            c7AtribuicaoDePerfil cde = new c7AtribuicaoDePerfil();
            var lista = cde.listarUtilizador();
            //ListBoxIdentidadesID.DataSource = lista;
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxIdentidadesID.Items.Add(Item);
                
            }
            ListBoxIdentidadesID.DataBind();
        }

        protected void listarPerfis()
        {
            ListBoxPerfisID.Items.Clear();
            c7AtribuicaoDePerfil cde = new c7AtribuicaoDePerfil();
            var lista = cde.listarPerfis();
            //ListBoxIdentidadesID.DataSource = lista;
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxPerfisID.Items.Add(Item);
                ListBoxPerfisID.DataBind();
            }
        }

        protected void listarPerfisNaoAtribuidos()
        {
            ListBoxPerfisID.Items.Clear();
            c7AtribuicaoDePerfil cde = new c7AtribuicaoDePerfil();
            var lista = cde.listarPerfisNaoAtribuidos(ListBoxIdentidadesID.SelectedValue.ToString());
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxPerfisID.Items.Add(Item);
                ListBoxPerfisID.DataBind();
            }
        }

        protected void listarPerfisAtribuidos()
        {
            ListBoxPerfisAssociadosID.Items.Clear();
            c7AtribuicaoDePerfil ws1 = new c7AtribuicaoDePerfil();
            string user = ListBoxIdentidadesID.SelectedItem.Value;
            foreach (var u in ws1.listarPerfisAtribuidos(user))
            {
                ListBoxPerfisAssociadosID.Items.Add(u);

            }
        }
    }
}