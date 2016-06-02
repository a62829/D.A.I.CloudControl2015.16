using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace businessLayer
{
    public class RepresentanteLegal : Entidade
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

        public RepresentanteLegal() { }

        public RepresentanteLegal(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
         {
             this.nome = nome;
             this.morada = morada;
             this.codPostal = codPostal;
             this.localidade = localidade;
             this.email = email;
             this.telefone = telefone;
             this.telemovel = telemovel;
             this.fax = fax;
             this.cc = cc;
             this.iban = iban;
             this.nif = nif;
             this.lastChangeBy = lastChangeBy;
         } 


        public DataTable getListaRepresentantesLegais()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[representantelegal];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }


        public void SetRepresentanteLegal(RepresentanteLegalDTO rldto)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@nome", rldto.nome);
            cmd.Parameters.AddWithValue("@morada", rldto.morada);
            cmd.Parameters.AddWithValue("@codPostal", rldto.codPostal);
            cmd.Parameters.AddWithValue("@localidade", rldto.localidade);
            cmd.Parameters.AddWithValue("@email", rldto.email);
            cmd.Parameters.AddWithValue("@telefone", rldto.telefone);
            cmd.Parameters.AddWithValue("@telemovel", rldto.telemovel);
            cmd.Parameters.AddWithValue("@fax", rldto.fax);
            cmd.Parameters.AddWithValue("@cc", rldto.cc);
            cmd.Parameters.AddWithValue("@iban", rldto.iban);
            cmd.Parameters.AddWithValue("@nif", rldto.nif);
            cmd.Parameters.AddWithValue("@lastChangeBy", rldto.lastChangeBy);
            cmd.CommandText = "INSERT dbo.representantelegal VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public RepresentanteLegalDTO getRepresentanteLegal (string id)
        {
            RepresentanteLegalDTO rldto = new RepresentanteLegalDTO();
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE id = '" + id + "'";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            rldto.Nome = Convert.ToString(dataTable.Rows[1]["nome"]);
            rldto.morada = (Convert.ToString(dataTable.Rows[1]["morada"]));
            rldto.codPostal = (Convert.ToString(dataTable.Rows[1]["codPostal"]));
            rldto.localidade = (Convert.ToString(dataTable.Rows[1]["localidade"]));
            rldto.email = (Convert.ToString(dataTable.Rows[1]["email"]));
            rldto.telefone = (Convert.ToString(dataTable.Rows[1]["telefone"]));
            rldto.telemovel = (Convert.ToString(dataTable.Rows[1]["telemovel"]));
            rldto.fax = (Convert.ToString(dataTable.Rows[1]["fax"]));
            rldto.cc = (Convert.ToString(dataTable.Rows[1]["cc"]));
            rldto.iban = (Convert.ToString(dataTable.Rows[1]["iban"]));
            rldto.nif = (Convert.ToString(dataTable.Rows[1]["nif"]));
            rldto.lastChangeBy = (Convert.ToString(dataTable.Rows[1]["lastChangeBy"]));
            return rldto;
        }


    }
    
}