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

            <div class="TreeViewBox">
                <asp:TreeView ID="TreeView1" CssClass="TreeView" runat="server" DataSourceID="SiteMapDataSource1" ImageSet="Msdn" NodeIndent="10">
                    <HoverNodeStyle Font-Underline="false" BackColor="#CCCCCC" BorderColor="#888888" BorderStyle="none" />
                    <NodeStyle Font-Names="Helvetica" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="2px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="False" HorizontalPadding="3px" VerticalPadding="1px" BackColor="White" BorderColor="#888888" BorderStyle="Solid" BorderWidth="1px" />
                </asp:TreeView>
            </div>

            <asp:SiteMapDataSource ID="SiteMapDataSource1" StartingNodeUrl="~/webforms/i102EditarProcesso.aspx" runat="server" />

            <div class="ViewsButtonsBox2">
                <asp:Button Text="Suspender processo" BorderStyle="None" ID="TabSuspenderProcessoID" CssClass="Initial" runat="server"
                    OnClick="TabSuspenderProcesso_Click" />
                <asp:Button Text="Arquivar processo" BorderStyle="None" ID="TabArquivarProcessoID" CssClass="Initial" runat="server"
                    OnClick="TabArquivarProcesso_Click" />
                <asp:Button Text="Reativar processo" BorderStyle="None" ID="TabReativarProcessoID" CssClass="Initial" runat="server"
                    OnClick="TabReativarProcesso_Click" />
            </div>

            <div class="ViewsBoxProcessosCRUD">

                <div class="InsideViewsTableBoxArquivo" runat="server" id="ContentListBox" visible="false">
                    <div class="titleh4">
                        <h4>Lista de processos arquivados</h4>
                    </div>
                    <div class="ListBoxParaTabsProcessos">
                        <asp:ListBox ID="ListBoxParaTabsProcessosID" CssClass="ListBoxParaTabsProcessos-Item" runat="server"></asp:ListBox>
                    </div>
                </div>


                <div class="InsideViewsTableBoxProcessos" runat="server" id="ContentDetailsBox" visible="false">

                    <div class="titleh4" runat="server" id="DetailsTitleBox" visible="false">
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
                                <asp:DropDownList ID="DropDownListIdEstadoID" runat="server" Enabled="false" CssClass="Dropdowns-Item"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelIdTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo processo: </asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListIdTipoProcessoID" runat="server" Enabled="false" CssClass="Dropdowns-Item"></asp:DropDownList>
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
