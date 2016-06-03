using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ajuUminho.App_Code;
namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c44RemocaoInsolvente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c44RemocaoInsolvente : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerInsolvente(string id)
        {
            // efetuar controlos
            d41InsolventeDto idto = new d41InsolventeDto();
            idto.removerInsolvente(id);
        }
    }
}
