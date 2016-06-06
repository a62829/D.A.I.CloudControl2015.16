using System;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
{
    public class d41Insolvente : DBcon
    {
        public d41Insolvente() { }

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
            cmd.CommandText = "INSERT INTO dbo.insolvente VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable getListaInsolvente()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT id, nome FROM [dbo].[insolvente];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;


        }


        public void setInsolvente(string nome, string morada, string codPostal, string localidade, string email,
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
            cmd.CommandText = "UPDATE dbo.insolvente SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public d41InsolventeDto getInsolvente(string id)
        {
            d41InsolventeDto idto = new d41InsolventeDto();
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.juiz WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            idto.nome = Convert.ToString(dataTable.Rows[0]["nome"]);
            idto.morada = (Convert.ToString(dataTable.Rows[0]["morada"]));
            idto.codPostal = (Convert.ToString(dataTable.Rows[0]["codPostal"]));
            idto.localidade = (Convert.ToString(dataTable.Rows[0]["localidade"]));
            idto.email = (Convert.ToString(dataTable.Rows[0]["email"]));
            idto.telefone = (Convert.ToString(dataTable.Rows[0]["telefone"]));
            idto.telemovel = (Convert.ToString(dataTable.Rows[0]["telemovel"]));
            idto.fax = (Convert.ToString(dataTable.Rows[0]["fax"]));
            idto.cc = (Convert.ToString(dataTable.Rows[0]["cc"]));
            idto.iban = (Convert.ToString(dataTable.Rows[0]["iban"]));
            idto.nif = (Convert.ToString(dataTable.Rows[0]["nif"]));
            idto.lastChangeBy = (Convert.ToString(dataTable.Rows[0]["lastChangeBy"]));
            return idto;
        }

        public void removerInsolvente(string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.insolvente WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}