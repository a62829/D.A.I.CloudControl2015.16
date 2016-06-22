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
    /// Summary description for c7AtribuicaoDePerfil
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c7AtribuicaoDePerfil : System.Web.Services.WebService
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
            d2Utilizadores ga = new d2Utilizadores();
            ga.setRole(roleName);
        }

        [WebMethod]
        public void atribuirPerfil(string user, string role)
        {
            d2Utilizadores ga = new d2Utilizadores();
            ga.atribuirPerfil(user, role);
        }

        [WebMethod]
        public void removerPerfilDoUtilizador(string user, string role)
        {
            d2Utilizadores ga = new d2Utilizadores();
            ga.removerPerfilDoUtilizador(user, role);
        }

        [WebMethod]
        public IList<string> listarPerfisAtribuidos(string user)
        {
            d2Utilizadores ga = new d2Utilizadores();
            return ga.listarPerfisAtribuidos(user);
        }
        [WebMethod]
        public System.Data.DataTable getRoles()
        {
            d2Utilizadores ga = new d2Utilizadores();
            return ga.listarPerfis();
        }

        [WebMethod]
        public System.Data.DataTable getUserDetail(string nome)
        {
            d2Utilizadores ga = new d2Utilizadores();
            return ga.getUserDetail(nome);
        }

        [WebMethod]
        public System.Data.DataTable listarDadosUtilizador(string idUser)
        {
            d2Utilizadores ga = new d2Utilizadores();
            var x = ga.listarDadosUtilizador(idUser);
            return x;
        }

        [WebMethod]
        public System.Data.DataTable getUsers()
        {
            d2Utilizadores ga = new d2Utilizadores();
            return ga.listarUtilizadores();
        }

        [WebMethod]
        public void setUserPassword(string user, string newPassword)
        {
            d2Utilizadores connn = new d2Utilizadores();
            connn.setUserPassword(user, newPassword);
        }

        [WebMethod]
        public bool signIn(string userName, string Password)
        {
            d2Utilizadores connn = new d2Utilizadores();
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
            d2Utilizadores connn = new d2Utilizadores();
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
        public bool criarUtilizador(string userName, string password, string email, string telefone)
        {
            d2Utilizadores connn = new d2Utilizadores();
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
        public Dictionary<String, String> listarUtilizador()
        {
            d2Utilizadores ga = new d2Utilizadores();
            DataTable dt = ga.listarUtilizadores();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["Id"]), Convert.ToString(dt.Rows[i]["UserName"]));
            }
            return lista;

        }

        [WebMethod]
        public Dictionary<String, String> listarPerfis()
        {
            d2Utilizadores ga = new d2Utilizadores();
            DataTable dt = ga.listarPerfis();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["Id"]), Convert.ToString(dt.Rows[i]["Name"]));
            }
            return lista;

        }

        [WebMethod]
        public Dictionary<String, String> listarPerfisNaoAtribuidos(string idUser)
        {
            d2Utilizadores ga = new d2Utilizadores();
            DataTable dt = ga.listarPerfisNaoAtribuidos(idUser);
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
            d2Utilizadores connn = new d2Utilizadores();
            connn.editarUtilizador(userName, email, telefone, idUser);
        }

        [WebMethod]
        public void eliminarUtilizador(string idUser)
        {
            d2Utilizadores connn = new d2Utilizadores();
            connn.eliminarUtilizador(idUser);
        }



    }
}
