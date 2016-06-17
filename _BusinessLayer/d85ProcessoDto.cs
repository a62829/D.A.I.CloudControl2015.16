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
        public Dictionary<string, d21RepresentanteLegalDto> listaRlDtoNoCredorNoProcesso { get; set; }
        public Dictionary<string, d21RepresentanteLegalDto> listaRlDtoNoInsolventeNoProcesso { get; set; }
        public Dictionary<string, d25AdministradorJudicialDto> listaAjDtoNoProcesso { get; set; }
        public Dictionary<string, d29TribunalDto> listaTDtoNoProcesso { get; set; }
        public Dictionary<string, d33JuizDto> listaJDtoNoProcesso { get; set; }
        public Dictionary<string, d37CredorDto> listaCrDtoNoProcesso { get; set; }
        public Dictionary<string, d41InsolventeDto> listaIDtoNoProcesso { get; set; }
        public Dictionary<string, d45ContabilistaDto> listaCDtoNoProcesso { get; set; }
        public Dictionary<string, d49PrestadorServicoDto> listaPsDtoNoProcesso { get; set; }
        public Dictionary<string, d53OutraEntidadeDto> listaOeDtoNoProcesso { get; set; }

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

        public d85ProcessoDto(string idLegal, string idEstado, string idTipoProcesso, string dataInicio, string lastChangeBy)
        {
            this.idLegal = idLegal;
            this.idEstado = idEstado;
            this.idTipoProcesso = idTipoProcesso;
            this.dataInicio = dataInicio;
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
            var x = p.getProcesso(id);
            d85ProcessoDto pdto = new d85ProcessoDto(x);
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            pdto.listaRlDtoNoCredorNoProcesso = rldto.getListaRepresentanteLegalNoCredorNoProcesso(id);
            pdto.listaRlDtoNoInsolventeNoProcesso = rldto.getListaRepresentanteLegalNoInsolventeNoProcesso(id);
            d25AdministradorJudicialDto ajdto = new d25AdministradorJudicialDto();
            pdto.listaAjDtoNoProcesso = ajdto.getListaAdministradorJudicialNoProcesso(id);
            d29TribunalDto tdto = new d29TribunalDto();
            pdto.listaTDtoNoProcesso = tdto.getListaTribunalNoProcesso(id);
            d33JuizDto jdto = new d33JuizDto();
            pdto.listaJDtoNoProcesso = jdto.getListaJuizNoProcesso(id);
            d37CredorDto crdto = new d37CredorDto();
            pdto.listaCrDtoNoProcesso = crdto.getListaCredorNoProcesso(id);
            d41InsolventeDto idto = new d41InsolventeDto();
            pdto.listaIDtoNoProcesso = idto.getListaInsolventeNoProcesso(id);
            d45ContabilistaDto cdto = new d45ContabilistaDto();
            pdto.listaCDtoNoProcesso = cdto.getListaContabilistaNoProcesso(id);
            d49PrestadorServicoDto psdto = new d49PrestadorServicoDto();
            pdto.listaPsDtoNoProcesso = psdto.getListaPrestadorServicoNoProcesso(id);
            d53OutraEntidadeDto oedto = new d53OutraEntidadeDto();
            pdto.listaOeDtoNoProcesso = oedto.getListaOutraEntidadeNoProcesso(id);
            return pdto;
        }

        public void setProcesso(d85ProcessoDto pdto)
        {
            d85Processo p = new d85Processo();
            p.setProcesso( pdto.idLegal, pdto.idEstado, pdto.idTipoProcesso, pdto.dataInicio, pdto.dataEncerramento, pdto.lastChangeBy, pdto.idProcesso);
        }

        public void /*criarProcesso*/ guardar(d85ProcessoDto pdto, string idInsolvente)
        {
            d85Processo rl = new d85Processo();
            rl.guardar(pdto.idLegal, pdto.idEstado, pdto.idTipoProcesso, pdto.dataInicio, pdto.lastChangeBy, idInsolvente);
        }
        public Dictionary<String, d85ProcessoDto> getListaProcesso()
        {
            d85Processo p = new d85Processo();
            DataTable dt = p.getListaProcesso();
            Dictionary<String, d85ProcessoDto> lista = new Dictionary<String, d85ProcessoDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d85ProcessoDto pdto = new d85ProcessoDto(dt, i);
                lista.Add(Convert.ToString(pdto.idProcesso), pdto);
            }
            return lista;
        }

        public Dictionary<String, String> getListaEstado()
        {
            d85Processo rl = new d85Processo();
            DataTable dt = rl.getListaEstados();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["id"]), Convert.ToString(dt.Rows[i]["nome"]));
            }
            return lista;
        }

        public Dictionary<String, String> getListaTipoProcesso()
        {
            d85Processo rl = new d85Processo();
            DataTable dt = rl.getListaTiposProcesso();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["id"]), Convert.ToString(dt.Rows[i]["nome"]));
            }
            return lista;
        }


    }
}
