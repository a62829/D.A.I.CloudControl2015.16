using _BusinessLayer;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c28RemocaoAdministradorJudicial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c28RemocaoAdministradorJudicial : System.Web.Services.WebService
    {

        [WebMethod]
        public void removerAdministradorJudicial(string id)
        {
            // efetuar controlos
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto();
            ajdto.removerAdministradorJudicial(id);
        }

        [WebMethod]
        public void removerAdministradorJudicialDoProcesso(string idProcesso, string idAdministradorJudicial, string lastChangeBy)
        {
            d25AdministradorJudicialDto jdto = new d25AdministradorJudicialDto();
            jdto.removerAdministradorJudicialDoProcesso(idProcesso, idAdministradorJudicial, lastChangeBy);
        }
    }
}
