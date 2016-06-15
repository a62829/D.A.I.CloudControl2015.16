using System.Data;
using _DataLayer;
using System;
using System.Collections.Generic;

namespace _BusinessLayer
{
    [Serializable]
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

        public d33JuizDto(string id, string nome, string morada, string codPostal, string localidade, string email,
    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            this.id = id;
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

        public d33JuizDto(DataTable dt, int i)
        {
            this.id = Convert.ToString(dt.Rows[i]["id"]);
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

        public d33JuizDto getJuiz(string id)
        {
            d33Juiz rl = new d33Juiz();
            DataTable dt = rl.getJuiz(id);
            d33JuizDto rldto = new d33JuizDto(dt, 0);
            return rldto;
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

        public Dictionary<String, d33JuizDto> getListaJuiz()
        {
            d33Juiz j = new d33Juiz();
            DataTable dt = j.getListaJuiz();
            Dictionary<String, d33JuizDto> lista = new Dictionary<String, d33JuizDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d33JuizDto jdto = new d33JuizDto(dt, i);
                lista.Add(Convert.ToString(jdto.id), jdto);
            }
            return lista;
        }

        public void removerJuiz(string id)
        {
            d33Juiz j = new d33Juiz();
            j.removerJuiz(id);
        }

        public Dictionary<String, d33JuizDto> getListaJuizNoProcesso(string id)
        {
            d33Juiz j = new d33Juiz();
            DataTable dt = j.getListaJuizNoProcesso(id);
            Dictionary<String, d33JuizDto> lista = new Dictionary<String, d33JuizDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d33JuizDto jdto = new d33JuizDto(dt, i);
                lista.Add(Convert.ToString(jdto.id), jdto);
            }
            return lista;
        }

        public Dictionary<String, d33JuizDto> getListaJuizForaDoProcesso(string id)
        {
            d33Juiz j = new d33Juiz();
            DataTable dt = j.getListaJuizForaDoProcesso(id);
            Dictionary<String, d33JuizDto> lista = new Dictionary<String, d33JuizDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d33JuizDto jdto = new d33JuizDto(dt, i);
                lista.Add(Convert.ToString(jdto.id), jdto);
            }
            return lista;
        }
    }
}