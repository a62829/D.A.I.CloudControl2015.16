using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;

namespace _BusinessLayer
{
    public class d59EventoDto
    {

        public string idEvento { get; set; }
        public string idProcesso { get; set; }
        public string idTipoEvento { get; set; }
        public string descricao { get; set; }
        public string dataEvento { get; set; }
        public string lastChangeBy { get; set; }

        public d59EventoDto() { }

        public d59EventoDto(DataTable dt, int i)
        {
            this.idEvento = Convert.ToString(dt.Rows[i]["id"]);
            this.idProcesso = Convert.ToString(dt.Rows[i]["idProcesso"]);
            this.idTipoEvento = Convert.ToString(dt.Rows[i]["nome"]);
            this.descricao = Convert.ToString(dt.Rows[i]["descricao"]);
            this.dataEvento = Convert.ToString(dt.Rows[i]["dataEvento"]);
            this.lastChangeBy = Convert.ToString(dt.Rows[i]["lastChangeBy"]);
        }

        public d59EventoDto(string idEvento, string idProcesso, string idTipoEvento, string descricao, string dataEvento, string lastChangeBy)
        {
            this.idEvento = idEvento;
            this.idProcesso = idProcesso;
            this.idTipoEvento = idTipoEvento;
            this.descricao = descricao;
            this.dataEvento = dataEvento;
            this.lastChangeBy = lastChangeBy;
        }

        public d59EventoDto getEvento(string idEvento)
        {
            d59Evento rl = new d59Evento();
            DataTable dt = rl.getEvento(idEvento);
            d59EventoDto rldto = new d59EventoDto(dt, 0);
            return rldto;
        }

        public void setEvento(d59EventoDto edto)
        {
            d59Evento e = new d59Evento();
            e.setEvento(edto.idEvento, edto.idTipoEvento, edto.descricao, edto.dataEvento, edto.lastChangeBy);

        }

        public void guardar(d59EventoDto edto)
        {
            d59Evento e = new d59Evento();
            e.guardar(edto.idEvento, edto.idProcesso, edto.idTipoEvento, edto.descricao, edto.dataEvento, edto.lastChangeBy);
        }

        public Dictionary<String, d59EventoDto> getListaEventos(string idProcesso)
        {
            d59Evento e = new d59Evento();
            DataTable dt = e.getListaEventos(idProcesso);
            Dictionary<String, d59EventoDto> lista = new Dictionary<String, d59EventoDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d59EventoDto jdto = new d59EventoDto(dt, i);
                lista.Add(i.ToString(), jdto);
            }
            return lista;
        }


    }
}
