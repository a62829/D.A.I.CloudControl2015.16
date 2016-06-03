using System;
using System.Collections.Generic;
using System.Web.Services;
using ajuUminho.App_Code;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c48RemocaoContabilista
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c48RemocaoContabilista : System.Web.Services.WebService
    {
        [WebMethod]
        public void removerContabilista(string id)
        {
            // efetuar controlos
            d45ContabilistaDto cdto = new d45ContabilistaDto();
            cdto.removerContabilista(id);
        }


    }
}
