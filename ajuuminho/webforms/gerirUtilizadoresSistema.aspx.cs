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

namespace ajuUminho.webforms
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            if (Password.Text == ConfirmPassword.Text)
            {
                ws1.criarUtilizador(UserName.Text, Password.Text, Email.Text, Telefone.Text);
                DropDownList2.DataBind();
                DropDownList3.DataBind();
                DropDownList4.DataBind();
            }
            else {
                //MessageBox.Show("The calculations are complete");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string roleName = TextBox1.Text;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.insertRole(roleName);
            DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string user = DropDownList2.SelectedValue;
            string role = DropDownList1.SelectedValue;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.setRoleToUser(user, role);
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            string user = DropDownList3.SelectedValue;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            foreach (var u in ws1.getUserRoles(user))
            {
                ListBox1.Items.Add(u);
            }
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            string user = DropDownList4.SelectedValue;
            string newPassword = TextBox2.Text;
            gestaoIdentidade ws1 = new gestaoIdentidade();
            ws1.setUserPassword(user, newPassword);
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
    }
}