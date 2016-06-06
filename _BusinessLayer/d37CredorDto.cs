using System.Data;
using System;
using _DataLayer;
using System.Collections.Generic;

namespace _BusinessLayer
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

        public d37CredorDto(DataTable dt, int i)
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

        public d37CredorDto getCredor(string id)
        {
            d37Credor rl = new d37Credor();
            DataTable dt = rl.getCredor(id);
            d37CredorDto rldto = new d37CredorDto(dt, 0);
            return rldto;
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

        public Dictionary<String, d37CredorDto> getListaCredor()
        {
            d37Credor rl = new d37Credor();
            DataTable dt = rl.getListaCredor();
            Dictionary<String, d37CredorDto> lista = new Dictionary<String, d37CredorDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d37CredorDto rldto = new d37CredorDto(dt, i);
                lista.Add(Convert.ToString(rldto.id), rldto);
            }
            return lista;
        }

        public Dictionary<String, d37CredorDto> getListaCredorNoProcesso(string id)
        {
            d37Credor c = new d37Credor();
            DataTable dt = c.getListaCredorNoProcesso(id);
            Dictionary<String, d37CredorDto> lista = new Dictionary<String, d37CredorDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d37CredorDto cdto = new d37CredorDto(dt, i);
                lista.Add(Convert.ToString(cdto.id), cdto);
            }
            return lista;
        }

        public void removerCredor(string id)
        {
            d37Credor c = new d37Credor();
            c.removerCredor(id);
        }
    }
}