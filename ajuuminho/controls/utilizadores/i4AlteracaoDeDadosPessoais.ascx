<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i4AlteracaoDeDadosPessoais.ascx.cs" Inherits="ajuUminho.controls.utilizadores.i4AlteracaoDeDadosPessoais" %>
<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx" %>

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
            <div class="AlignBox">
                <div class="titleh3">
                    <h3>Editar dados de utilizador</h3>
                </div>
            </div>

            <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox">
                <%--<div id="AtributosBox">--%>
                <table class="ContentTable">
                    <tr>
                        <td>
                            <asp:Label ID="LabelUsernameID" runat="server" Text="Label" CssClass="Labels-Item" Enabled="false"> 
                            Nome de utilizador:  </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxUsernameID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Palavra-passe antiga: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelNovaPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Nova palavra-passe: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxNovaPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelConfirmarPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Confirmar palavra-passe:  </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxConfirmarPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelEmailID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Correio eletrónico: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxEmailID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelTelefoneID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telefone: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxTelefoneID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>

            <div id="ContentButtonsBox">
                <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" OnClick="ButtonEditarID_Click" Visible="false" />
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
