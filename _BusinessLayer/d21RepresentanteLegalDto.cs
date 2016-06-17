﻿using System.Data;
using _DataLayer;
using System;
using System.Collections.Generic;

namespace _BusinessLayer
{
    [Serializable]
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

        public d21RepresentanteLegalDto(string id, string nome, string morada, string codPostal, string localidade, string email,
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

        public d21RepresentanteLegalDto(DataTable dt, int i)
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

        public d21RepresentanteLegalDto getRepresentanteLegal(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getRepresentanteLegal(id);
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, 0);
            return rldto;
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

        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegal()
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegal();
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(i.ToString(), rldto);
            }
            return lista;
        }

        public void removerRepresentanteLegal(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            rl.removerRepresentanteLegal(id);
        }

        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegalNoCredorNoProcesso(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegalNocredorNoProcesso(id);
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(i.ToString(), rldto);
            }
            return lista;
        }

        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegalNoInsolventeNoProcesso(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegalNoInsolventeNoProcesso(id);
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(i.ToString(), rldto);
            }
            return lista;
        }

        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegalForaDoCredorNoProcesso(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegalForaDoCredorNoProcesso(id);
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(i.ToString(), rldto);
            }
            return lista;
        }

        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegalForaDoInsolventeNoProcesso(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegalForaDoInsolventeNoProcesso(id);
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(i.ToString(), rldto);
            }
            return lista;
        }

        public void adicionarRepresentanteLegalAoInsolventeNoProcesso(string idProcesso, string idRepresentanteLegal, string lastChangeBy, string idInsolvente)
        {
            d21RepresentanteLegal i = new d21RepresentanteLegal();
            i.adicionarRepresentanteLegalAoInsolventeNoProcesso(idProcesso, idRepresentanteLegal, lastChangeBy, idInsolvente);
        }

        public void adicionarRepresentanteLegalAoCredorNoProcesso(string idProcesso, string idRepresentanteLegal, string lastChangeBy, string idCredor)
        {
            d21RepresentanteLegal i = new d21RepresentanteLegal();
            i.adicionarRepresentanteLegalAoCredorNoProcesso(idProcesso, idRepresentanteLegal, lastChangeBy, idCredor);
        }

        public void removerRepresentanteLegalDoCredorNoProcesso(string idProcesso, string idTribunal, string lastChangeBy)
        {
            d21RepresentanteLegal cr = new d21RepresentanteLegal();
            cr.removerRepresentanteLegalDoCredorNoProcesso(idProcesso, idTribunal, lastChangeBy);
        }

        public void removerRepresentanteLegalDoInsolventeNoProcesso(string idProcesso, string idTribunal, string lastChangeBy)
        {
            d21RepresentanteLegal cr = new d21RepresentanteLegal();
            cr.removerRepresentanteLegalDoInsolventeNoProcesso(idProcesso, idTribunal, lastChangeBy);
        }
    }
}