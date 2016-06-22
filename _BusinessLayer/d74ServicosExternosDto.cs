using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace _BusinessLayer
{
    public class d74ServicosExternosDto
    {

        public string idPrestacaoServico { get; set; }
        public string idPrestadorServicoNoProcesso { get; set; }
        public string descricao { get; set; }
        public string valorPagar { get; set; }
        public string valorPago { get; set; }
        public string lastChangeBy { get; set; }


        public d74ServicosExternosDto() { }

        public d74ServicosExternosDto(DataTable dt, int i)
        {
            this.idPrestacaoServico = Convert.ToString(dt.Rows[i]["id"]);
            this.idPrestadorServicoNoProcesso = Convert.ToString(dt.Rows[i]["idPrestadorServicoNoProcesso"]);
            this.descricao = Convert.ToString(dt.Rows[i]["descricao"]);
            this.valorPagar = Convert.ToString(dt.Rows[i]["valorPagar"]);
            this.valorPago = Convert.ToString(dt.Rows[i]["valorPago"]);
            this.lastChangeBy = Convert.ToString(dt.Rows[i]["lastChangeBy"]);
        }

        public d74ServicosExternosDto(string idPrestacaoServico, string descricao, string valorPagar,
            string valorPago, string lastChangeBy)
        {
            this.idPrestacaoServico = idPrestacaoServico;
            this.descricao = descricao;
            this.valorPagar = valorPagar;
            this.valorPago = valorPago;
            this.lastChangeBy = lastChangeBy;
        }

        public d74ServicosExternosDto(string idPrestacaoServico, string idPrestadorServicoNoProcesso, string descricao, string valorPagar,
    string valorPago, string lastChangeBy)
        {
            this.idPrestacaoServico = idPrestacaoServico;
            this.idPrestadorServicoNoProcesso = idPrestadorServicoNoProcesso;
            this.descricao = descricao;
            this.valorPagar = valorPagar;
            this.valorPago = valorPago;
            this.lastChangeBy = lastChangeBy;
        }

        public d74ServicosExternosDto getPrestacaoServico(string idPrestacaoServico)
        {
            d74ServicosExternos ps = new d74ServicosExternos();
            DataTable dt = ps.getPrestacaoServico(idPrestacaoServico);
            d74ServicosExternosDto psdto = new d74ServicosExternosDto(dt, 0);
            return psdto;
        }

        public string getIdPrestadorServicoNoProcesso(string idProcesso, string idCredor)
        {
            d49PrestadorServicoDto idto = new d49PrestadorServicoDto();
            string id = idto.getIdPrestadorServicoNoProcesso(idProcesso, idCredor);
            return id;
        }

        public void setPrestacaoServico(d74ServicosExternosDto sedto)
        {
            d74ServicosExternos b = new d74ServicosExternos();
            b.setPrestacaoServico(sedto.idPrestacaoServico, sedto.descricao, sedto.valorPagar, sedto.valorPago, sedto.lastChangeBy);
        }

        public void guardar(d74ServicosExternosDto sedto)
        {
            d74ServicosExternos b = new d74ServicosExternos();
            b.guardar(sedto.idPrestadorServicoNoProcesso, sedto.descricao, sedto.valorPagar, sedto.valorPago, sedto.lastChangeBy);
        }

        public Dictionary<String, d74ServicosExternosDto> getListaPrestacoesServicos(string idPrestadorServicoNoProcesso)
        {
            d74ServicosExternos se = new d74ServicosExternos();
            DataTable dt = se.getListaPrestacoesServicos(idPrestadorServicoNoProcesso);
            Dictionary<String, d74ServicosExternosDto> lista = new Dictionary<String, d74ServicosExternosDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d74ServicosExternosDto sedto = new d74ServicosExternosDto(dt, i);
                lista.Add(i.ToString(), sedto);
            }
            return lista;
        }

        public void removerPrestacaoServico(string idPrestacaoServico)
        {
            d74ServicosExternos c = new d74ServicosExternos();
            c.removerPrestacaoServico(idPrestacaoServico);
        }
    }
}