﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ajuUminho.App_Code;
using System.Data;
namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c11Autenticacao
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c11Autenticacao : System.Web.Services.WebService
    {

        [WebMethod]
        public bool signIn(string userName, string Password)
        {
            d2Utilizadores connn = new d2Utilizadores();
            if (connn.signIn(userName, Password) == true)
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
