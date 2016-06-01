using System.Data;

namespace ajuUminho.App_Code
{
    public class d21RepresentanteLegalDto : Entidade
    {
        public string cc { get; set; }

        public d21RepresentanteLegalDto()
        {

        }

        public d21RepresentanteLegalDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d21RepresentanteLegalDto  getRepresentanteLegal(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            return rl.getRepresentanteLegal(id);
        }

        public void setRepresentanteLegal(d21RepresentanteLegalDto rldto)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            rl.setRepresentanteLegal(rldto.nome, rldto.morada, rldto.codPostal, rldto.localidade, rldto.email, rldto.telefone, rldto.telemovel, rldto.fax, rldto.cc, rldto.iban, rldto.nif, rldto.lastChangeBy, rldto.id);
        }

        public void guardar(d21RepresentanteLegalDto rldto)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            rl.guardar(rldto.nome, rldto.morada, rldto.codPostal, rldto.localidade, rldto.email, rldto.telefone, rldto.telemovel, rldto.fax, rldto.cc, rldto.iban, rldto.nif, rldto.lastChangeBy);
        }

        public DataTable getListaRepresentanteLegal()
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            return rl.getListaRepresentanteLegal();
        }

    }
}