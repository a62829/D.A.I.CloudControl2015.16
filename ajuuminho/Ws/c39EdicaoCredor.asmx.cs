using System;
using System.Collections.Generic;
using System.Web.Services;
using ajuUminho.App_Code;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c39EdicaoCredor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c39EdicaoCredor : System.Web.Services.WebService
    {
        [WebMethod]
        public void editarCredor(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            //// efetuar controlos
            //d37Credor rl = new d37Credor();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setCredor(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarCredor(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d37Credor c = new d37Credor();
            c.guardar(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);

        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d37Credor rl = new d37Credor();
        //    DataTable dt = rl.getListaCredor();
        //    return dt;
        //}

        [WebMethod]
        public d37CredorDto getCredor(string id)
        {
            d37CredorDto cdto = new d37CredorDto();
            return cdto.getCredor(id);
        }

        [WebMethod]
        public Dictionary<String, String> getListaRepresentantesLegais()
        {

            d37CredorDto cdto = new d37CredorDto();
            DataTable dt = cdto.getListaCredor();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["id"]), Convert.ToString(dt.Rows[i]["nome"]));
            }
            return lista;

        }
    }
}
