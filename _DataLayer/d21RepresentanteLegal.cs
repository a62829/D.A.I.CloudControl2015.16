using System;
using System.Data;
using System.Data.SqlClient;

namespace _DataLayer
{
    public class d21RepresentanteLegal : DBcon 
    {

        public d21RepresentanteLegal() { }

        public bool criarRepresentanteLegal(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
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
            cmd.CommandText = "INSERT INTO dbo.representantelegal VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable listarRepresentanteLegal()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[representanteLegal];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getListaRepresentanteLegalNoInsolventeNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT representanteLegal.id, representanteLegal.nome, representanteLegal.morada, representanteLegal.codPostal, representanteLegal.localidade, representanteLegal.email, representanteLegal.telefone, representanteLegal.telemovel, representanteLegal.fax, representanteLegal.cc, representanteLegal.iban, representanteLegal.nif, representanteLegal.lastChangeBy , processo.id FROM representanteLegal Right Join insolventeNoProcesso ON representanteLegal.id = insolventeNoProcesso.idRepresentanteLegal Right Join processo ON  processo.id = insolventeNoProcesso.idProcesso WHERE processo.id = @id ORDER BY representanteLegal.id; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getListaRepresentanteLegalNocredorNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT representanteLegal.id, representanteLegal.nome, representanteLegal.morada, representanteLegal.codPostal, representanteLegal.localidade, representanteLegal.email, representanteLegal.telefone, representanteLegal.telemovel, representanteLegal.fax, representanteLegal.cc, representanteLegal.iban, representanteLegal.nif, representanteLegal.lastChangeBy , processo.id FROM representanteLegal Right Join credorNoProcesso ON representanteLegal.id = credorNoProcesso.idRepresentanteLegal Right Join processo ON  processo.id = credorNoProcesso.idProcesso WHERE processo.id = @id ORDER BY representanteLegal.id; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void editarRepresentanteLegal(string nome, string morada, string codPostal, string localidade, 
            string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, 
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
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@iban", iban);
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.representantelegal SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getRepresentanteLegal(string id)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerRepresentanteLegal (string id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.representantelegal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaRepresentanteLegalForaDoCredorNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM representanteLegal WHERE NOT EXISTS(Select * FROM credorNoProcesso WHERE idRepresentanteLegal = representanteLegal.id AND idProcesso = @id)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getListaRepresentanteLegalForaDoInsolventeNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM representanteLegal WHERE NOT EXISTS(Select * FROM insolventeNoProcesso WHERE idRepresentanteLegal = representanteLegal.id AND idProcesso = @id)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void adicionarRepresentanteLegalAoInsolventeNoProcesso(string idProcesso, string idRepresentanteLegal, string lastChangeBy, string idInsolvente)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idRepresentanteLegal", idRepresentanteLegal);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.Parameters.AddWithValue("@idInsolvente", idInsolvente);
            cmd.CommandText = "UPDATE dbo.insolventeNoProcesso SET idRepresentanteLegal = @idRepresentanteLegal WHERE idProcesso = @idProcesso AND idInsolvente = @idInsolvente;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void adicionarRepresentanteLegalAoCredorNoProcesso(string idProcesso, string idRepresentanteLegal, string lastChangeBy, string idCredor)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idRepresentanteLegal", idRepresentanteLegal);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.Parameters.AddWithValue("@idCredor", idCredor);
            cmd.CommandText = "UPDATE dbo.credorNoProcesso SET idRepresentanteLegal = @idRepresentanteLegal WHERE idProcesso = @idProcesso AND idCredor = @idCredor;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void removerRepresentanteLegalDoCredorNoProcesso(string idProcesso, string idCredor, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idCredor", idCredor);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.credorNoProcesso SET idRepresentanteLegal = null WHERE idProcesso = @idProcesso AND idCredor = @idCredor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
                        

        }

        public void removerRepresentanteLegalDoInsolventeNoProcesso(string idProcesso, string idInsolvente, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idInsolvente", idInsolvente);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.insolventeNoProcesso SET idRepresentanteLegal = null WHERE idProcesso = @idProcesso AND idInsolvente = @idInsolvente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }
}