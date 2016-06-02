using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace ajuUminho.App_Code
{
    public class d25AdministradorJudicialDto : Entidade
    {
        public string cc { get; set; }

        public d25AdministradorJudicialDto()
        {

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

        public d25AdministradorJudicialDto getAdministradorJudicial(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            return aj.getAdministradorJudicial(id);
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

        public DataTable getListaAdministradorJudicial()
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            return aj.getListaAdministradorJudicial();
        }

        public void removeAdministradorJudicial(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            aj.removerAdministradorJudicial(id);
        }
    }
}