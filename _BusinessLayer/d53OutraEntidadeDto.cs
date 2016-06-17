using System.Data;
using System;
using _DataLayer;
using System.Collections.Generic;

namespace _BusinessLayer
{
    [Serializable]
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

        public d53OutraEntidadeDto(string id, string nome, string morada, string codPostal, string localidade, string email,
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

        public d53OutraEntidadeDto(DataTable dt, int i)
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

        public d53OutraEntidadeDto getOutraEntidade(string id)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            DataTable dt = oe.getOutraEntidade(id);
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto(dt, 0);
            return oedto;
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

        public Dictionary<String, d53OutraEntidadeDto> getListaOutraEntidade()
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            DataTable dt = oe.getListaOutraEntidade();
            Dictionary<String, d53OutraEntidadeDto> lista = new Dictionary<String, d53OutraEntidadeDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d53OutraEntidadeDto oedto = new d53OutraEntidadeDto(dt, i);
                lista.Add(Convert.ToString(oedto.id), oedto);
            }
            return lista;
        }

        public void removerOutraEntidade(string id)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            oe.removerOutraEntidade(id);
        }

        public Dictionary<String, d53OutraEntidadeDto> getListaOutraEntidadeNoProcesso(string id)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            DataTable dt = oe.getListaOutraEntidadeNoProcesso(id);
            Dictionary<String, d53OutraEntidadeDto> lista = new Dictionary<String, d53OutraEntidadeDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d53OutraEntidadeDto oedto = new d53OutraEntidadeDto(dt, i);
                lista.Add(Convert.ToString(oedto.id), oedto);
            }
            return lista;
        }

        public Dictionary<String, d53OutraEntidadeDto> getListaOutraEntidadeForaDoProcesso(string id)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            DataTable dt = oe.getListaOutraEntidadeForaDoProcesso(id);
            Dictionary<String, d53OutraEntidadeDto> lista = new Dictionary<String, d53OutraEntidadeDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d53OutraEntidadeDto oedto = new d53OutraEntidadeDto(dt, i);
                lista.Add(Convert.ToString(oedto.id), oedto);
            }
            return lista;
        }

        public void adicionarOutraEntidadeAoProcesso(string idProcesso, string idOutraEntidade, string lastChangeBy)
        {
            d53OutraEntidade oe = new d53OutraEntidade();
            oe.adicionarOutraEntidadeAoProcesso(idProcesso, idOutraEntidade, lastChangeBy);
        }
    }
}