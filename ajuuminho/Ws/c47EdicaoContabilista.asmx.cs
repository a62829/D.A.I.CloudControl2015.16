using System;
using System.Collections.Generic;
using System.Web.Services;
using _BusinessLayer;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c47EdicaoContabilista
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c47EdicaoContabilista : System.Web.Services.WebService
    {
        [WebMethod]
        public void editarContabilista(string id, string nome, string morada, string codPostal, string localidade, string email,
             string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d45ContabilistaDto cdto = new d45ContabilistaDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            cdto.setContabilista(cdto);
            //// efetuar controlos
            //d45Contabilista rl = new d45Contabilista();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setContabilista(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarContabilista(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d45ContabilistaDto c = new d45ContabilistaDto();
            c.guardar(c);

        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d45Contabilista rl = new d45Contabilista();
        //    DataTable dt = rl.getListaContabilista();
        //    return dt;
        //}

        [WebMethod]
        public d45ContabilistaDto getContabilista(string id)
        {
            d45ContabilistaDto cdto = new d45ContabilistaDto();
            return cdto.getContabilista(id);
        }

        [WebMethod]
        public Dictionary<String, d45ContabilistaDto> getListaContabilista()
        {
            d45ContabilistaDto cdto = new d45ContabilistaDto();
            return cdto.getListaContabilista();
        }

        //[WebMethod]
        //public void adicionarContabilistaAoCredorNoProcesso(string idProcesso, string idContabilista, string lastChangeBy, string idInsolvente)
        //{
        //    d45ContabilistaDto idto = new d45ContabilistaDto();
        //    idto.adicionarContabilistaAoCredorNoProcesso(idProcesso, idContabilista, lastChangeBy, idInsolvente);
        //}

        [WebMethod]
        public void adicionarContabilistaAoInsolventeNoProcesso(string idProcesso, string idContabilista, string lastChangeBy, string idInsolvente)
        {
            d45ContabilistaDto idto = new d45ContabilistaDto();
            idto.adicionarContabilistaAoInsolventeNoProcesso(idProcesso, idContabilista, lastChangeBy, idInsolvente);
        }
    }
}
