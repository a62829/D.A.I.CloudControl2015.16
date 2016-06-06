using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace _BusinessLayer
{
    class d85ProcessoDto
    {
        public string idProcesso { get; set; }
        public string idLegal { get; set; }
        public string idEstado { get; set; }
        public string idTipoProcesso { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataEncerramento { get; set; }
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

        public d85ProcessoDto(DataTable dt, int i)
        {
            this.idProcesso = Convert.ToString(dt.Rows[i]["id"]);
            this.idLegal = Convert.ToString(dt.Rows[i]["idLegal"]);
            this.idEstado = Convert.ToString(dt.Rows[i]["idEstado"]);
            this.idTipoProcesso = Convert.ToString(dt.Rows[i]["idTipoProcesso"]);
            this.dataInicio = Convert.ToDateTime(dt.Rows[i]["dataInicio"]);
            this.dataEncerramento = Convert.ToDateTime(dt.Rows[i]["dataEncerramento"]);
            this.lastChangeBy = Convert.ToString(dt.Rows[i]["lastChangeBy"]);
        }


        public d85ProcessoDto getProcesso(string id)
        {
            d85Processo p = new d85Processo();
            DataTable dt = p.getProcesso(id);
            d85ProcessoDto rldto = new d85ProcessoDto(dt, 0);
            return rldto;
        }

        public void /*criarProcesso*/ guardar(d85ProcessoDto pdto)
        {
            d85Processo rl = new d85Processo();
            rl.guardar(pdto.idLegal, pdto.idEstado, pdto.idTipoProcesso, pdto.dataInicio, pdto.dataEncerramento, pdto.lastChangeBy);
        }
        public Dictionary<String, d21RepresentanteLegalDto> getListaRepresentanteLegal()
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentanteLegal();
            Dictionary<String, d21RepresentanteLegalDto> lista = new Dictionary<String, d21RepresentanteLegalDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto(dt, i);
                lista.Add(Convert.ToString(rldto.id), rldto);
            }
            return lista;
        }


    }
}
