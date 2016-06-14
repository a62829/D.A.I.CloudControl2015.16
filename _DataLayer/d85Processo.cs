using System;
using System.Data;
using System.Data.SqlClient;

namespace _DataLayer
{
    public class d85Processo : DBcon
    {
        public d85Processo()
        {

        }

        public bool /*criarProcesso*/ guardar(string idLegal, string idEstado, string idTipoProcesso, string dataInicio, string dataEncerramento, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idLegal", idLegal);
            cmd.Parameters.AddWithValue("@idEstado", idEstado);
            cmd.Parameters.AddWithValue("@idTipoProcesso", idTipoProcesso);
            cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
            cmd.Parameters.AddWithValue("@dataEncerramento", null);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.processo VALUES (@idLegal, @idEstado, @idTipoProcesso, @dataInicio, @dataEncerramento, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable getListaProcesso()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[processo];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getProcesso(string idProcesso)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", idProcesso);
            cmd.CommandText = "SELECT processo.id, processo.idLegal, estado.nome AS nome2, tipoProcesso.nome, processo.dataInicio, processo.dataEncerramento, processo.lastChangeBy FROM processo Right Join estado ON estado.id = processo.idEstado Right Join tipoProcesso ON tipoProcesso.id = processo.idTipoProcesso WHERE processo.id = @id ORDER BY processo.id; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void encerrarProcesso(string idProcesso)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", idProcesso);
            cmd.Parameters.AddWithValue("@dataEncerramento", "NOW()");
            cmd.CommandText = "UPDATE dbo.processo SET dataEncerramento = @dataEncerramento WHERE id = @idProcesso );";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void setProcesso (string idLegal, string idEstado, string idTipoProcesso, string dataInicio, string dataEncerramento, string lastChangeBy, string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@idLegal", idLegal);
            cmd.Parameters.AddWithValue("@idEstado", idEstado);
            cmd.Parameters.AddWithValue("@idTipoProcesso", idTipoProcesso);
            cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
            cmd.Parameters.AddWithValue("@dataEncerramento", dataEncerramento);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.processo SET idLegal = @idLegal, idEstado = @idEstado, idTipoProcesso = @idTipoProcesso, dataInicio = @dataInicio, dataEncerramento = @dataEncerramento, lastChangeBy = @lastChangeBy WHERE id = @id;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
