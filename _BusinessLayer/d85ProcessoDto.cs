using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace _BusinessLayer
{
    [Serializable]
    public class d85ProcessoDto
    {
        public string idProcesso { get; set; }
        public string idLegal { get; set; }
        public string idEstado { get; set; }
        public string idTipoProcesso { get; set; }
        public string dataInicio { get; set; }
        public string dataEncerramento { get; set; }
        public string lastChangeBy { get; set; }
        public Dictionary<string, d21RepresentanteLegalDto> listaRlDto { get; set; }
        public Dictionary<string, d25AdministradorJudicialDto> listaAjDto { get; set; }
        public Dictionary<string, d29TribunalDto> listaTDto { get; set; }
        public Dictionary<string, d33JuizDto> listaJDto { get; set; }
        public Dictionary<string, d37CredorDto> listaCrDto { get; set; }
        public Dictionary<string, d41InsolventeDto> listaIDto { get; set; }
        public Dictionary<string, d45ContabilistaDto> listaCDto { get; set; }
        public Dictionary<string, d49PrestadorServicoDto> listaPsDto { get; set; }
        public Dictionary<string, d53OutraEntidadeDto> listaOeDto { get; set; }

        public d85ProcessoDto () { }

        public d85ProcessoDto(DataTable processoBase, int i)
        {
            this.idProcesso = Convert.ToString(processoBase.Rows[i]["id"]);
            this.idLegal = Convert.ToString(processoBase.Rows[i]["idLegal"]);
            this.idEstado = Convert.ToString(processoBase.Rows[i]["idEstado"]);
            this.idTipoProcesso = Convert.ToString(processoBase.Rows[i]["idTipoProcesso"]);
            this.dataInicio = Convert.ToString(processoBase.Rows[i]["dataInicio"]);
            this.dataEncerramento = Convert.ToString(processoBase.Rows[i]["dataEncerramento"]);
            this.lastChangeBy = Convert.ToString(processoBase.Rows[i]["lastChangeBy"]);
        }

        public d85ProcessoDto(DataTable processoBase)
        {
            this.idProcesso = Convert.ToString(processoBase.Rows[0]["id"]);
            this.idLegal = Convert.ToString(processoBase.Rows[0]["idLegal"]);
            this.idEstado = Convert.ToString(processoBase.Rows[0]["nome2"]);
            this.idTipoProcesso = Convert.ToString(processoBase.Rows[0]["nome"]);
            this.dataInicio = Convert.ToString(processoBase.Rows[0]["dataInicio"]);
            this.dataEncerramento = Convert.ToString(processoBase.Rows[0]["dataEncerramento"]);
            this.lastChangeBy = Convert.ToString(processoBase.Rows[0]["lastChangeBy"]);
        }

        public d85ProcessoDto(string idProcesso, string idLegal, string idEstado, string idTipoProcesso, string dataInicio, string dataEncerramento, string lastChangeBy)
        {
            this.idProcesso = idProcesso;
            this.idLegal = idLegal;
            this.idEstado = idEstado;
            this.idTipoProcesso = idTipoProcesso;
            this.dataInicio = dataInicio;
            this.dataEncerramento = dataEncerramento;
            this.lastChangeBy = lastChangeBy;
        }


        public d85ProcessoDto getProcesso(string id)
        {
            d85Processo p = new d85Processo();
            DataTable dt = p.getProcesso(id);
            d85ProcessoDto pdto = new d85ProcessoDto(dt);
            return pdto;
        }

        public d85ProcessoDto getProcessoCompleto(string id)
        {
            d85Processo p = new d85Processo();
            DataTable dt = p.getProcesso(id);
            d85ProcessoDto pdto = new d85ProcessoDto(dt, 0);
            pdto.listaRlDto = pdto.getListaRepresentanteLegalNoProcesso(id);
            pdto.listaAjDto = pdto.getListaAdministradorJudicialNoProcesso(id);
            pdto.listaTDto = pdto.getListaTribunalNoProcesso(id);
            pdto.listaJDto = pdto.getListaJuizNoProcesso(id);
            pdto.listaCrDto = pdto.getListaCredorNoProcesso(id);
            pdto.listaIDto = pdto.getListaInsolventeNoProcesso(id);
            pdto.listaCDto = pdto.getListaContabilistaNoProcesso(id);
            pdto.listaPsDto = pdto.getListaPrestadorServicoNoProcesso(id);
            pdto.listaOeDto = pdto.getListaOutraEntidadeNoProcesso(id);
            return pdto;
        }

        public void setProcesso(d85ProcessoDto pdto)
        {
            d85Processo p = new d85Processo();
            p.setProcesso( pdto.idLegal, pdto.idEstado, pdto.idTipoProcesso, pdto.dataInicio, pdto.dataEncerramento, pdto.lastChangeBy, pdto.idProcesso);
        }

        public void /*criarProcesso*/ guardar(d85ProcessoDto pdto)
        {
            d85Processo rl = new d85Processo();
            rl.guardar(pdto.idLegal, pdto.idEstado, pdto.idTipoProcesso, pdto.dataInicio, pdto.dataEncerramento, pdto.lastChangeBy);
        }
        public Dictionary<String, d85ProcessoDto> getListaProcesso()
        {
            d85Processo rl = new d85Processo();
            DataTable dt = rl.getListaProcesso();
            Dictionary<String, d85ProcessoDto> lista = new Dictionary<String, d85ProcessoDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d85ProcessoDto rldto = new d85ProcessoDto(dt, i);
                lista.Add(Convert.ToString(rldto.idProcesso), rldto);
            }
            return lista;
        }

        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegalNoProcesso(string id)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegalNoProcesso(id);
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(Convert.ToString(rldto.id), rldto);
            }
            return lista;
        }

        public Dictionary<String, d25AdministradorJudicialDto> getListaAdministradorJudicialNoProcesso(string id)
        {
            d25AdministradorJudicial aj = new d25AdministradorJudicial();
            DataTable dt = aj.getListaAdministradorJudicialNoProcesso(id);
            Dictionary<String, d25AdministradorJudicialDto> lista = new Dictionary<String, d25AdministradorJudicialDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto(dt, i);
                lista.Add(Convert.ToString(ajdto.id), ajdto);
            }
            return lista;
        }

        public Dictionary<String, d29TribunalDto> getListaTribunalNoProcesso(string id)
        {
            d29Tribunal t = new d29Tribunal();
            DataTable dt = t.getListaTribunalNoProcesso(id);
            Dictionary<String, d29TribunalDto> lista = new Dictionary<String, d29TribunalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d29TribunalDto tdto = new d29TribunalDto(dt, i);
                lista.Add(Convert.ToString(tdto.id), tdto);
            }
            return lista;
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

        public Dictionary<String, d37CredorDto> getListaCredorNoProcesso(string id)
        {
            d37Credor c = new d37Credor();
            DataTable dt = c.getListaCredorNoProcesso(id);
            Dictionary<String, d37CredorDto> lista = new Dictionary<String, d37CredorDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d37CredorDto cdto = new d37CredorDto(dt, i);
                lista.Add(Convert.ToString(cdto.id), cdto);
            }
            return lista;
        }

        public Dictionary<String, d41InsolventeDto> getListaInsolventeNoProcesso(string id)
        {
            d41Insolvente ins = new d41Insolvente();
            DataTable dt = ins.getListaInsolventeNoProcesso(id);
            Dictionary<String, d41InsolventeDto> lista = new Dictionary<String, d41InsolventeDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d41InsolventeDto idto = new d41InsolventeDto(dt, i);
                lista.Add(Convert.ToString(idto.id), idto);
            }
            return lista;
        }

        public Dictionary<String, d45ContabilistaDto> getListaContabilistaNoProcesso(string id)
        {
            d45Contabilista c = new d45Contabilista();
            DataTable dt = c.getListaContabilistaNoProcesso(id);
            Dictionary<String, d45ContabilistaDto> lista = new Dictionary<String, d45ContabilistaDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d45ContabilistaDto cdto = new d45ContabilistaDto(dt, i);
                lista.Add(Convert.ToString(cdto.id), cdto);
            }
            return lista;
        }

        public Dictionary<String, d49PrestadorServicoDto> getListaPrestadorServicoNoProcesso(string id)
        {
            d49PrestadorServico ps = new d49PrestadorServico();
            DataTable dt = ps.getListaPrestadorServicoNoProcesso(id);
            Dictionary<String, d49PrestadorServicoDto> lista = new Dictionary<String, d49PrestadorServicoDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d49PrestadorServicoDto psdto = new d49PrestadorServicoDto(dt, i);
                lista.Add(Convert.ToString(psdto.id), psdto);
            }
            return lista;
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
    }
}
