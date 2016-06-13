using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c87
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c87 : System.Web.Services.WebService
    {

        [WebMethod]
        public Dictionary<String, d85ProcessoDto> getListaProcesso()
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            return pdto.getListaProcesso();
        }

        [WebMethod]
        public void setProcesso(string nome, string morada)
        {

            d85ProcessoDto pdto = new d85ProcessoDto(id, nome, morada);
            pdto.setProcesso(pdto);
            //// efetuar controlos
            //d21RepresentanteLegal rl = new d21RepresentanteLegal();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setRepresentanteLegal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarRepresentanteLegal(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d21RepresentanteLegalDto rl = new d21RepresentanteLegalDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            rl.guardar(rl);

        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d21RepresentanteLegal rl = new d21RepresentanteLegal();
        //    DataTable dt = rl.getListaRepresentanteLegal();
        //    return dt;
        //}

        [WebMethod]
        public d21RepresentanteLegalDto getRepresentanteLegal(string id)
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            return rldto.getRepresentanteLegal(id);
        }

        [WebMethod]
        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentantesLegais()
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            return rldto.getListaRepresentanteLegal();
        }
    }
}
