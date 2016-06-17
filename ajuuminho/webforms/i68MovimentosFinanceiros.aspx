<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i68MovimentosFinanceiros.aspx.cs" Inherits="ajuUminho.webforms.i68MovimentosFinanceiros" %>

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

                <div class="ViewsButtonsBox2">
                    <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarID" CssClass="Initial" runat="server"
                        OnClick="TabCriar_Click" />
                    <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarID" CssClass="Initial" runat="server"
                        OnClick="TabEditar_Click" />
                    <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarID" CssClass="Initial" runat="server"
                        OnClick="TabEliminar_Click" />
                    <asp:Button Text="Pesquisar" BorderStyle="None" ID="TabPesquisarID" CssClass="Initial" runat="server"
                        OnClick="TabPesquisar_Click" />
                </div>

                <div class="ViewsBox3">

                    <div class="InsideViewsTableBox" runat="server" id="ContentListBox" visible="false">
                        <div class="titleh4big">
                            <h4>Lista de Elementos Financeiros</h4>
                        </div>
                        <div class="ListBoxParaTabsProcessos">
                            <asp:ListBox ID="ListBoxParaTabsProcessosID" CssClass="ListBoxParaTabsProcessos-Item" runat="server"></asp:ListBox>
                        </div>
                    </div>

                    <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox" visible="false">
                        <div class="titleh4big" runat="server" id="DetailsTitleBox" visible="false">
                            <h4>Detalhes</h4>
                        </div>
                        <table class="ContentTable">
                            <tr>
                                <td>
                                    <asp:Label ID="LabelDescricaoID" runat="server" Text="Label" CssClass="Labels-Item">
                          Descrição: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxDescricaoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelDataID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Data: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxDataID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelValorID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Valor: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxValorID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                                </td>
                            </tr>
                        </table>

                    </div>

                    <div id="ContentButtonsBox">
                        <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton" Visible="false" />
                        <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" Visible="false" />
                        <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" Visible="false" />
                        <asp:Button ID="ButtonPesquisarID" runat="server" Text="Pesquisar" CssClass="ContentButton" Visible="false" />
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
