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
                listaUser();
                listaRoles();
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
                gestaoIdentidade ws1 = new gestaoIdentidade();
                ws1.insertRole(roleName);
                ListBoxPerfisID.DataBind();
                listaRoles();
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
                gestaoIdentidade ws1 = new gestaoIdentidade();
                //ws1.removeRoleFromSystem(role); metodo para remover role do sistem
                
                ListBoxPerfisID.DataBind();
                
                listaRoles();
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
                gestaoIdentidade ws1 = new gestaoIdentidade();
                ws1.setRoleToUser(user, role);
                ListBoxPerfisAssociadosID.DataBind();
                ListBoxPerfisID.DataBind();
                listaRolesUserDontHave();
                listaUserRoles();
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
                gestaoIdentidade ws1 = new gestaoIdentidade();
                ws1.removeRoleToUser(user, role);
                ListBoxPerfisAssociadosID.DataBind();
                ListBoxPerfisID.DataBind();
                listaRolesUserDontHave();
                listaUserRoles();
            }
        }

        protected void ListBoxIdentidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaUserRoles();
            listaRolesUserDontHave();
        }
        protected void listaUser()
        {
            ListBoxIdentidadesID.Items.Clear();
            gestaoIdentidade cde = new gestaoIdentidade();
            var lista = cde.getListaUsers();
            //ListBoxIdentidadesID.DataSource = lista;
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxIdentidadesID.Items.Add(Item);
                ListBoxIdentidadesID.DataBind();
            }
        }

        protected void listaRoles()
        {
            ListBoxPerfisID.Items.Clear();
            gestaoIdentidade cde = new gestaoIdentidade();
            var lista = cde.getListaRoles();
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

        protected void listaRolesUserDontHave()
        {
            ListBoxPerfisID.Items.Clear();
            gestaoIdentidade cde = new gestaoIdentidade();
            var lista = cde.getListaRolesUserDontHave(ListBoxIdentidadesID.SelectedValue.ToString());
            foreach (KeyValuePair<String, String> pair in lista)
            {
                ListItem Item = new ListItem();
                Item.Text = pair.Value.ToString();
                Item.Value = pair.Key.ToString();
                ListBoxPerfisID.Items.Add(Item);
                ListBoxPerfisID.DataBind();
            }
        }

        protected void listaUserRoles()
        {
            ListBoxPerfisAssociadosID.Items.Clear();
            gestaoIdentidade ws1 = new gestaoIdentidade();
            string user = ListBoxIdentidadesID.SelectedItem.Value;
            foreach (var u in ws1.getUserRoles(user))
            {
                ListBoxPerfisAssociadosID.Items.Add(u);

            }
        }
    }
}