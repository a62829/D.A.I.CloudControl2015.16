using System.Data;
using System;
using _DataLayer;

namespace _BusinessLayer
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

        public d41InsolventeDto(DataTable dt, int i)
        {
            this.nome = Convert.ToString(dt.Rows[i]["nome"]);
            this.morada = Convert.ToString(dt.Rows[i]["morada"]);
            this.codPostal = Convert.ToString(dt.Rows[i]["codPostal"]);
            this.localidade = Convert.ToString(dt.Rows[i]["localidade"]);
            this.email = Convert.ToString(dt.Rows[i]["email"]);
            this.telefone = Convert.ToString(dt.Rows[i]["telefone"]);
            this.telemovel = Convert.ToString(dt.Rows[i]["telemovel"]);
            this.fax = Convert.ToString(dt.Rows[i]["fax"]);
            this.cc = Convert.ToString(dt.Rows[i]["cc"]);
            this.iban = Convert.ToString(dt.Rows[i]["iban"]);
            this.nif = Convert.ToString(dt.Rows[i]["nif"]);
            this.lastChangeBy = Convert.ToString(dt.Rows[i]["lastChangeBy"]);
        }

        public d41InsolventeDto getInsolvente(string id)
        {
            d41Insolvente rl = new d41Insolvente();
            DataTable dt = rl.getInsolvente(id);
            d41InsolventeDto rldto = new d41InsolventeDto(dt, 0);
            return rldto;
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