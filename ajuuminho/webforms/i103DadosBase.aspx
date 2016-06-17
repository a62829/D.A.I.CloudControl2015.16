<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i103DadosBase.aspx.cs" Inherits="ajuUminho.webforms.i103DadosBase" %>

<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet" />
</head>
<body>
    <form id="form1" runat="server">
        <uc1:i14TerminoDeSessao runat="server" ID="headerID" />
        <div id="BigBox">

            <div class="ViewBoxCRUD">

                <div class="InsideViewsBox">
                    <div class="titleh4">
                        <h4>Dados base</h4>
                    </div>
                    <table class="ContentTable">
                        <tr>
                            <td>
                                <asp:Label ID="LabelIdLegalID" runat="server" Text="Label" CssClass="Labels-Item">
                          Número processo: </asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxIdLegalID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelIdEstadoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Estado: </asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListIdEstadoID" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelIdTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo processo: </asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListIdTipoProcessoID" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                    </table>

                    <div id="ContentButtonsBox">
                        <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" />
                    </div>
                </div>
            </div>
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
