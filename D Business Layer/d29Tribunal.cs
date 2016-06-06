using System;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
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
            cmd.CommandText = "SELECT id, nome FROM [dbo].[tribunal];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;


        }


        public void setTribunal(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string iban, string nif, string lastChangeBy, string id)
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
            cmd.CommandText = "UPDATE dbo.tribunal SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, iban = @iban, nif = @nif WHERE id = @id );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public d29TribunalDto getTribunal(string id)
        {
            d29TribunalDto tdto = new d29TribunalDto();
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
            tdto.nome = Convert.ToString(dataTable.Rows[0]["nome"]);
            tdto.morada = (Convert.ToString(dataTable.Rows[0]["morada"]));
            tdto.codPostal = (Convert.ToString(dataTable.Rows[0]["codPostal"]));
            tdto.localidade = (Convert.ToString(dataTable.Rows[0]["localidade"]));
            tdto.email = (Convert.ToString(dataTable.Rows[0]["email"]));
            tdto.telefone = (Convert.ToString(dataTable.Rows[0]["telefone"]));
            tdto.telemovel = (Convert.ToString(dataTable.Rows[0]["telemovel"]));
            tdto.fax = (Convert.ToString(dataTable.Rows[0]["fax"]));
            tdto.iban = (Convert.ToString(dataTable.Rows[0]["iban"]));
            tdto.nif = (Convert.ToString(dataTable.Rows[0]["nif"]));
            tdto.lastChangeBy = (Convert.ToString(dataTable.Rows[0]["lastChangeBy"]));
            return tdto;
        }

        public void removerTribunal(string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.tribunal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}