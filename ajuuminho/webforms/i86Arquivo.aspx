<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i86Arquivo.aspx.cs" Inherits="ajuUminho.webforms.i86Arquivo" %>

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
                    <asp:Button Text="Suspender processo" BorderStyle="None" ID="TabSuspenderProcessoID" CssClass="Initial" runat="server"
                        OnClick="TabSuspenderProcesso_Click" />
                    <asp:Button Text="Arquivar processo" BorderStyle="None" ID="TabArquivarProcessoID" CssClass="Initial" runat="server"
                        OnClick="TabArquivarProcesso_Click" />
                    <asp:Button Text="Reativar processo" BorderStyle="None" ID="TabReativarProcessoID" CssClass="Initial" runat="server"
                        OnClick="TabReativarProcesso_Click" />
                </div>

                <div class="ViewsBox3" runat="server" id="HideContenteDive" visible="false">

                    <div class="InsideViewsTableBox" runat="server" id="ContentListBox" visible="false">
                        <div class="titleh4big">
                            <h4>Lista de processos arquivados</h4>
                        </div>
                        <div class="ListBoxParaTabsProcessos">
                            <asp:ListBox ID="ListBoxParaTabsProcessosID" CssClass="ListBoxParaTabsProcessos-Item" runat="server"></asp:ListBox>
                        </div>
                    </div>


                    <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox" visible="false">

                        <div class="titleh4big" runat="server" id="DetailsTitleBox" visible="false">
                            <h4>Detalhes do processo aquivado</h4>
                        </div>

                        <table class="ContentTable">
                            <tr>
                                <td>
                                    <asp:Label ID="LabelIdLegalID" runat="server" Text="Label" CssClass="Labels-Item">
                          Número processo: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxIdLegalID" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelIdEstadoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Estado: </asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListIdEstadoID" runat="server" Enabled="false"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelIdTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo processo: </asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListIdTipoProcessoID" runat="server" Enabled="false"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="Labels-Item">
                         Data inicio: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="Labels-Item">
                          Nome insolvente: </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div id="ContentButtonsBox">
                        <asp:Button ID="ButtonSuspenderID" runat="server" Text="Suspender" CssClass="ContentButton" Visible="false" />
                        <asp:Button ID="ButtonArquivarID" runat="server" Text="Arquivar" CssClass="ContentButton" Visible="false" />
                        <asp:Button ID="ButtonReativarID" runat="server" Text="Reativar" CssClass="ContentButton" Visible="false" />
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
