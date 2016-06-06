using System.Data;

namespace ajuUminho.App_Code
{
    public class d53OutraEntidadeDto : Entidade
    {
        public string cc { get; set; }

        public d53OutraEntidadeDto()
        {

        }

        public d53OutraEntidadeDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d53OutraEntidadeDto getOutraEntidade(string id)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            return oe.getOutraEntidade(id);
        }

        public void setOutraEntidade(d53OutraEntidadeDto oedto)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            oe.setOutraEntidade(oedto.nome, oedto.morada, oedto.codPostal, oedto.localidade, oedto.email, oedto.telefone, oedto.telemovel, oedto.fax, oedto.cc, oedto.iban, oedto.nif, oedto.lastChangeBy, oedto.id);
        }

        public void guardar(d53OutraEntidadeDto oedto)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            oe.guardar(oedto.nome, oedto.morada, oedto.codPostal, oedto.localidade, oedto.email, oedto.telefone, oedto.telemovel, oedto.fax, oedto.cc, oedto.iban, oedto.nif, oedto.lastChangeBy);
        }

        public DataTable getListaOutraEntidade()
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            return oe.getListaOutraEntidade();
        }

        public void removerOutraEntidade(string id)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            oe.removerOutraEntidade(id);
        }
    }
}