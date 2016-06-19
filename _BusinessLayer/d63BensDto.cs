using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;
using System.Data;

namespace _BusinessLayer
{
    public class d63BensDto
    {

        public string idBens { get; set; }
        public string idInsolventeNoProcesso { get; set; }
        public string TipoAtivo { get; set; }
        public string descricao { get; set; }
        public string valorAquisicao { get; set; }
        public string valorMercado { get; set; }
        public string valorLiquidacao { get; set; }
        public string lastChangeBy { get; set; }


        public d63BensDto() { }

        public d63BensDto(DataTable dt, int i)
        {
            this.idBens = Convert.ToString(dt.Rows[i]["id"]);
            this.idInsolventeNoProcesso = Convert.ToString(dt.Rows[i]["idInsolventeNoProcesso"]);
            this.TipoAtivo = Convert.ToString(dt.Rows[i]["nome"]);
            this.descricao = Convert.ToString(dt.Rows[i]["descricao"]);
            this.valorAquisicao = Convert.ToString(dt.Rows[i]["valorAquisicao"]);
            this.valorMercado = Convert.ToString(dt.Rows[i]["valorMercado"]);
            this.valorLiquidacao = Convert.ToString(dt.Rows[i]["valorLiquidacao"]);
            this.lastChangeBy = Convert.ToString(dt.Rows[i]["lastChangeBy"]);
        }

        public d63BensDto(string idBem, string TipoAtivo, string descricao, string valorAquisicao,
            string valorMercado, string valorLiquidacao, string lastChangeBy)
        {
            this.idBens = idBem;
            this.TipoAtivo = TipoAtivo;
            this.descricao = descricao;
            this.valorAquisicao = valorAquisicao;
            this.valorMercado = valorMercado;
            this.valorLiquidacao = valorLiquidacao;
            this.lastChangeBy = lastChangeBy;
        }

        public d63BensDto(string idBem, string idInsolventeNoProcesso, string idTipoAtivo, string descricao, string valorAquisicao,
    string valorMercado, string valorLiquidacao, string lastChangeBy)
        {
            this.idBens = idBem;
            this.idInsolventeNoProcesso = idInsolventeNoProcesso;
            this.TipoAtivo = TipoAtivo;
            this.descricao = descricao;
            this.valorAquisicao = valorAquisicao;
            this.valorMercado = valorMercado;
            this.valorLiquidacao = valorLiquidacao;
            this.lastChangeBy = lastChangeBy;
        }

        public d63BensDto getBem(string idBem)
        {
            d63Bens rl = new d63Bens();
            DataTable dt = rl.getBem(idBem);
            d63BensDto rldto = new d63BensDto(dt, 0);
            return rldto;
        }

        public string getIdInsolventeNoProcesso(string idProcesso, string idInsolvente)
        {
            d63Bens rl = new d63Bens();
            d41InsolventeDto idto = new d41InsolventeDto();
            string id = idto.getIdInsolventeNoProcesso(idProcesso, idInsolvente);
            return id;
        }

        public void setBem(d63BensDto bdto)
        {
            d63Bens b = new d63Bens();
            b.setBem(bdto.idBens, bdto.TipoAtivo, bdto.descricao, bdto.valorAquisicao, bdto.valorMercado, bdto.valorLiquidacao, bdto.lastChangeBy);
        }

        public void guardar(d63BensDto bdto)
        {
            d63Bens b = new d63Bens();
            b.guardar(bdto.idBens, bdto.idInsolventeNoProcesso, bdto.TipoAtivo, bdto.descricao, bdto.valorAquisicao, bdto.valorMercado, bdto.valorLiquidacao, bdto.lastChangeBy);
        }

        public Dictionary<String, d63BensDto> getListaBens(string idInsolventeNoProcesso)
        {
            d63Bens b = new d63Bens();
            DataTable dt = b.getListaBens(idInsolventeNoProcesso);
            Dictionary<String, d63BensDto> lista = new Dictionary<String, d63BensDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d63BensDto jdto = new d63BensDto(dt, i);
                lista.Add(i.ToString(), jdto);
            }
            return lista;
        }
    }
}