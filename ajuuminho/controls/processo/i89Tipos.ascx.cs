using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.processo
{
    public partial class i89Tipos : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCrossPagePostBack)
            {

            }
            else
            {
                if (!IsPostBack)
                {
                    string idProcesso = Application["idProcesso"].ToString();
                }
                else {

                }
            }
        }
    }
}