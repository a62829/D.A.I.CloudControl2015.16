using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajuUminho.webforms
{
    public partial class i86Arquivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                if (!IsPostBack)
                {
                string idProcesso = Application["idProcesso"].ToString();
            }
                else {

                }

        }

        protected void TabSuspenderProcesso_Click(object sender, EventArgs e)
        {
            ContentListBox.Visible = false;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Processos");
            DetailsTitleBox.Visible = false;
            ButtonSuspenderID.Visible = true;
            ButtonArquivarID.Visible = false;
            ButtonReativarID.Visible = false;
            TabSuspenderProcessoID.CssClass = "Clicked";
            TabArquivarProcessoID.CssClass = "Initial";
            TabReativarProcessoID.CssClass = "Initial";
            //MainViewID2.ActiveViewIndex = 0;
        }

        protected void TabArquivarProcesso_Click(object sender, EventArgs e)
        {
            ContentListBox.Visible = false;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBox2Processos");
            DetailsTitleBox.Visible = false;
            ButtonSuspenderID.Visible = false;
            ButtonArquivarID.Visible = true;
            ButtonReativarID.Visible = false;
            TabSuspenderProcessoID.CssClass = "Initial";
            TabArquivarProcessoID.CssClass = "Clicked";
            TabReativarProcessoID.CssClass = "Initial";
            //MainViewID2.ActiveViewIndex = 1;
        }

        protected void TabReativarProcesso_Click(object sender, EventArgs e)
        {
            ContentListBox.Visible = true;
            ContentDetailsBox.Visible = true;
            ContentDetailsBox.Attributes.Add("class", "InsideViewsDetailsBoxProcessos");
            DetailsTitleBox.Visible = true;
            ButtonSuspenderID.Visible = false;
            ButtonArquivarID.Visible = false;
            ButtonReativarID.Visible = true;
            TabSuspenderProcessoID.CssClass = "Initial";
            TabArquivarProcessoID.CssClass = "Initial";
            TabReativarProcessoID.CssClass = "Clicked";
            //MainViewID2.ActiveViewIndex = 2;
        }
    }
}