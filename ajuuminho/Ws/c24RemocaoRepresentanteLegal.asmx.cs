using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ajuUminho.App_Code;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c24RemocaoRepresentanteLegal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c24RemocaoRepresentanteLegal : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerRepresentanteLegal(string id)
        {
            // efetuar controlos
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            rldto.removerRepresentanteLegal(id);
        }
    }
}
