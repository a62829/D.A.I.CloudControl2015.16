using System.Data;

namespace ajuUminho.App_Code
{
    public class d45ContabilistaDto : Entidade
    {
        public string cc { get; set; }

        public d45ContabilistaDto()
        {

        }

        public d45ContabilistaDto(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            this.nome = nome;
            this.morada = morada;
            this.codPostal = codPostal;
            this.localidade = localidade;
            this.email = email;
            this.telefone = telefone;
            this.telemovel = telemovel;
            this.fax = fax;
            this.cc = cc;
            this.iban = iban;
            this.nif = nif;
            this.lastChangeBy = lastChangeBy;
        }

        public d45ContabilistaDto getContabilista(string id)
        {
            d45Contabilista c = new d45Contabilista();
            return c.getContabilista(id);
        }

        public void setContabilista(d45ContabilistaDto ctdo)
        {
            d45Contabilista c = new d45Contabilista();
            c.setContabilista(ctdo.nome, ctdo.morada, ctdo.codPostal, ctdo.localidade, ctdo.email, ctdo.telefone, ctdo.telemovel, ctdo.fax, ctdo.cc, ctdo.iban, ctdo.nif, ctdo.lastChangeBy, ctdo.id);
        }

        public void guardar(d45ContabilistaDto cdto)
        {
            d45Contabilista c = new d45Contabilista();
            c.guardar(cdto.nome, cdto.morada, cdto.codPostal, cdto.localidade, cdto.email, cdto.telefone, cdto.telemovel, cdto.fax, cdto.cc, cdto.iban, cdto.nif, cdto.lastChangeBy);
        }

        public DataTable getListaContabilista()
        {
            d45Contabilista c = new d45Contabilista();
            return c.getListaContabilista();
        }

        public void removerContabilista(string id)
        {
            d45Contabilista c = new d45Contabilista();
            c.removerContabilista(id);
        }
    }
}