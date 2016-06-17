using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c43EdicaoInsolvente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c43EdicaoInsolvente : System.Web.Services.WebService
    {
        [WebMethod]
        public void editarInsolvente(string id, string nome, string morada, string codPostal, string localidade, string email,
                            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d41InsolventeDto idto = new d41InsolventeDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            idto.setInsolvente(idto);
            //// efetuar controlos
            //d21RepresentanteLegal rl = new d21RepresentanteLegal();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setRepresentanteLegal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarInsolvente(string nome, string morada, string codPostal, string localidade, string email,
    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d41InsolventeDto i = new d41InsolventeDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            i.guardar(i);

        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d21RepresentanteLegal rl = new d21RepresentanteLegal();
        //    DataTable dt = rl.getListaRepresentanteLegal();
        //    return dt;
        //}

        [WebMethod]
        public d41InsolventeDto getInsolvente(string id)
        {
            d41InsolventeDto idto = new d41InsolventeDto();
            return idto.getInsolvente(id);
        }

        [WebMethod]
        public Dictionary<String, d41InsolventeDto> getListaInsolvente()
        {
            d41InsolventeDto cdto = new d41InsolventeDto();
            return cdto.getListaInsolvente();
        }

        [WebMethod]
        public void adicionarInsolventeAoProcesso(string idProcesso, string idInsolvente, string lastChangeBy)
        {
            d41InsolventeDto idto = new d41InsolventeDto();
            idto.adicionarInsolventeAoProcesso(idProcesso, idInsolvente, lastChangeBy);
        }
    }
}
