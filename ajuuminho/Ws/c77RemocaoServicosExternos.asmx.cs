using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c77RemocaoServicosExternos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c77RemocaoServicosExternos : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerPrestacaoServico(string idPrestacaoServico)
        {
            // efetuar controlos
            d74ServicosExternosDto crdto = new d74ServicosExternosDto();
            crdto.removerPrestacaoServico(idPrestacaoServico);
        }
    }
}
