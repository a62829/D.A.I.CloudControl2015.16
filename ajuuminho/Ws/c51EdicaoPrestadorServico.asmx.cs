using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLayer;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c51EdicaoPrestadorServico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c51EdicaoPrestadorServico : System.Web.Services.WebService
    {

        [WebMethod]
        public void editarPrestadorServico(string nome, string morada, string codPostal, string localidade, string email,
                                   string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            //// efetuar controlos
            //d21RepresentanteLegal rl = new d21RepresentanteLegal();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setRepresentanteLegal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarPrestadorServico(string nome, string morada, string codPostal, string localidade, string email,
    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d49PrestadorServicoDto ps = new d49PrestadorServicoDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            ps.guardar(ps);

        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d21RepresentanteLegal rl = new d21RepresentanteLegal();
        //    DataTable dt = rl.getListaRepresentanteLegal();
        //    return dt;
        //}

        [WebMethod]
        public d49PrestadorServicoDto getPrestadorServico(string id)
        {
            d49PrestadorServicoDto psdto = new d49PrestadorServicoDto();
            return psdto.getPrestadorServico(id);
        }

        [WebMethod]
        public Dictionary<String, String> getListaPrestadorServico()
        {

            d49PrestadorServicoDto pstdo = new d49PrestadorServicoDto();
            DataTable dt = pstdo.getListaPrestadorServico();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["id"]), Convert.ToString(dt.Rows[i]["nome"]));
            }
            return lista;

        }
    }
}
