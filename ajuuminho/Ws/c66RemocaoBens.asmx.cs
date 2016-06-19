using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _BusinessLayer;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c66RemocaoBens
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c66RemocaoBens : System.Web.Services.WebService
    {
        [WebMethod]
        public void removerBem(string idBem)
        {
            // efetuar controlos
            d63BensDto bdto = new d63BensDto();
            bdto.removerBem(idBem);
        }
    }
}
