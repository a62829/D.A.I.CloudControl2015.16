using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ajuUminho.App_Code;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for gestaoIdentidade1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class gestaoIdentidade : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public string HelloWorld()
        {
            if (User.Identity.IsAuthenticated)
            {

                return "Autenticado :" + User.Identity.Name + " " + (string)(Session["FirstName"]);
            }
            else
            {
                return "Sem Acesso";
            }

        }
        [WebMethod]
        public string[] lista()
        {
            List<string> aLista = new List<string>();
            aLista.Add("pafenirats");
            aLista.Add("coisos");
            aLista.Add("cenas");
            aLista.Add("undersnight");

            return aLista.ToArray();
        }

        [WebMethod]
        public string[] SearchName(string txtUserName)
        {
            //As List(Of String)
            List<string> results = new List<string>();
            results.Add(txtUserName);
            results.Add("ddd");
            return results.ToArray();

        }

        [WebMethod]
        public void insertRole(string roleName)
        {
            gestaoAcessos ga = new gestaoAcessos();
            ga.setRole(roleName);
        }

        [WebMethod]
        public void setRoleToUser(string user, string role)
        {
            gestaoAcessos ga = new gestaoAcessos();
            ga.setRoleToUser(user, role);
        }

        [WebMethod]
        public void removeRoleToUser(string user, string role)
        {
            gestaoAcessos ga = new gestaoAcessos();
            ga.removeRoleToUser(user, role);
        }

        [WebMethod]
        public IList<string> getUserRoles(string user)
        {
            gestaoAcessos ga = new gestaoAcessos();
            return ga.getUserRoles(user);
        }
        [WebMethod]
        public System.Data.DataTable getRoles()
        {
            gestaoAcessos ga = new gestaoAcessos();
            return ga.getRoles();
        }

        [WebMethod]
        public System.Data.DataTable getUserDetail(string nome)
        {
            gestaoAcessos ga = new gestaoAcessos();
            return ga.getUserDetail(nome);
        }

        [WebMethod]
        public System.Data.DataTable getUserDetailById(string idUser)
        {
            gestaoAcessos ga = new gestaoAcessos();
            var x = ga.getUserDetailById(idUser);
            return x;
        }

        [WebMethod]
        public System.Data.DataTable getUsers()
        {
            gestaoAcessos ga = new gestaoAcessos();
            return ga.getUsers();
        }

        [WebMethod]
        public void setUserPassword(string user, string newPassword)
        {
            gestaoAcessos connn = new gestaoAcessos();
            connn.setUserPassword(user, newPassword);
        }

        [WebMethod]
        public bool signIn(string userName, string Password)
        {
            gestaoAcessos connn = new gestaoAcessos();
            if (connn.signIn(userName, Password) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        [WebMethod]
        public bool signOut()
        {
            gestaoAcessos connn = new gestaoAcessos();
            if (connn.signOut() == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        [WebMethod]
        public bool criarUtilizador (string userName, string password, string email, string telefone)
        {
            gestaoAcessos connn = new gestaoAcessos();
            if (connn.criarUtilizador(userName, password, email, telefone) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public Dictionary<String, String> getListaUsers()
        {
            gestaoAcessos ga = new gestaoAcessos();
            DataTable dt = ga.getUsers();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["Id"]), Convert.ToString(dt.Rows[i]["UserName"]));
            }
            return lista;

        }

        [WebMethod]
        public Dictionary<String, String> getListaRoles()
        {
            gestaoAcessos ga = new gestaoAcessos();
            DataTable dt = ga.getRoles();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["Id"]), Convert.ToString(dt.Rows[i]["Name"]));
            }
            return lista;

        }

        [WebMethod]
        public Dictionary<String, String> getListaRolesUserDontHave(string idUser)
        {
            gestaoAcessos ga = new gestaoAcessos();
            DataTable dt = ga.getRolesUserDontHave(idUser);
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["Id"]), Convert.ToString(dt.Rows[i]["Name"]));
            }
            return lista;
        }

        [WebMethod]
        public void editarUtilizador(string userName, string email, string telefone, string idUser)
        {
            gestaoAcessos connn = new gestaoAcessos();
            connn.setUtilizador(userName, email, telefone, idUser);
        }

        [WebMethod]
        public void eliminarUtilizador(string idUser)
        {
            gestaoAcessos connn = new gestaoAcessos();
            connn.eliminarUtilizador(idUser);
        }



    }
}
