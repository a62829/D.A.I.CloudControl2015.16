using System;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
{
    public class Entidade : DBcon
    {
        protected string nome;
        protected string morada;
        protected string codPostal;
        protected string localidade;
        protected string email;
        protected string telefone;
        protected string telemovel;
        protected string fax;
        //protected string cc;
        protected string iban;
        protected string nif;
        protected string lastChangeBy;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Morada
        {
            get
            {
                return morada;
            }

            set
            {
                morada = value;
            }
        }

        public string CodPostal
        {
            get
            {
                return codPostal;
            }

            set
            {
                codPostal = value;
            }
        }

        public string Localidade
        {
            get
            {
                return localidade;
            }

            set
            {
                localidade = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        //public string Cc
        //{
        //    get
        //    {
        //        return cc;
        //    }

        //    set
        //    {
        //        cc = value;
        //    }
        //}

        public string Iban
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }

        public string Nif
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public string LastChangeBy
        {
            get
            {
                return lastChangeBy;
            }

            set
            {
                lastChangeBy = value;
            }
        }

        public string Telemovel
        {
            get
            {
                return telemovel;
            }

            set
            {
                telemovel = value;
            }
        }

        public Entidade()
        {

        }

       public Entidade(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, /*string cc,*/ string iban, string nif, string lastChangeBy)
        {
            this.nome = nome;
            this.morada = morada;
            this.codPostal = codPostal;
            this.localidade = localidade;
            this.email = email;
            this.telefone = telefone;
            this.telemovel = telemovel;
            this.fax = fax;
            //this.cc = cc;
            this.iban = iban;
            this.nif = nif;
            this.lastChangeBy = lastChangeBy;
        }

        //public DataTable getListaEntidade(string tipoEntidade)
        //{
        //    SqlDataReader reader;
        //    cmd.CommandText = "SELECT id,nome FROM [dbo].[" + tipoEntidade + "];";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.Connection.Open();
        //    reader = cmd.ExecuteReader();
        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    con.Close();
        //    return dataTable;
        //}

        //public Entidade getEntidade(string id, string tipoEntidade, Entidade entidade)
        //{

        //    //Listar os Perfis de um Utilizador
        //    SqlDataReader reader;
        //    cmd.CommandText = "SELECT * FROM [dbo].[" + tipoEntidade + "] WHERE [dbo].[" + tipoEntidade + "].[id]='" + id + "';";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.Connection.Open();
        //    reader = cmd.ExecuteReader();
        //    var dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    con.Close();
        //    for (int i = 0; i < dataTable.Rows.Count; i++)
        //    {
        //        entidade.nome = (Convert.ToString(dataTable.Rows[i]["nome"]));
        //        entidade.morada = (Convert.ToString(dataTable.Rows[i]["morada"]));
        //        entidade.codPostal = (Convert.ToString(dataTable.Rows[i]["codPostal"]));
        //        entidade.localidade = (Convert.ToString(dataTable.Rows[i]["localidade"]));
        //        entidade.email = (Convert.ToString(dataTable.Rows[i]["email"]));
        //        entidade.telefone = (Convert.ToString(dataTable.Rows[i]["telefone"]));
        //        entidade.telemovel = (Convert.ToString(dataTable.Rows[i]["telemovel"]));
        //        entidade.fax = (Convert.ToString(dataTable.Rows[i]["fax"]));
        //        if (tipoEntidade != "tribunal") {
        //            entidade.cc = (Convert.ToString(dataTable.Rows[i]["cc"]));
        //        }
        //        else
        //        {
        //            entidade.cc = "";
        //        }
        //        entidade.iban = (Convert.ToString(dataTable.Rows[i]["iban"]));
        //        entidade.nif = (Convert.ToString(dataTable.Rows[i]["nif"]));
        //        entidade.lastChangeBy = (Convert.ToString(dataTable.Rows[i]["lastChangeBy"]));
        //    }
        //    return entidade;
        //}

        //public void SetEntidade(Entidade entidade, string tipoEntidade)
        //{
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@nome", entidade.nome);
        //    cmd.Parameters.AddWithValue("@morada", entidade.morada);
        //    cmd.Parameters.AddWithValue("@codPostal", entidade.codPostal);
        //    cmd.Parameters.AddWithValue("@localidade", entidade.localidade);
        //    cmd.Parameters.AddWithValue("@email", entidade.email);
        //    cmd.Parameters.AddWithValue("@telefone", entidade.telefone);
        //    cmd.Parameters.AddWithValue("@telemovel", entidade.telemovel);
        //    cmd.Parameters.AddWithValue("@fax", entidade.fax);
        //    if (tipoEntidade != "tribunal") {
        //        cmd.Parameters.AddWithValue("@cc", entidade.cc);
        //    }
        //    else
        //    {

        //    }
        //    cmd.Parameters.AddWithValue("@iban", entidade.iban);
        //    cmd.Parameters.AddWithValue("@nif", entidade.nif);
        //    cmd.Parameters.AddWithValue("@lastChangeBy", entidade.lastChangeBy);
        //    if (tipoEntidade != "tribunal") {
        //        cmd.CommandText = "INSERT dbo." + tipoEntidade + " VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
        //    }
        //    else
        //    {
        //        cmd.CommandText = "INSERT dbo." + tipoEntidade + " VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @iban, @nif, @lastChangeBy);";
        //    }
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

        //public void editarEntidade(string id,Entidade entidade, string tipoEntidade)
        //{
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@nome", entidade.nome);
        //    cmd.Parameters.AddWithValue("@morada", entidade.morada);
        //    cmd.Parameters.AddWithValue("@codPostal", entidade.codPostal);
        //    cmd.Parameters.AddWithValue("@localidade", entidade.localidade);
        //    cmd.Parameters.AddWithValue("@email", entidade.email);
        //    cmd.Parameters.AddWithValue("@telefone", entidade.telefone);
        //    cmd.Parameters.AddWithValue("@telemovel", entidade.telemovel);
        //    cmd.Parameters.AddWithValue("@fax", entidade.fax);
        //    if (tipoEntidade != "tribunal")
        //    {
        //        cmd.Parameters.AddWithValue("@cc", entidade.cc);
        //    }
        //    else
        //    {
        //    }
        //    cmd.Parameters.AddWithValue("@iban", entidade.iban);
        //    cmd.Parameters.AddWithValue("@nif", entidade.nif);
        //    cmd.Parameters.AddWithValue("@lastChangeBy", entidade.lastChangeBy);
        //    if (tipoEntidade != "tribunal")
        //    {
        //        cmd.CommandText = "UPDATE dbo." + tipoEntidade + " SET nome=@nome, morada=@morada , codPostal=@codPostal, localidade=@localidade, email=@email, telefone=@telefone, fax=@fax, cc=@cc, iban=@iban, nif=@nif, lastChangeBy=@lastChangeBy WHERE id='" + id + "';";
        //    }
        //    else
        //    {
        //        cmd.CommandText = "UPDATE dbo." + tipoEntidade + " SET nome=@nome, morada=@morada , codPostal=@codPostal, localidade=@localidade, email=@email, telefone=@telefone, fax=@fax, iban=@iban, nif=@nif, lastChangeBy=@lastChangeBy WHERE id='" + id + "'";
        //    }
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //} 


        //================================================================================================//


    }
}