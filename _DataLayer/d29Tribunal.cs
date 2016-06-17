using System;
using System.Data;
using System.Data.SqlClient;

namespace _DataLayer
{
    public class d29Tribunal : DBcon
    {

        public d29Tribunal() { }

        public bool guardar(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string iban, string nif, string lastChangeBy)
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
            cmd.Parameters.AddWithValue("@iban", iban);
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.tribunal VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable getListaTribunal()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[tribunal];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getListaTribunalNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT tribunal.id, tribunal.nome, tribunal.morada, tribunal.codPostal, tribunal.localidade, tribunal.email, tribunal.telefone, tribunal.telemovel, tribunal.fax, tribunal.iban, tribunal.nif, tribunal.lastChangeBy FROM tribunal Right Join tribunalNoProcesso ON tribunalNoProcesso.idtribunal = tribunal.id WHERE tribunalNoProcesso.idProcesso = @id ORDER BY tribunal.id; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setTribunal(string nome, string morada, string codPostal, string localidade, 
            string email, string telefone, string telemovel, string fax, string iban, string nif, 
            string lastChangeBy, string id)
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
            cmd.Parameters.AddWithValue("@iban", iban);
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.tribunal SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, iban = @iban, nif = @nif WHERE id = @id;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getTribunal(string id)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.tribunal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerTribunal(string id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.tribunal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaTribunalForaDoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM tribunal WHERE NOT EXISTS (SELECT * FROM tribunalNoProcesso WHERE idTribunal = tribunal.id AND idProcesso = @id)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void adicionarTribunalAoProcesso(string idProcesso, string idTribunal, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idTribunal", idTribunal);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.tribunalNoProcesso VALUES (@idProcesso, @idTribunal, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}