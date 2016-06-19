using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer
{
    public class d59Evento : DBcon
    {
        
        public void guardar(string idEvento, string idProcesso, string idTipoEvento, string descricao, string dataEvento, string lastChangeBy)
        {
            con.Open();
            //cmd.Parameters.AddWithValue("@id", idEvento);
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idTipoEvento", idTipoEvento);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@dataEvento", DateTime.Parse(dataEvento));
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.evento VALUES (@idProcesso, @idTipoEvento, @descricao, @dataEvento, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaEventos(string idProcesso)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.CommandText = "SELECT E.id, E.idProcesso, nome, E.descricao, E.dataEvento, E.lastChangeBy FROM dbo.evento E INNER JOIN dbo.tipoEvento T ON E.idTipoEvento = T.id WHERE E.idProcesso = @idProcesso";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setEvento(string idEvento, string idTipoEvento, string descricao, string dataEvento, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", idEvento);
            cmd.Parameters.AddWithValue("@idTipoEvento", idTipoEvento);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@dataEvento", DateTime.Parse(dataEvento));
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.evento SET descricao = @descricao, dataEvento = @dataEvento, lastChangeBy = @lastChangeBy WHERE id = @id;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getEvento(string idEvento)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.CommandText = "SELECT E.id, E.idProcesso, nome, E.descricao, E.dataEvento, E.lastChangeBy FROM dbo.evento E INNER JOIN dbo.tipoEvento T ON E.idTipoEvento = T.id WHERE E.id = @idEvento";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerEvento(string idEvento)
        {
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.CommandText = "DELETE FROM dbo.evento WHERE id = @idEvento";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DateTime convert(string s, string format = "yyyy-MM-dd hh:mm:ss", string cultureString = "pt-PT")
        {
            var r = DateTime.ParseExact(
                s: s, format: format, provider: CultureInfo.GetCultureInfo(cultureString));
            return r;
        }

        public DataTable getListaTipoEvento()
        {
            SqlDataReader reader;
            con.Open();
            cmd.CommandText = "SELECT id, nome from dbo.tipoEvento";
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
