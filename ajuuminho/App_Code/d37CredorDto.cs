using System.Data;

namespace ajuUminho.App_Code
{
    public class d37CredorDto : Entidade
    {
        public string cc { get; set; }

        public d37CredorDto()
        {

        }

        public d37CredorDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d37CredorDto getCredor(string id)
        {
            d37Credor c = new d37Credor();
            return c.getCredor(id);
        }

        public void setCredor(d37CredorDto cdto)
        {
            d37Credor c = new d37Credor();
            c.setCredor(cdto.nome, cdto.morada, cdto.codPostal, cdto.localidade, cdto.email, cdto.telefone, cdto.telemovel, cdto.fax, cdto.cc, cdto.iban, cdto.nif, cdto.lastChangeBy, cdto.id);
        }

        public void guardar(d37CredorDto cdto)
        {
            d37Credor c = new d37Credor();
            c.guardar(cdto.nome, cdto.morada, cdto.codPostal, cdto.localidade, cdto.email, cdto.telefone, cdto.telemovel, cdto.fax, cdto.cc, cdto.iban, cdto.nif, cdto.lastChangeBy);
        }

        public DataTable getListaCredor()
        {
            d37Credor c = new d37Credor();
            return c.getListaCredor();
        }

        public void removerCredor(string id)
        {
            d37Credor c = new d37Credor();
            c.removerCredor(id);
        }
    }
}