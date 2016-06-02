using System;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
{
    public class d33Juiz : DBcon
    {
        public d33Juiz() { }

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
            cmd.CommandText = "INSERT INTO dbo.juiz VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable getListaJuiz()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT id, nome FROM [dbo].[juiz];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;


        }


        public void setJuiz(string nome, string morada, string codPostal, string localidade, string email,
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
            cmd.CommandText = "UPDATE dbo.juiz SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public d33JuizDto getJuiz(string id)
        {
            d33JuizDto jdto = new d33JuizDto();
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
            jdto.nome = Convert.ToString(dataTable.Rows[0]["nome"]);
            jdto.morada = (Convert.ToString(dataTable.Rows[0]["morada"]));
            jdto.codPostal = (Convert.ToString(dataTable.Rows[0]["codPostal"]));
            jdto.localidade = (Convert.ToString(dataTable.Rows[0]["localidade"]));
            jdto.email = (Convert.ToString(dataTable.Rows[0]["email"]));
            jdto.telefone = (Convert.ToString(dataTable.Rows[0]["telefone"]));
            jdto.telemovel = (Convert.ToString(dataTable.Rows[0]["telemovel"]));
            jdto.fax = (Convert.ToString(dataTable.Rows[0]["fax"]));
            jdto.cc = (Convert.ToString(dataTable.Rows[0]["cc"]));
            jdto.iban = (Convert.ToString(dataTable.Rows[0]["iban"]));
            jdto.nif = (Convert.ToString(dataTable.Rows[0]["nif"]));
            jdto.lastChangeBy = (Convert.ToString(dataTable.Rows[0]["lastChangeBy"]));
            return jdto;
        }

        public void removerJuiz(string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.juiz WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}