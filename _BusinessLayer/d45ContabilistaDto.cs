using System.Data;
using System;
using _DataLayer;
using System.Collections.Generic;

namespace _BusinessLayer
{
    [Serializable]
    public class d45ContabilistaDto : Entidade
    {
        public string cc { get; set; }

        public d45ContabilistaDto()
        {

        }

        public d45ContabilistaDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d45ContabilistaDto(string id, string nome, string morada, string codPostal, string localidade, string email,
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

        public d45ContabilistaDto(DataTable dt, int i)
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

        public d45ContabilistaDto getContabilista(string id)
        {
            d45Contabilista c = new d45Contabilista();
            DataTable dt = c.getContabilista(id);
            d45ContabilistaDto cdto = new d45ContabilistaDto(dt, 0);
            return cdto;
        }

        public void setContabilista(d45ContabilistaDto ctdo)
        {
            d45Contabilista c = new d45Contabilista();
            c.setContabilista(ctdo.nome, ctdo.morada, ctdo.codPostal, ctdo.localidade, ctdo.email, ctdo.telefone, ctdo.telemovel, ctdo.fax, ctdo.cc, ctdo.iban, ctdo.nif, ctdo.lastChangeBy, ctdo.id);
        }

        public void guardar(d45ContabilistaDto cdto)
        {
            d45Contabilista c = new d45Contabilista();
            c.guardar(cdto.nome, cdto.morada, cdto.codPostal, cdto.localidade, cdto.email, cdto.telefone, cdto.telemovel, cdto.fax, cdto.cc, cdto.iban, cdto.nif, cdto.lastChangeBy);
        }

        public Dictionary<String, d45ContabilistaDto> getListaContabilista()
        {
            d45Contabilista c = new d45Contabilista();
            DataTable dt = c.getListaContabilista();
            Dictionary<String, d45ContabilistaDto> lista = new Dictionary<String, d45ContabilistaDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d45ContabilistaDto cdto = new d45ContabilistaDto(dt, i);
                lista.Add(i.ToString(), cdto);
            }
            return lista;
        }

        public void removerContabilista(string id)
        {
            d45Contabilista c = new d45Contabilista();
            c.removerContabilista(id);
        }

        public Dictionary<String, d45ContabilistaDto> getListaContabilistaNoProcesso(string id)
        {
            d45Contabilista c = new d45Contabilista();
            DataTable dt = c.getListaContabilistaNoProcesso(id);
            Dictionary<String, d45ContabilistaDto> lista = new Dictionary<String, d45ContabilistaDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d45ContabilistaDto cdto = new d45ContabilistaDto(dt, i);
                lista.Add(i.ToString(), cdto);
            }
            return lista;
        }

        public Dictionary<String, d45ContabilistaDto> getListaContabilistaForaDoProcesso(string id)
        {
            d45Contabilista c = new d45Contabilista();
            DataTable dt = c.getListaContabilistaForaDoProcesso(id);
            Dictionary<String, d45ContabilistaDto> lista = new Dictionary<String, d45ContabilistaDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d45ContabilistaDto cdto = new d45ContabilistaDto(dt, i);
                lista.Add(i.ToString(), cdto);
            }
            return lista;
        }

        public void adicionarContabilistaAoInsolventeNoProcesso(string idProcesso, string idContabilista, string lastChangeBy, string idInsolvente)
        {
            d45Contabilista i = new d45Contabilista();
            i.adicionarContabilistaAoInsolventeNoProcesso(idProcesso, idContabilista, lastChangeBy, idInsolvente);
        }

        //public void adicionarContabilistaAoCredorNoProcesso(string idProcesso, string idContabilista, string lastChangeBy, string idCredor)
        //{
        //    d45Contabilista i = new d45Contabilista();
        //    i.adicionarContabilistaAoCredorNoProcesso(idProcesso, idContabilista, lastChangeBy, idCredor);
        //}

        //public void removerContabilistaDoCredorNoProcesso(string idProcesso, string idTribunal, string lastChangeBy)
        //{
        //    d45Contabilista cr = new d45Contabilista();
        //    cr.removerContabilistaDoCredorNoProcesso(idProcesso, idTribunal, lastChangeBy);
        //}

        public void removerContabilistaDoInsolventeNoProcesso(string idProcesso, string idTribunal, string lastChangeBy)
        {
            d45Contabilista cr = new d45Contabilista();
            cr.removerContabilistaDoInsolventeNoProcesso(idProcesso, idTribunal, lastChangeBy);
        }
    }
}