<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i91CreditosReclamados.aspx.cs" Inherits="ajuUminho.webforms.i91CreditosReclamados" %>

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
                    <div class="InsideViewsTableBox">
                        <div class="titleh4big">
                            <h4>Lista de Elementos Financeiros</h4>
                        </div>

                        <table id="table1">
                            <tr>
                                <th>Elemento financeiro</th>
                                <th>Credito reclamado</th>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>

                    </div>

                    <div class="InsideViewsDetailsBox">
                        <div class="titleh4big">
                            <h3>Detalhes</h3>
                        </div>
                        <table class="ContentTable">
                            <tr>
                                <td>
                                    <asp:Label ID="LabelElementoFinanceiroID" runat="server" Text="Label" CssClass="Labels-Item">
                           Elemento financeiro: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxElementoFinanceiroID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelTipoCreditoReclamadoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Credito reclamado: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxTipoCreditoReclamadoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div id="ContentButtonsBox">
                        <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" />
                        <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" />
                        <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar" CssClass="ContentButton" />
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
