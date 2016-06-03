﻿using ajuUminho.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c35EdicaoJuiz
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c35EdicaoJuiz : System.Web.Services.WebService
    {
        [WebMethod]
        public void editarJuiz(string nome, string morada, string codPostal, string localidade, string email,
                    string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            //// efetuar controlos
            //d21RepresentanteLegal rl = new d21RepresentanteLegal();
            //var id = rl.getID(cc);
            //if (rl.ccUnique(cc, id) == true)
            //{
            //    rl.setRepresentanteLegal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy, id);
            //}

        }

        [WebMethod]
        public void criarJuiz(string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d33Juiz j = new d33Juiz();
            j.guardar(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);

        }

        //[WebMethod]
        //public DataTable listarRepresentantesLegais()
        //{
        //    d21RepresentanteLegal rl = new d21RepresentanteLegal();
        //    DataTable dt = rl.getListaRepresentanteLegal();
        //    return dt;
        //}

        [WebMethod]
        public d33JuizDto getJuiz(string id)
        {
            d33JuizDto jdto = new d33JuizDto();
            return jdto.getJuiz(id);
        }

        [WebMethod]
        public Dictionary<String, String> getListaRepresentantesLegais()
        {

            d21RepresentanteLegalDto jdto = new d21RepresentanteLegalDto();
            DataTable dt = jdto.getListaRepresentanteLegal();
            Dictionary<String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(Convert.ToString(dt.Rows[i]["id"]), Convert.ToString(dt.Rows[i]["nome"]));
            }
            return lista;

        }
    }
}
