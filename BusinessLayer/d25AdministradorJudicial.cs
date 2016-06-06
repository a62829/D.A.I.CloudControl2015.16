using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class d25AdministradorJudicial : DBcon
    {
        public d25AdministradorJudicial() { }

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
            cmd.CommandText = "INSERT INTO dbo.administradorJudicial VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable getListaAdministradorJudicial()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT id, nome FROM [dbo].[administradorJudicial];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;


        }


        public void setAdministradorJudicial(string nome, string morada, string codPostal, string localidade, string email,
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
            cmd.CommandText = "UPDATE dbo.administradorJudicial SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getAdministradorJudicial(string id)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.administradorJudicial WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerAdministradorJudicial(string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.administradorJudicial WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}