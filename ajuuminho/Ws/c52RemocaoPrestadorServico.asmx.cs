using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c52RemocaoPrestadorServico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c52RemocaoPrestadorServico : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerPrestadorServico(string id)
        {
            // efetuar controlos
            d49PrestadorServicoDto pstdo = new d49PrestadorServicoDto();
            pstdo.removerPrestadorServico(id);
        }

        [WebMethod]
        public void removerPrestadorServicoDoProcesso(string idProcesso, string idPrestadorServico, string lastChangeBy)
        {
            d49PrestadorServicoDto psdto = new d49PrestadorServicoDto();
            psdto.removerPrestadorServicoDoProcesso(idProcesso, idPrestadorServico, lastChangeBy);
        }
    }
}
