using System;
using System.Collections.Generic;
using System.Web;

namespace businessLayer
{
    public class RepresentanteLegalDTO : RepresentanteLegal
    {

        public RepresentanteLegalDTO()
        {

        }

        public RepresentanteLegalDTO(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            this.nome = nome;
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
    }
}