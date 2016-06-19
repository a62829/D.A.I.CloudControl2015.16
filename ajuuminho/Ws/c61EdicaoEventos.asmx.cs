using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c61EdicaoEventos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c61EdicaoEventos : System.Web.Services.WebService
    {

        [WebMethod]
        public d59EventoDto getEvento(string idEvento)
        {
            d59EventoDto edto = new d59EventoDto();
            return edto.getEvento(idEvento);
        }

        [WebMethod]
        public void editarEvento(string idEvento, string idProcesso, string idTipoEvento, string descricao, string dataEvento, string lastChangeBy)
        {
            d59EventoDto edto = new d59EventoDto(idEvento, idProcesso, idTipoEvento, descricao, dataEvento, lastChangeBy);
            edto.setEvento(edto);
        }

        [WebMethod]
        public void criarEvento(string idEvento, string idProcesso, string idTipoEvento, string descricao, string dataEvento, string lastChangeBy)
        {
            d59EventoDto e = new d59EventoDto(idEvento, idProcesso, idTipoEvento, descricao, dataEvento, lastChangeBy);
            e.guardar(e);
        }

        [WebMethod]
        public Dictionary<String, d59EventoDto> getListaEventos(string idProcesso)
        {
            d59EventoDto cdto = new d59EventoDto();
            return cdto.getListaEventos(idProcesso);
        }
    }
}
