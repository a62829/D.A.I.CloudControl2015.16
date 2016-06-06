using System.Data;

namespace ajuUminho.App_Code
{
    public class d33JuizDto : Entidade
    {
        public string cc { get; set; }

        public d33JuizDto()
        {

        }

        public d33JuizDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d33JuizDto getJuiz(string id)
        {
            d33Juiz j = new d33Juiz();
            return j.getJuiz(id);
        }

        public void setJuiz(d33JuizDto jdto)
        {
            d33Juiz j = new d33Juiz();
            j.setJuiz(jdto.nome, jdto.morada, jdto.codPostal, jdto.localidade, jdto.email, jdto.telefone, jdto.telemovel, jdto.fax, jdto.cc, jdto.iban, jdto.nif, jdto.lastChangeBy, jdto.id);
        }

        public void guardar(d33JuizDto jdto)
        {
            d33Juiz j = new d33Juiz();
            j.guardar(jdto.nome, jdto.morada, jdto.codPostal, jdto.localidade, jdto.email, jdto.telefone, jdto.telemovel, jdto.fax, jdto.cc, jdto.iban, jdto.nif, jdto.lastChangeBy);
        }

        public DataTable getListaJuiz()
        {
            d33Juiz j = new d33Juiz();
            return j.getListaJuiz();
        }

        public void removerJuiz(string id)
        {
            d33Juiz j = new d33Juiz();
            j.removerJuiz(id);
        }
    }
}