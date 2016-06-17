using System;
using System.Collections.Generic;
using System.Web.Services;
using _BusinessLayer;
using System.Data;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c55RemocaoOutraEntidade
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c55RemocaoOutraEntidade : System.Web.Services.WebService
    {

        [WebMethod]
        public void editarOutraEntidade(string id, string nome, string morada, string codPostal, string localidade, string email,
    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto(id, nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            oedto.setOutraEntidade(oedto);
            //// efetuar controlos
            //d53OutraEntidade rl = new d53OutraEntidade();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setOutraEntidade(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}
        }

        [WebMethod]
        public void criarOutraEntidade(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            oedto.guardar(oedto);
        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d53OutraEntidade rl = new d53OutraEntidade();
        //    DataTable dt = rl.getListaOutraEntidade();
        //    return dt;
        //}

        [WebMethod]
        public d53OutraEntidadeDto getOutraEntidade(string id)
        {
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto();
            return oedto.getOutraEntidade(id);
        }

        [WebMethod]
        public Dictionary<String, d53OutraEntidadeDto> getListaOutraEntidade()
        {
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto();
            return oedto.getListaOutraEntidade();
        }

        [WebMethod]
        public void removerOutraEntidade(string id)
        {
            // efetuar controlos
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto();
            oedto.removerOutraEntidade(id);
        }

        [WebMethod]
        public void adicionarOutraEntidadeAoProcesso(string idProcesso, string idOutraEntidade, string lastChangeBy)
        {
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto();
            oedto.adicionarOutraEntidadeAoProcesso(idProcesso, idOutraEntidade, lastChangeBy);
        }
    }
}