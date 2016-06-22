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
    public class c87SuspenderProcesso : System.Web.Services.WebService
    {

        [WebMethod]
        public Dictionary<String, d85ProcessoDto> getListaProcesso()
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            return pdto.getListaProcesso();
        }

        [WebMethod]
        public void setProcesso(string idEstado, string idTipoProcesso,string lastChangeBy, string idProcesso)
        {

            d85ProcessoDto pdto = new d85ProcessoDto(idEstado, idTipoProcesso, lastChangeBy, idProcesso);
            pdto.setProcesso(pdto);
        }

        [WebMethod]
        public void criarProcesso(string idLegal, string idEstado, string idTipoProcesso, string lastChangeBy, string idInsolvente)
        {
            d85ProcessoDto pdto = new d85ProcessoDto(idLegal, idEstado, idTipoProcesso, DateTime.Now.ToString(), lastChangeBy);
            pdto.criarProcesso(pdto, idInsolvente);
        }

        [WebMethod]
        public d85ProcessoDto getProcesso(string id)
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            return pdto.getProcesso(id);
        }

        [WebMethod]
        public d85ProcessoDto getProcessoCompleto(string id)
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            return pdto.getProcessoCompleto(id);
        }

        [WebMethod]
        public Dictionary<String, String> getListaEstado()
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            return pdto.getListaEstado();
        }

        [WebMethod]
        public Dictionary<String, String> getListaTipoProcesso()
        {
            d85ProcessoDto pdto = new d85ProcessoDto();
            return pdto.getListaTipoProcesso();
        }
    }
}
