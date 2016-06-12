<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ajuUminho.webforms.login" %>
<%@ Register TagPrefix="uc1" TagName="i12AutenticacaoDeUtilizadores" Src="~/controls/utilizadores/i12AutenticacaoDeUtilizadores.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>

    <body>

        <uc1:i12AutenticacaoDeUtilizadores runat="server" id="i12AutenticacaoDeUtilizadores" />

    </body>
</html>