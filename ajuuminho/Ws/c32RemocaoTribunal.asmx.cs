using System;
using System.Collections.Generic;
using System.Web.Services;
using _BusinessLayer;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c32RemocaoTribunal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c32RemocaoTribunal : System.Web.Services.WebService
    {
        [WebMethod]
        public void removerTribunal(string id)
        {
            // efetuar controlos
            d29TribunalDto tdto = new d29TribunalDto();
            tdto.removerTribunal(id);
        }

        [WebMethod]
        public void removerTribunalDoProcesso(string idProcesso, string idTribunal, string lastChangeBy)
        {
            d29TribunalDto tdto = new d29TribunalDto();
            tdto.removerTribunalDoProcesso(idProcesso, idTribunal, lastChangeBy);
        }
    }
}
