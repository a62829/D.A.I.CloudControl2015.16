using System.Data;

namespace ajuUminho.App_Code
{
    public class d29TribunalDto : Entidade
    {
        public string cc { get; set; }

        public d29TribunalDto()
        {

        }

        public d29TribunalDto(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string iban, string nif, string lastChangeBy)
        {
            this.nome = nome;
            this.morada = morada;
            this.codPostal = codPostal;
            this.localidade = localidade;
            this.email = email;
            this.telefone = telefone;
            this.telemovel = telemovel;
            this.fax = fax;
            this.iban = iban;
            this.nif = nif;
            this.lastChangeBy = lastChangeBy;
        }

        public d29TribunalDto getTribunal(string id)
        {
            d29Tribunal t = new d29Tribunal();
            return t.getTribunal(id);
        }

        public void setTribunal(d29TribunalDto tdto)
        {
            d29Tribunal t = new d29Tribunal();
            t.setTribunal(tdto.nome, tdto.morada, tdto.codPostal, tdto.localidade, tdto.email, tdto.telefone, tdto.telemovel, tdto.fax, tdto.iban, tdto.nif, tdto.lastChangeBy, tdto.id);
        }

        public void guardar(d29TribunalDto tdto)
        {
            d29Tribunal t = new d29Tribunal();
            t.guardar(tdto.nome, tdto.morada, tdto.codPostal, tdto.localidade, tdto.email, tdto.telefone, tdto.telemovel, tdto.fax, tdto.iban, tdto.nif, tdto.lastChangeBy);
        }

        public DataTable getListaTribunal()
        {
            d29Tribunal t = new d29Tribunal();
            return t.getListaTribunal();
        }

        public void removerTribunal(string id)
        {
            d29Tribunal t = new d29Tribunal();
            t.removerTribunal(id);
        }
    }
}