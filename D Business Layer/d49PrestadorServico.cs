using System;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
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
            cmd.CommandText = "SELECT id, nome FROM [dbo].[prestadorServico];";
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

        public d49PrestadorServicoDto getPrestadorServico(string id)
        {
            d49PrestadorServicoDto psdto = new d49PrestadorServicoDto();
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
            psdto.nome = Convert.ToString(dataTable.Rows[0]["nome"]);
            psdto.morada = (Convert.ToString(dataTable.Rows[0]["morada"]));
            psdto.codPostal = (Convert.ToString(dataTable.Rows[0]["codPostal"]));
            psdto.localidade = (Convert.ToString(dataTable.Rows[0]["localidade"]));
            psdto.email = (Convert.ToString(dataTable.Rows[0]["email"]));
            psdto.telefone = (Convert.ToString(dataTable.Rows[0]["telefone"]));
            psdto.telemovel = (Convert.ToString(dataTable.Rows[0]["telemovel"]));
            psdto.fax = (Convert.ToString(dataTable.Rows[0]["fax"]));
            psdto.cc = (Convert.ToString(dataTable.Rows[0]["cc"]));
            psdto.iban = (Convert.ToString(dataTable.Rows[0]["iban"]));
            psdto.nif = (Convert.ToString(dataTable.Rows[0]["nif"]));
            psdto.lastChangeBy = (Convert.ToString(dataTable.Rows[0]["lastChangeBy"]));
            return psdto;
        }

        public void removerPrestadorServico(string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.prestadorServico WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}