using System.Data;
using System;
using DataLayer;

namespace BusinessLayer
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

        public d49PrestadorServicoDto(DataTable dt, int i)
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

        public d49PrestadorServicoDto getPrestadorServico(string id)
        {
            d49PrestadorServico rl = new d49PrestadorServico();
            DataTable dt = rl.getPrestadorServico(id);
            int nrows = dt.Rows.Count;
            d49PrestadorServicoDto rldto = new d49PrestadorServicoDto(dt, nrows);
            return rldto;
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