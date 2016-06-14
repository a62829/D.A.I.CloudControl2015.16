using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c35EdicaoJuiz
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c35EdicaoJuiz : System.Web.Services.WebService
    {
        [WebMethod]
        public void editarJuiz(string id, string nome, string morada, string codPostal, string localidade, string email,
                    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d33JuizDto jdto = new d33JuizDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            jdto.setJuiz(jdto);
        }

        [WebMethod]
        public void criarJuiz(string nome, string morada, string codPostal, string localidade, string email,
    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d33JuizDto j = new d33JuizDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            j.guardar(j);
        }

        [WebMethod]
        public d33JuizDto getJuiz(string id)
        {
            d33JuizDto jdto = new d33JuizDto();
            return jdto.getJuiz(id);
        }

        [WebMethod]
        public Dictionary<String, d33JuizDto> getListaJuiz()
        {
            d33JuizDto jdto = new d33JuizDto();
            return jdto.getListaJuiz();
        }
    }
}
