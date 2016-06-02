<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="ajuUminho.webforms.eventos" %>
<%@ Register TagPrefix="uc" TagName="header" Src="~/controls/header.ascx"%>

<%-- 60-i --%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>
<body>
    <form id="Form" runat="server">
    <uc:header runat="server" ID="header" />
    <div id="BigBox">
      <div id="EventsBox">
        <div id="EventsTableBox">
            <h3>Lista de Eventos</h3> <div class="hr-align"> <hr /> </div>

            <table id="table1">
            <tr>
                <th>Tipo</th>
                <th>Processo</th>
                <th>Data</th> 
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            </table>

        </div>

        <%--<div id="AtributosBox2">--%>
        <div id="EventsDetailsBox">
            <h3 id="h3-right">Detalhes do Evento</h3> <div class="hr-align"> <hr /> </div>
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelProcessoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Processo Associado: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxProcessoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTipoEventoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo de Evento: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTipoEventoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDataID" runat="server" Text="Label" CssClass="Labels-Item">
                           Data e hora: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxDataID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDescricaoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Descrição: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxDescricaoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
            </table>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Criar Evento" CssClass="ContentButton"/>
            <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar Alterações" CssClass="ContentButton"/>
        </div>
      </div>

        <div id="FooterBox">
            <div id="FooterBox2">
                <% 
                    Response.WriteFile("../html/footer.html");
                %>
            </div>
        </div>

    </div>
    </form>
</body>
</html>
