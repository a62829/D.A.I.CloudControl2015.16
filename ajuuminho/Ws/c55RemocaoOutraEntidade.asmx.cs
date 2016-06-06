using System;
using System.Collections.Generic;
using System.Web.Services;
using BusinessLayer;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c55RemocaoOutraEntidade
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c55RemocaoOutraEntidade : System.Web.Services.WebService
    {
        [WebMethod]
        public void removerOutraEntidade(string id)
        {
            // efetuar controlos
            d53OutraEntidadeDto cdto = new d53OutraEntidadeDto();
            cdto.removerOutraEntidade(id);
        }


    }
}