using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;

namespace _BusinessLayer
{
    public class d90CreditosReclamadosDto
    {

        public string idCreditoReclamado { get; set; }
        public string idCredorNoProcesso { get; set; }
        public string descricao { get; set; }
        public string valorDivida { get; set; }
        public string valorRecebido { get; set; }
        public string lastChangeBy { get; set; }


        public d90CreditosReclamadosDto() { }

        public d90CreditosReclamadosDto(DataTable dt, int i)
        {
            this.idCreditoReclamado = Convert.ToString(dt.Rows[i]["id"]);
            this.idCredorNoProcesso = Convert.ToString(dt.Rows[i]["idCredorNoProcesso"]);
            this.descricao = Convert.ToString(dt.Rows[i]["descricao"]);
            this.valorDivida = Convert.ToString(dt.Rows[i]["valorDivida"]);
            this.valorRecebido = Convert.ToString(dt.Rows[i]["valorRecebido"]);
            this.lastChangeBy = Convert.ToString(dt.Rows[i]["lastChangeBy"]);
        }

        public d90CreditosReclamadosDto(string idCreditoReclamado, string descricao, string valorDivida,
            string valorRecebido, string lastChangeBy)
        {
            this.idCreditoReclamado = idCreditoReclamado;
            this.descricao = descricao;
            this.valorDivida = valorDivida;
            this.valorRecebido = valorRecebido;
            this.lastChangeBy = lastChangeBy;
        }

        public d90CreditosReclamadosDto(string idCreditoReclamado, string idCredorNoProcesso, string descricao, string valorDivida,
    string valorRecebido, string lastChangeBy)
        {
            this.idCreditoReclamado = idCreditoReclamado;
            this.idCredorNoProcesso = idCredorNoProcesso;
            this.descricao = descricao;
            this.valorDivida = valorDivida;
            this.valorRecebido = valorRecebido;
            this.lastChangeBy = lastChangeBy;
        }

        public d90CreditosReclamadosDto getCreditoReclamado(string idCreditoReclamado)
        {
            d90CreditosReclamados crcl = new d90CreditosReclamados();
            DataTable dt = crcl.getCreditoReclamado(idCreditoReclamado);
            d90CreditosReclamadosDto crcldto = new d90CreditosReclamadosDto(dt, 0);
            return crcldto;
        }

        public string getIdCredorNoProcesso(string idProcesso, string idCredor)
        {
            d63Bens rl = new d63Bens();
            d37CredorDto idto = new d37CredorDto();
            string id = idto.getIdCredorNoProcesso(idProcesso, idCredor);
            return id;
        }

        public void setCreditoReclamado(d90CreditosReclamadosDto bdto)
        {
            d90CreditosReclamados b = new d90CreditosReclamados();
            b.setCreditoReclamado(bdto.idCreditoReclamado, bdto.descricao, bdto.valorDivida, bdto.valorRecebido, bdto.lastChangeBy);
        }

        public void guardar(d90CreditosReclamadosDto bdto)
        {
            d90CreditosReclamados b = new d90CreditosReclamados();
            b.guardar(bdto.idCreditoReclamado, bdto.idCredorNoProcesso, bdto.descricao, bdto.valorDivida, bdto.valorRecebido, bdto.lastChangeBy);
        }

        public Dictionary<String, d90CreditosReclamadosDto> getListaCreditosReclamados(string idCredorNoProcesso)
        {
            d90CreditosReclamados b = new d90CreditosReclamados();
            DataTable dt = b.getListaCreditosReclamados(idCredorNoProcesso);
            Dictionary<String, d90CreditosReclamadosDto> lista = new Dictionary<String, d90CreditosReclamadosDto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d90CreditosReclamadosDto jdto = new d90CreditosReclamadosDto(dt, i);
                lista.Add(i.ToString(), jdto);
            }
            return lista;
        }
    }
}