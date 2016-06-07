using _BusinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c87
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c87 : System.Web.Services.WebService
    {

        [WebMethod]
        public Dictionary<String, d85ProcessoDto> getListaProcesso()
        {
            d85ProcessoDto rldto = new d85ProcessoDto();
            return rldto.getListaProcesso();
        }
    }
}
