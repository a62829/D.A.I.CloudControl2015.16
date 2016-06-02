using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using ajuUminho.App_Code;
using ajuUminho;

namespace businessLayer
{
    public class gestaoAcessos : DBcon
    {
        public System.Data.DataTable getUserDetail(string nome)
        {
            //Listar os Perfis de um Utilizador
            SqlDataReader reader;
            cmd.CommandText = "SELECT UserName, Email, PhoneNumber FROM [dbo].[AspNetUsers] WHERE [dbo].[AspNetUsers].[UserName]='" + nome + "';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setRole(string roleName)
        {
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            // Associar o nome à string
            IdentityResult roleResult;
            // Verificar se a role existe. Se não existir cria-a
            if (!RoleManager.RoleExists(roleName))
            {
                roleResult = RoleManager.Create(new IdentityRole(roleName));
            }
        }

        public void setRoleToUser(string user, string role)
        {
            //Adicionar Perfis aos Utilizadores do Sistema
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            userManager.AddToRole(user, role);
        }

        public void removeRoleToUser(string user, string role)
        {
            //Adicionar Perfis aos Utilizadores do Sistema
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            userManager.RemoveFromRole(user, role);
        }

        public void setUserPassword(string user, string newPassword)
        {
            //Alterar Password dos Utilizadores
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var userdb = userManager.FindById(user);
            string newPwdHash = userManager.PasswordHasher.HashPassword(newPassword);
            userStore.SetPasswordHashAsync(userdb, newPwdHash);
            userStore.UpdateAsync(userdb);
        }

        public IList<string> getUserRoles(string user)
        {
            //Listar os Perfis de um Utilizador
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var userdb = userManager.GetRoles(user);
            return userdb;
        }

        public DataTable getRoles()
        {
            //Listar os Perfis de um Utilizador
            SqlDataReader reader;
            cmd.CommandText = "SELECT Id,Name FROM [dbo].[AspNetRoles];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public System.Data.DataTable getUsers()
        {
            //Listar os Perfis de um Utilizador
            SqlDataReader reader;
            cmd.CommandText = "SELECT UserName,Id FROM [dbo].[AspNetUsers];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public bool signIn(string userName, string userPassword)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Find(userName, userPassword);

            if (user != null)
            {
                var roles = user.Roles;
                var idUser = user.Id;
                var u = user.UserName;
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                HttpContext.Current.Session["userName"] = u;
                HttpContext.Current.Session["userRoles"] = roles;
                HttpContext.Current.Session["userId"] = idUser;
                //Response.Redirect("~/Login.aspx");
                return true;
            }
            else
            {
                //StatusText.Text = "Invalid username or password.";
                //LoginStatus.Visible = true;
                return false;
            }
        }

        public bool signOut()
        {
            if (HttpContext.Current.Session["userName"] != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                authenticationManager.SignOut();
                HttpContext.Current.Session.Remove("userName");
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool  criarUtilizador (string userName, string password, string email, string telefone)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var user = new IdentityUser() { UserName = userName };
            user.Email = email;
            user.PhoneNumber = telefone;
            IdentityResult result = manager.Create(user, password);

            if (result.Succeeded)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                //userStore.SetPhoneNumberAsync(user, telefone);
                //userStore.SetEmailAsync(user, email);
                

                return true;
            }
            else
            {
                return false;
            }
        }
    }

}