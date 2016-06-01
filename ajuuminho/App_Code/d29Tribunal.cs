using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
{
    public class d29Tribunal : Entidade
    {
        protected string cc;

        public string Cc
        {
            get
            {
                return cc;
            }

            set
            {
                cc = value;
            }
        }

        public d29Tribunal() { }

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
            cmd.CommandText = "INSERT INTO dbo.representantelegal VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



        public DataTable getListaRepresentantesLegais()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT id, nome FROM [dbo].[representanteLegal];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }


        public void SetRepresentanteLegal(string nome, string morada, string codPostal, string localidade, string email,
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
            cmd.CommandText = "UPDATE dbo.representantelegal SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public d21RepresentanteLegalDto getRepresentanteLegal(string id)
        {
            d21RepresentanteLegalDto rldto = new d21RepresentanteLegalDto();
            SqlDataReader reader;

            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            rldto.Nome = Convert.ToString(dataTable.Rows[0]["nome"]);
            rldto.Morada = (Convert.ToString(dataTable.Rows[0]["morada"]));
            rldto.CodPostal = (Convert.ToString(dataTable.Rows[0]["codPostal"]));
            rldto.Localidade = (Convert.ToString(dataTable.Rows[0]["localidade"]));
            rldto.Email = (Convert.ToString(dataTable.Rows[0]["email"]));
            rldto.Telefone = (Convert.ToString(dataTable.Rows[0]["telefone"]));
            rldto.Telemovel = (Convert.ToString(dataTable.Rows[0]["telemovel"]));
            rldto.Fax = (Convert.ToString(dataTable.Rows[0]["fax"]));
            rldto.Cc = (Convert.ToString(dataTable.Rows[0]["cc"]));
            rldto.Iban = (Convert.ToString(dataTable.Rows[0]["iban"]));
            rldto.Nif = (Convert.ToString(dataTable.Rows[0]["nif"]));
            rldto.LastChangeBy = (Convert.ToString(dataTable.Rows[0]["lastChangeBy"]));
            return rldto;
        }

        public void removeRepresentanteLegal(string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.representantelegal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string getID(string cc)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.CommandText = "SELECT id FROM dbo.representantelegal WHERE cc = @cc";
            cmd.CommandType = CommandType.Text;
            string id = cmd.ExecuteNonQuery().ToString();

            con.Close();


            return id;

        }

        public bool ccUnique(string cc, string id)
        {
            SqlDataReader reader;
            SqlDataReader reader2;
            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE cc = @cc";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            if (dt.Rows.Count == 1)
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE cc = @cc AND id = @id";
                cmd.CommandType = CommandType.Text;
                reader2 = cmd.ExecuteReader();
                dt.Load(reader2);
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}