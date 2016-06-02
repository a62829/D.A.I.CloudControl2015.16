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

namespace ajuUminho.webforms
{
    public partial class gestaoIdentidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ListBoxIdentidades.Items.Clear();

            //ListBoxIdentidades.Items.Clear();
            //gestaoIdentidade ws1 = new gestaoIdentidade();
            //var dtable = ws1.getRoles();
            //for (int i = 0; i < dtable.Rows.Count; i++)
            //{
            //    ListBox2.Items.Add(Convert.ToString(dtable.Rows[i]["Name"]));
            //}
            //var dtable2 = ws1.getUsers();
            //if (!IsPostBack)
            //{
            //    for (int i = 0; i < dtable2.Rows.Count; i++)
            //    {
            //        ListBoxIdentidades.Items.Add(Convert.ToString(dtable2.Rows[i]["UserName"]));
            //    }
            //} else if (IsPostBack) {
            //    for (int i = 0; i < dtable2.Rows.Count; i++)
            //    {
            //        ListBoxIdentidades.Items.Add(Convert.ToString(dtable2.Rows[i]["UserName"]));
            //        ListBoxIdentidades.DataBind();
            //    }

            //}
            if (!IsPostBack)
            {
                listaUser();
                listaRoles();
            }
            else
            {

            }
            //if ((string)(Session["userRoles"]) != "Admin")
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
            //Label1.Text = HttpContext.Current.Session["userName"].ToString();
            //Label2.Text = HttpContext.Current.Session["userId"].ToString();
            /*ListBox1.Items.Clear();
            var list = Session["userRoles"] as IList<string>;

            for (int i = 0; i < list.Count; i++)
            {
                ListBox2.Items.Add(list[i]);
            }*/
        }

        protected void listaUser()
        {
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

        protected void listarUserRoles()
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            string user = ListBoxIdentidadesID.SelectedItem.Value;
            foreach (var u in ws1.getUserRoles(user))
            {
                ListBoxPerfisAssociadosID.Items.Add(u);

            }
        }

        protected void ButtonGravar_Click(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            if (TextBoxPasswordID.Text == TextBoxConfirmPasswordID.Text) {
                ws1.criarUtilizador(TextBoxNomeID.Text, TextBoxPasswordID.Text, TextBoxEmailID.Text, TextBoxTelefoneID.Text);
            }
            else{
                //MessageBox.Show("The calculations are complete");
            }
        }

        protected void signOut(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            if (ws1.signOut() == true) {
                Response.Redirect("~/webforms/Login.aspx");
            }
            else
            {

            }
        }

        protected void ButtonAlterarPasswordID_Click(object sender, EventArgs e)
        {
            string user = ListBoxIdentidadesID.SelectedValue;
            string newPassword = TextBoxPasswordID.Text;
            if (newPassword == TextBoxConfirmPasswordID.Text)
            {
                gestaoIdentidade ws1 = new gestaoIdentidade();
                ws1.setUserPassword(user, newPassword);
            }
            else
            {
                //pwd nao coincidem
            }
        
        }

        protected void ButtonEliminarID_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            
        }

        protected void ButtonAdicionarPerfilID_Click(object sender, EventArgs e)
        {
            string roleName = TextBoxAdicionarPerfilID.Text;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.insertRole(roleName);
            ListBoxPerfisID.DataBind();
        }

        protected void ButtonMoreID_Click(object sender, EventArgs e)
        {
            string user = ListBoxIdentidadesID.SelectedValue;
            string role = ListBoxPerfisID.SelectedItem.Text;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.setRoleToUser(user, role);
            ListBoxPerfisAssociadosID.DataBind();
        }

        protected void ButtonLessID_Click(object sender, EventArgs e)
        {
            string user = ListBoxIdentidadesID.SelectedValue;
            string role = ListBoxPerfisAssociadosID.SelectedItem.Text;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.removeRoleToUser(user, role);
            ListBoxPerfisAssociadosID.DataBind();
        }

        protected void ListBoxIdentidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            var obj = ListBoxIdentidadesID.SelectedItem.Text;
            var dtable = ws1.getUserDetail(obj);
            TextBoxNomeID.Text = Convert.ToString(dtable.Rows[0]["UserName"]);
            TextBoxEmailID.Text = Convert.ToString(dtable.Rows[0]["Email"]);
            TextBoxTelefoneID.Text = Convert.ToString(dtable.Rows[0]["PhoneNumber"]);
            

            //ListBoxPerfisID.Items.Clear();
            //string user = ListBoxIdentidadesID.SelectedItem.Value;
            //foreach (var u in ws1.getUserRoles(user))
            //{
            //    ListBoxPerfisAssociadosID.Items.Add(u);
                
            //}
            ListBoxPerfisAssociadosID.Items.Clear();
            listarUserRoles();
            //ListBoxIdentidadesID.Items.Clear();
            //listaUser();

        }

        protected void ListBoxPerfisID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}