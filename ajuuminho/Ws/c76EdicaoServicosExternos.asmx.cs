using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c76EdicaoServicosExternos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c76EdicaoServicosExternos : System.Web.Services.WebService
    {
        [WebMethod]
        public void editarServicosExternos(string idPrestacaoServico, string descricao, string valorPagar,
                        string valorPago, string lastChangeBy)
        {
            d74ServicosExternosDto psdto = new d74ServicosExternosDto(idPrestacaoServico, descricao, valorPagar, valorPago, lastChangeBy);
            psdto.setPrestacaoServico(psdto);
        }

        [WebMethod]
        public void criarPrestacaoServico(string idPrestacaoServico, string idPrestadorServicoNoProcesso, string descricao, string valorPagar,
            string valorPago, string lastChangeBy)
        {
            d74ServicosExternosDto sedto = new d74ServicosExternosDto(idPrestacaoServico, idPrestadorServicoNoProcesso, descricao, valorPagar, valorPago, lastChangeBy);
            sedto.guardar(sedto);
        }

        [WebMethod]
        public d74ServicosExternosDto getServicoExterno(string idPrestacaoServico)
        {
            d74ServicosExternosDto psdto = new d74ServicosExternosDto();
            return psdto.getPrestacaoServico(idPrestacaoServico);
        }

        [WebMethod]
        public Dictionary<String, d74ServicosExternosDto> getListaPrestacoesServicos(string idProcesso, string idPrestadorServicos)
        {
            d74ServicosExternosDto cdto = new d74ServicosExternosDto();
            string x = cdto.getIdPrestadorServicoNoProcesso(idProcesso, idPrestadorServicos);
            return cdto.getListaPrestacoesServicos(x);
        }
    }
}