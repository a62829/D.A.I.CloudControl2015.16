using System;
using System.Data;
using System.Data.SqlClient;

namespace _DataLayer
{
    public class d49PrestadorServico : DBcon
    {
        public d49PrestadorServico() { }

        public bool guardar(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("@codPostal", codPostal);
            cmd.Parameters.AddWithValue("@localidade", localidade);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@telemovel", telemovel);
            cmd.Parameters.AddWithValue("@fax", fax);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@iban", iban);
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.prestadorServico VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataTable getListaPrestadorServico()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[prestadorServico];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getListaPrestadorServicoNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT prestadorServico.id, prestadorServico.nome, prestadorServico.morada, prestadorServico.codPostal, prestadorServico.localidade, prestadorServico.email, prestadorServico.telefone, prestadorServico.telemovel, prestadorServico.fax, prestadorServico.cc, prestadorServico.iban, prestadorServico.nif, prestadorServico.lastChangeBy FROM prestadorServico Right Join prestadorServicoNoProcesso ON prestadorServicoNoProcesso.idprestadorServico = prestadorServico.id WHERE prestadorServicoNoProcesso.idProcesso = @id ORDER BY prestadorServico.id; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setPrestadorServico(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy, string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("@codPostal", codPostal);
            cmd.Parameters.AddWithValue("@localidade", localidade);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@telemovel", telemovel);
            cmd.Parameters.AddWithValue("@fax", fax);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@iban", iban);
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.prestadorServico SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getPrestadorServico(string id)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.prestadorServico WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerPrestadorServico(string id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.prestadorServico WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaPrestadorServicoForaDoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT prestadorServico.id, prestadorServico.nome, prestadorServico.lastChangeBy FROM prestadorServico WHERE NOT EXISTS (SELECT * FROM prestadorServicoNoProcesso WHERE idPrestadorServico = prestadorServico.id AND idProcesso = '1')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }
    }
}