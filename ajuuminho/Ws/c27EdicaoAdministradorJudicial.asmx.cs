using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _BusinessLayer;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c27EdicaoAdministradorJudicial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c27EdicaoAdministradorJudicial : System.Web.Services.WebService
    {

        [WebMethod]
        public void editarAdministradorJudicial(string id, string nome, string morada, string codPostal, string localidade, string email,
                    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            ajdto.setAdministradorJudicial(ajdto);
            //// efetuar controlos
            //d21RepresentanteLegal rl = new d21RepresentanteLegal();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setRepresentanteLegal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}
        }

        [WebMethod]
        public void criarAdministradorJudicial(string nome, string morada, string codPostal, string localidade, string email,
    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            ajdto.guardar(ajdto);
        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d21RepresentanteLegal rl = new d21RepresentanteLegal();
        //    DataTable dt = rl.getListaRepresentanteLegal();
        //    return dt;
        //}

        [WebMethod]
        public d25AdministradorJudicialDto getAdministradorJudicial(string id)
        {
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto();
            return ajdto.getAdministradorJudicial(id);
        }

        [WebMethod]
        public Dictionary<String, d25AdministradorJudicialDto> getListaAdministradorJudicial()
        {
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto();
            return ajdto.getListaAdministradorJudicial();
        }
    }
}
