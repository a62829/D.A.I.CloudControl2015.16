using System.Data;
using System.Data.SqlClient;
namespace _DataLayer
{
    public class d74ServicosExternos : DBcon
    {
        public bool guardar(string idPrestadorServicoNoProcesso, string descricao, string valorPagar,
              string valorPago, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idPrestadorServicoNoProcesso", idPrestadorServicoNoProcesso);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valorPagar", valorPagar);
            cmd.Parameters.AddWithValue("@valorPago", valorPago);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.prestacaoServico VALUES (@idPrestadorServicoNoProcesso, @descricao, @valorPagar, @valorPago, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataTable getListaPrestacoesServicos(string idPrestadorServicoNoProcesso)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@idPrestadorServicoNoProcesso", idPrestadorServicoNoProcesso);
            cmd.CommandText = "SELECT * FROM [dbo].[prestacaoServico] WHERE idPrestadorServicoNoProcesso = @idPrestadorServicoNoProcesso;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setPrestacaoServico(string idPrestacaoServico, string descricao, string valorPagar,
            string valorPago, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idCreditoReclamado", idPrestacaoServico);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valorDivida", valorPagar);
            cmd.Parameters.AddWithValue("@valorRecebido", valorPago);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.prestacaoServico SET descricao = @descricao, valorPagar = @valorPagar, valorPago = @valorPago, lastChangeBy = @lastChangeBy WHERE id = @idPrestacaoServico;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getPrestacaoServico(string idPrestacaoServico)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@idPrestacaoServico", idPrestacaoServico);
            cmd.CommandText = "SELECT * FROM dbo.prestacaoServico WHERE id = @idPrestacaoServico";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerPrestacaoServico(string idPrestacaoServico)
        {
            cmd.Parameters.AddWithValue("@idPrestacaoServico", idPrestacaoServico);
            cmd.CommandText = "DELETE FROM dbo.prestacaoServico WHERE id = @idPrestacaoServico";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}