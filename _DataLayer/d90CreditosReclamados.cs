using System.Data;
using System.Data.SqlClient;

namespace _DataLayer
{
    public class d90CreditosReclamados : DBcon
    {
        public bool guardar(string idCredorNoProcesso, string descricao, string valorDivida,
              string valorRecebido, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idCredorNoProcesso", idCredorNoProcesso);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valorDivida", valorDivida);
            cmd.Parameters.AddWithValue("@valorRecebido", valorRecebido);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.reclamacaoCredito VALUES (@idCredorNoProcesso, @descricao, @valorDivida, @valorRecebido, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataTable getListaCreditosReclamados(string idCredorNoProcesso)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@idCredorNoProcesso", idCredorNoProcesso);
            cmd.CommandText = "SELECT * FROM [dbo].[reclamacaoCredito] WHERE idCredorNoProcesso = @idCredorNoProcesso;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setCreditoReclamado(string idCreditoReclamado, string descricao, string valorDivida,
            string valorRecebido, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idCreditoReclamado", idCreditoReclamado);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valorDivida", valorDivida);
            cmd.Parameters.AddWithValue("@valorRecebido", valorRecebido);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.reclamacaoCredito SET descricao = @descricao, valorDivida = @valorDivida, valorRecebido = @valorRecebido, lastChangeBy = @lastChangeBy WHERE id = @idCreditoReclamado;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getCreditoReclamado(string idCreditoReclamado)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@idCreditoReclamado", idCreditoReclamado);
            cmd.CommandText = "SELECT * FROM dbo.reclamacaoCredito WHERE id = @idCreditoReclamado";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerCreditoReclamado(string idCredorNoProcesso)
        {
            cmd.Parameters.AddWithValue("@idCredorNoProcesso", idCredorNoProcesso);
            cmd.CommandText = "DELETE FROM dbo.reclamacaoCredito WHERE idCredorNoProcesso = @idCredorNoProcesso";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
