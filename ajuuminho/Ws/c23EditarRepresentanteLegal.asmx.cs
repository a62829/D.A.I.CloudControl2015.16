using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c23EditarRepresentanteLegal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c23EditarRepresentanteLegal : System.Web.Services.WebService
    {

        [WebMethod]
        public void editarRepresentanteLegal(string id, string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            rldto.setRepresentanteLegal(rldto);
        }

        [WebMethod]
        public void criarRepresentanteLegal (string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax , cc , iban, nif, lastChangeBy);
            rldto.guardar(rldto);
        }

        [WebMethod]
        public d21RepresentanteLegalDto getRepresentanteLegal(string id)
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            return rldto.getRepresentanteLegal(id);
        }

        [WebMethod]
        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegal()
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            return rldto.getListaRepresentanteLegal();
        }
    }
}
