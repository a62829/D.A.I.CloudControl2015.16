using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c62RemocaoEventos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c62RemocaoEventos : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerEvento(string idEvento)
        {
            // efetuar controlos
            d59EventoDto crdto = new d59EventoDto();
            crdto.removerEvento(idEvento);
        }
    }
}
