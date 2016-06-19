using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer
{
    public class d63Bens : DBcon
    {


        public void guardar(string idBem, string idInsolventeNoProcesso, string idTipoAtivo, string descricao, string valorAquisicao,
            string valorMercado, string valorLiquidacao, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", idBem);
            cmd.Parameters.AddWithValue("@idInsolventeNoProcesso", idInsolventeNoProcesso);
            cmd.Parameters.AddWithValue("@idTipoAtivo", idTipoAtivo);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valorAquisicao", valorAquisicao);
            cmd.Parameters.AddWithValue("@valorMercado", valorMercado);
            cmd.Parameters.AddWithValue("@valorLiquidacao", valorLiquidacao);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.ativo VALUES (@id, @idInsolventeNoProcesso, @idTipoAtivo, @descricao, @valorAquisicao, @valorMercado, @valorLiquidacao, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaBens(string idInsolventeNoProcesso)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@idInsolventeNoProcesso", idInsolventeNoProcesso);
            cmd.CommandText = "SELECT A.id, idInsolventeNoProcesso, nome, A.descricao, valorAquisicao, valorMercado, valorLiquidacao, A.lastChangeBy FROM dbo.ativo A INNER JOIN dbo.tipoAtivo T ON A.idTipoAtivo = T.id WHERE idInsolventeNoProcesso = @idInsolventeNoProcesso;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        //public DataTable getListaPrestadorServicoNoProcesso(string id)
        //{
        //    SqlDataReader reader;
        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.CommandText = "SELECT prestadorServico.id, prestadorServico.nome, prestadorServico.morada, prestadorServico.codPostal, prestadorServico.localidade, prestadorServico.email, prestadorServico.telefone, prestadorServico.telemovel, prestadorServico.fax, prestadorServico.cc, prestadorServico.iban, prestadorServico.nif, prestadorServico.lastChangeBy , processo.id  FROM prestadorServico Right Join prestadorServicoNoProcesso ON prestadorServico.id = prestadorServicoNoProcesso.idPrestadorServico Right Join processo ON  processo.id = prestadorServicoNoProcesso.idProcesso WHERE processo.id = @id ORDER BY prestadorServico.id; ";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.Connection.Open();
        //    reader = cmd.ExecuteReader();
        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    con.Close();
        //    return dataTable;
        //}

        public void setBem(string idBem, string idTipoAtivo, string descricao, string valorAquisicao,
            string valorMercado, string valorLiquidacao, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idBem", idBem);
            cmd.Parameters.AddWithValue("@idTipoAtivo", idTipoAtivo);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valorAquisicao", valorAquisicao);
            cmd.Parameters.AddWithValue("@valorMercado", valorMercado);
            cmd.Parameters.AddWithValue("@valorLiquidacao", valorLiquidacao);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.ativo SET descricao = @descricao, valorAquisicao = @valorAquisicao, valorMercado = @valorMercado, valorLiquidacao = @valorLiquidacao, lastChangeBy = @lastChangeBy WHERE id = @idBem;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getBem(string idBem)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@idBem", idBem);
            cmd.CommandText = "SELECT A.id, idInsolventeNoProcesso, nome, A.descricao, valorAquisicao, valorMercado, valorLiquidacao, A.lastChangeBy FROM dbo.ativo A INNER JOIN dbo.tipoAtivo T ON A.idTipoAtivo = T.id WHERE A.id = @idBem";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }
        

        public void removerBem(string idInsolventeNoProcesso)
        {
            cmd.Parameters.AddWithValue("@idInsolventeNoProcesso", idInsolventeNoProcesso);
            cmd.CommandText = "DELETE FROM dbo.ativo WHERE idInsolventeNoProcesso = @idInsolventeNoProcesso";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaTipoBem()
        {
            SqlDataReader reader;
            con.Open();
            cmd.CommandText = "SELECT id, nome from dbo.tipoAtivo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }
    }
}
