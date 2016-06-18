using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c65EdicaoBens
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c65EdicaoBens : System.Web.Services.WebService
    {

        [WebMethod]
        public void editarBens(string idBem, string idTipoAtivo, string descricao, string valorAquisicao,
            string valorMercado, string valorLiquidacao, string lastChangeBy)
        {
            d63BensDto bdto = new d63BensDto(idBem, idTipoAtivo, descricao, valorAquisicao, valorMercado, valorLiquidacao, lastChangeBy);
            bdto.setBem(bdto);
        }

        [WebMethod]
        public void criarBens(string idBem, string idInsolventeNoProcesso, string idTipoAtivo, string descricao, string valorAquisicao,
            string valorMercado, string valorLiquidacao, string lastChangeBy)
        {
            d63BensDto c = new d63BensDto(idBem, idInsolventeNoProcesso, idTipoAtivo, descricao, valorAquisicao, valorMercado,
                valorLiquidacao, lastChangeBy);
            c.guardar(c);

        }

        [WebMethod]
        public d63BensDto getBem(string idBem)
        {
            d63BensDto cdto = new d63BensDto();
            return cdto.getBem(idBem);
        }

        [WebMethod]
        public Dictionary<String, d63BensDto> getListaBens(string idProcesso, string idInsolvente)
        {
            d63BensDto cdto = new d63BensDto();
            string x = cdto.getIdInsolventeNoProcesso(idProcesso, idInsolvente);
            return cdto.getListaBens(x);
        }

    }
}
