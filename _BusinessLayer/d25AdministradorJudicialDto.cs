﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using _DataLayer;

namespace _BusinessLayer
{
    [Serializable]
    public class d25AdministradorJudicialDto : Entidade
    {
        public string cc { get; set; }

        public d25AdministradorJudicialDto()
        {

        }

        public d25AdministradorJudicialDto(string id, string nome, string morada, string codPostal, string localidade, string email,
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

        public d25AdministradorJudicialDto(string nome, string morada, string codPostal, string localidade, string email,
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

        public d25AdministradorJudicialDto(DataTable dt, int i)
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

        public d25AdministradorJudicialDto getAdministradorJudicial(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            DataTable dt = aj.getAdministradorJudicial(id);
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(dt, 0);
            return ajdto;
        }

        public void setAdministradorJudicial(d25AdministradorJudicialDto ajdto)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            aj.setAdministradorJudicial(ajdto.nome, ajdto.morada, ajdto.codPostal, ajdto.localidade, ajdto.email, ajdto.telefone, ajdto.telemovel, ajdto.fax, ajdto.cc, ajdto.iban, ajdto.nif, ajdto.lastChangeBy, ajdto.id);
        }

        public void guardar(d25AdministradorJudicialDto ajdto)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            aj.guardar(ajdto.nome, ajdto.morada, ajdto.codPostal, ajdto.localidade, ajdto.email, ajdto.telefone, ajdto.telemovel, ajdto.fax, ajdto.cc, ajdto.iban, ajdto.nif, ajdto.lastChangeBy);
        }

        public Dictionary<String, d25AdministradorJudicialDto> getListaAdministradorJudicial()
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            DataTable dt = aj.getListaAdministradorJudicial();
            Dictionary<String, d25AdministradorJudicialDto> lista = new Dictionary<String, d25AdministradorJudicialDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(dt, i);
                lista.Add(i.ToString(), ajdto);
            }
            return lista;
        }

        public void removerAdministradorJudicial(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            aj.removerAdministradorJudicial(id);
        }

        public Dictionary<String, d25AdministradorJudicialDto> getListaAdministradorJudicialNoProcesso(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            DataTable dt = aj.getListaAdministradorJudicialNoProcesso(id);
            Dictionary<String, d25AdministradorJudicialDto> lista = new Dictionary<String, d25AdministradorJudicialDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(dt, i);
                lista.Add(i.ToString(), ajdto);
            }
            return lista;
        }

        public Dictionary<String, d25AdministradorJudicialDto> getListaAdministradorJudicialForaDoProcesso(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            DataTable dt = aj.getListaAdministradorJudicialForaDoProcesso(id);
            Dictionary<String, d25AdministradorJudicialDto> lista = new Dictionary<String, d25AdministradorJudicialDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(dt, i);
                lista.Add(i.ToString(), ajdto);
            }
            return lista;
        }

        public void adicionarAdministradorJudicialAoProcesso(string idProcesso, string idAdministradorJudicial, string lastChangeBy)
        {
            d25AdministradorJudicial cr = new d25AdministradorJudicial();
            cr.adicionarAdministradorJudicialAoProcesso(idProcesso, idAdministradorJudicial, lastChangeBy);
        }

        public void removerAdministradorJudicialDoProcesso(string idProcesso, string idAdministradorJudicial, string lastChangeBy)
        {
            d25AdministradorJudicial cr = new d25AdministradorJudicial();
            cr.removerAdministradorJudicialDoProcesso(idProcesso, idAdministradorJudicial, lastChangeBy);
        }
    }
}