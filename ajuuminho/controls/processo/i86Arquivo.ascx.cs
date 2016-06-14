using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.controls.processos
{
    public partial class i86Arquivo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TabSuspenderProcesso_Click(object sender, EventArgs e)
        {
            TabSuspenderProcessoID.CssClass = "Clicked";
            TabArquivarProcessoID.CssClass = "Initial";
            TabReativarProcessoID.CssClass = "Initial";
            MainViewID2.ActiveViewIndex = 0;
        }

        protected void TabArquivarProcesso_Click(object sender, EventArgs e)
        {
            TabSuspenderProcessoID.CssClass = "Initial";
            TabArquivarProcessoID.CssClass = "Clicked";
            TabReativarProcessoID.CssClass = "Initial";
            MainViewID2.ActiveViewIndex = 1;
        }

        protected void TabReativarProcesso_Click(object sender, EventArgs e)
        {
            TabSuspenderProcessoID.CssClass = "Initial";
            TabArquivarProcessoID.CssClass = "Initial";
            TabReativarProcessoID.CssClass = "Clicked";
            MainViewID2.ActiveViewIndex = 2;
        }
    }
}