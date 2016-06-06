using System;
using System.Collections.Generic;
using System.Web.Services;
using _BusinessLayer;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c40RemocaoCredor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c40RemocaoCredor : System.Web.Services.WebService
    {
        [WebMethod]
        public void removerCredor(string id)
        {
            // efetuar controlos
            d37CredorDto cdto = new d37CredorDto();
            cdto.removerCredor(id);
        }


    }
}
