using System.Data;
using System;
using DataLayer;

namespace BusinessLayer
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

        public d53OutraEntidadeDto(DataTable dt, int i)
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

        public d53OutraEntidadeDto getOutraEntidade(string id)
        {
            d53OutraEntidade rl = new d53OutraEntidade();
            DataTable dt = rl.getOutraEntidade(id);
            int nrows = dt.Rows.Count;
            d53OutraEntidadeDto rldto = new d53OutraEntidadeDto(dt, nrows);
            return rldto;
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