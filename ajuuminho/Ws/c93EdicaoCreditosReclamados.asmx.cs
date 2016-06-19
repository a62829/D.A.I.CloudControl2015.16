using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c93EdicaoCreditosReclamados
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c93EdicaoCreditosReclamados : System.Web.Services.WebService
    {
        public class c93EdicaoCreditosReclamados : System.Web.Services.WebService
        {
            [WebMethod]
            public void editarCreditosReclamados(string idCreditoReclamado, string descricao, string valorDivida,
                string valorRecebido, string lastChangeBy)
            {
                d90CreditosReclamadosDto bdto = new d90CreditosReclamadosDto(idCreditoReclamado, descricao, valorDivida, valorRecebido, lastChangeBy);
                bdto.setCreditoReclamado(bdto);
            }

            [WebMethod]
            public void criarCreditoReclamado(string idCreditoReclamado, string idCredorNoProcesso, string descricao, string valorDivida,
                string valorRecebido, string lastChangeBy)
            {
                d90CreditosReclamadosDto c = new d90CreditosReclamadosDto(idCreditoReclamado, idCredorNoProcesso, descricao, valorDivida, valorRecebido, lastChangeBy);
                c.guardar(c);
            }

            [WebMethod]
            public d90CreditosReclamadosDto getCreditoReclamado(string idCreditoReclamado)
            {
                d90CreditosReclamadosDto cdto = new d90CreditosReclamadosDto();
                return cdto.getCreditoReclamado(idCreditoReclamado);
            }

            [WebMethod]
            public Dictionary<String, d90CreditosReclamadosDto> getListaCreditosReclamados(string idProcesso, string idCredor)
            {
                d90CreditosReclamadosDto cdto = new d90CreditosReclamadosDto();
                string x = cdto.getIdCredorNoProcesso(idProcesso, idCredor);
                return cdto.getListaCreditosReclamados(x);
            }
        }
    }
}