using System.Data;
using DataLayer;
using System;

namespace BusinessLayer
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

        public d29TribunalDto(DataTable dt, int i)
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

        public d29TribunalDto getTribunal(string id)
        {
            d29Tribunal t = new d29Tribunal();
            DataTable dt = t.getTribunal(id);
            int nrows = dt.Rows.Count;
            d29TribunalDto tdto = new d29TribunalDto(dt, nrows);
            return tdto;
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