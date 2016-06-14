using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c31EdicaoTribunal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c31EdicaoTribunal : System.Web.Services.WebService
    {

        [WebMethod]
        public void editarTribunal(string id, string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string iban, string nif, string lastChangeBy)
        {
            d29TribunalDto rldto = new d29TribunalDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, iban, nif, lastChangeBy);
            rldto.setTribunal(rldto);
            //// efetuar controlos
            //d29Tribunal t = new d29Tribunal();
            //var id = t.getID();
            //if (t.Unique(, id) == true)
            //{
            //    t.setTribunal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarTribunal(string nome, string morada, string codPostal, string localidade, string email,
   string telefone, string telemovel, string fax, string iban, string nif, string lastChangeBy)
        {
            d29TribunalDto rl = new d29TribunalDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, iban, nif, lastChangeBy);
            rl.guardar(rl);

        }

        //[WebMethod]
        //public DataTable listarTribunal()
        //{
        //    d29Tribunal t = new d29Tribunal();
        //    DataTable dt = t.getListaTribunal();
        //    return dt;
        //}

        [WebMethod]
        public d29TribunalDto getTribunal(string id)
        {
            d29TribunalDto tdto = new d29TribunalDto();
            return tdto.getTribunal(id);
        }

        [WebMethod]
        public Dictionary<String, d29TribunalDto> getListaTribunal()
        {
            d29TribunalDto tdto = new d29TribunalDto();
            return tdto.getListaTribunal();
        }
    }
}
