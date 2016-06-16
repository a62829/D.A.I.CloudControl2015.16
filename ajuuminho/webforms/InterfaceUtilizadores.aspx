<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceUtilizadores.aspx.cs" Inherits="ajuUminho.webforms.InterfaceUtilizadores" %>
<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx" %>
<%@ Register Src="~/controls/utilizadores/i4AlteracaoDeDadosPessoais.ascx" TagPrefix="uc2" TagName="i4AlteracaoDeDadosPessoais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8" />
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet" />
</head>
<body>
    <form id="Form" runat="server">
        <uc1:i14TerminoDeSessao runat="server" ID="headerID" />

        <div id="BigBox">

            <br/><br/><br/><br/>

            <uc2:i4AlteracaoDeDadosPessoais runat="server" ID="i4AlteracaoDeDadosPessoaisID" />
               
        </div>
    </form>

    <div id="FooterBox">
        <div id="FooterBox2">
            <% 
                Response.WriteFile("../html/footer.html");
            %>
        </div>
    </div>
</body>
</html>
