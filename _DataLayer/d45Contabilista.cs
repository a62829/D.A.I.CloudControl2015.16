﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace _DataLayer
{
    public class d45Contabilista : DBcon
    {
        public d45Contabilista() { }

        public void guardar(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
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
            cmd.CommandText = "INSERT INTO dbo.contabilista VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaContabilista()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[contabilista];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public DataTable getListaContabilistaNoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT contabilista.id, contabilista.nome, contabilista.morada, contabilista.codPostal, contabilista.localidade, contabilista.email, contabilista.telefone, contabilista.telemovel, contabilista.fax, contabilista.cc, contabilista.iban, contabilista.nif, contabilista.lastChangeBy , processo.id  FROM contabilista Right Join insolventeNoProcesso ON contabilista.id = insolventeNoProcesso.idContabilista Right Join processo ON  processo.id = insolventeNoProcesso.idProcesso WHERE processo.id = @id ORDER BY contabilista.id; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void setContabilista(string nome, string morada, string codPostal, string localidade, string email,
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
            cmd.CommandText = "UPDATE dbo.contabilista SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE id = @id;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getContabilista(string id)
        {
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.contabilista WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void removerContabilista(string id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.contabilista WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getListaContabilistaForaDoProcesso(string id)
        {
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM contabilista WHERE NOT ( EXISTS( Select * FROM insolventeNoProcesso WHERE idContabilista = contabilista.id AND idProcesso = '1'))";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        public void adicionarContabilistaAoInsolventeNoProcesso(string idProcesso, string idContabilista, string lastChangeBy, string idInsolvente)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idContabilista", idContabilista);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.Parameters.AddWithValue("@idInsolvente", idInsolvente);
            cmd.CommandText = "UPDATE dbo.insolventeNoProcesso SET idContabilista = @idContabilista WHERE idProcesso = @idProcesso AND idInsolvente = @idInsolvente;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //public void adicionarContabilistaAoCredorNoProcesso(string idProcesso, string idContabilista, string lastChangeBy, string idCredor)
        //{
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
        //    cmd.Parameters.AddWithValue("@idContabilista", idContabilista);
        //    cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
        //    cmd.Parameters.AddWithValue("@idCredor", idCredor);
        //    cmd.CommandText = "UPDATE dbo.credorNoProcesso SET idContabilista = @idContabilista WHERE idProcesso = @idProcesso AND idCredor = @idCredor;";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

        //public void removerContabilistaDoCredorNoProcesso(string idProcesso, string idCredor, string lastChangeBy)
        //{
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
        //    cmd.Parameters.AddWithValue("@idCredor", idCredor);
        //    cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
        //    cmd.CommandText = "UPDATE dbo.credorNoProcesso SET idContabilista = null WHERE idProcesso = @idProcesso AND idCredor = @idCredor";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.ExecuteNonQuery();


        //}

        public void removerContabilistaDoInsolventeNoProcesso(string idProcesso, string idInsolvente, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
            cmd.Parameters.AddWithValue("@idInsolvente", idInsolvente);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "UPDATE dbo.insolventeNoProcesso SET idContabilista = null WHERE idProcesso = @idProcesso AND idInsolvente = @idInsolvente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }
}