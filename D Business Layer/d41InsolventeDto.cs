using System.Data;

namespace ajuUminho.App_Code
{
    public class d41InsolventeDto : Entidade
    {
        public string cc { get; set; }

        public d41InsolventeDto()
        {

        }

        public d41InsolventeDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d41InsolventeDto getInsolvente(string id)
        {
            d41Insolvente i = new d41Insolvente();
            return i.getInsolvente(id);
        }

        public void setInsolvente(d41InsolventeDto idto)
        {
            d41Insolvente i = new d41Insolvente();
            i.setInsolvente(idto.nome, idto.morada, idto.codPostal, idto.localidade, idto.email, idto.telefone, idto.telemovel, idto.fax, idto.cc, idto.iban, idto.nif, idto.lastChangeBy, idto.id);
        }

        public void guardar(d41InsolventeDto idto)
        {
            d41Insolvente i = new d41Insolvente();
            i.guardar(idto.nome, idto.morada, idto.codPostal, idto.localidade, idto.email, idto.telefone, idto.telemovel, idto.fax, idto.cc, idto.iban, idto.nif, idto.lastChangeBy);
        }

        public DataTable getListaInsolvente()
        {
            d41Insolvente i = new d41Insolvente();
            return i.getListaInsolvente();
        }

        public void removerInsolvente(string id)
        {
            d41Insolvente i = new d41Insolvente();
            i.removerInsolvente(id);
        }
    }
}