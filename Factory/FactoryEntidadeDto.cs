using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ajuUminho.App_Code;

namespace Factory
{
    public class FactoryEntidadeDto
    {
        private static Dictionary<string, Entidade> entidades = new Dictionary<string, Entidade>();

        //static Factory()
        //{
        //    custs.Add("Customer", new Customer());
        //    custs.Add("Lead", new Lead());
        //}

        public static Entidade Create(string tipoEnt)
        {
            // Design Pattern : Lazzy Loading (Oposite of Eager Loading)
            if (entidades.Count == 0)
            {
                entidades.Add("RepresenteLegal", new d21RepresentanteLegalDto());
                entidades.Add("AdministradorJudicial", new d25AdministradorJudicialDto());
                entidades.Add("Tribunal", new d29TribunalDto());
                entidades.Add("Juiz", new d33JuizDto());
                entidades.Add("Credor", new d37CredorDto());
                entidades.Add("Insolvente", new d41InsolventeDto());
                entidades.Add("Contabilista", new d45ContabilistaDto());
                entidades.Add("PrestadorServico", new d49PrestadorServicoDto());
                entidades.Add("OutraEntidade", new d53OutraEntidadeDto());

            }
            //Design Pattern : RIP Pattern - Replace If with Polymorphism
            return entidades[tipoEnt];
        }
    }
}
