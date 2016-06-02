using System.Data;

namespace ajuUminho.App_Code
{
    public class d49PrestadorServicoDto : Entidade
    {
        public string cc { get; set; }

        public d49PrestadorServicoDto()
        {

        }

        public d49PrestadorServicoDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d49PrestadorServicoDto getPrestadorServico(string id)
        {
            d49PrestadorServico ps = new d49PrestadorServico();
            return ps.getPrestadorServico(id);
        }

        public void setPrestadorServico(d49PrestadorServicoDto psdto)
        {
            d49PrestadorServico ps = new d49PrestadorServico();
            ps.setPrestadorServico(psdto.nome, psdto.morada, psdto.codPostal, psdto.localidade, psdto.email, psdto.telefone, psdto.telemovel, psdto.fax, psdto.cc, psdto.iban, psdto.nif, psdto.lastChangeBy, psdto.id);
        }

        public void guardar(d49PrestadorServicoDto psdto)
        {
            d49PrestadorServico ps = new d49PrestadorServico();
            ps.guardar(psdto.nome, psdto.morada, psdto.codPostal, psdto.localidade, psdto.email, psdto.telefone, psdto.telemovel, psdto.fax, psdto.cc, psdto.iban, psdto.nif, psdto.lastChangeBy);
        }

        public DataTable getListaPrestadorServico()
        {
            d49PrestadorServico ps = new d49PrestadorServico();
            return ps.getListaPrestadorServico();
        }

        public void removerPrestadorServico(string id)
        {
            d49PrestadorServico ps = new d49PrestadorServico();
            ps.removerPrestadorServico(id);
        }
    }
}