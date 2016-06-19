using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c95RemocaoCreditosReclamados
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c95RemocaoCreditosReclamados : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerCreditoReclamado(string idProcesso, string idCredor)
        {
            // efetuar controlos
            d90CreditosReclamadosDto crdto = new d90CreditosReclamadosDto();
            string x = crdto.getIdCredorNoProcesso(idProcesso, idCredor);
            crdto.removerCreditoReclamado(x);
        }
    }
}
