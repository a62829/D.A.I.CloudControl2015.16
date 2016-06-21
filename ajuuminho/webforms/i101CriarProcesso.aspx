<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i101CriarProcesso.aspx.cs" Inherits="ajuUminho.webforms.i101CriarProcesso" %>

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

            <asp:SiteMapDataSource ID="SiteMapDataSource1" StartingNodeUrl="~/webforms/InterfaceProcesso.aspx" SiteMapProvider="MyNewSiteMapProvider" runat="server" />

            <div class="ViewsBoxProcessos">

                <div class="InsideViewsTableBoxProcessos">
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
                                <asp:DropDownList ID="DropDownListIdEstadoID" runat="server" CssClass="Dropdowns-Item"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelIdTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo processo: </asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListIdTipoProcessoID" runat="server" CssClass="Dropdowns-Item"></asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>

                <div class="InsideViewsDetailsBoxProcessos">
                    <div class="titleh4">
                        <h4>Selecione um insolvente</h4>
                    </div>
                    <div class="AlignBox">
                        <asp:ListBox ID="ListBoxInsolventesID" runat="server" CssClass="ListBoxInsolventesProcesso-Item" AutoPostBack="True"></asp:ListBox>
                    </div>
                </div>

                <br />

                <div id="ContentButtonsBox">
                    <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton" OnClick="ButtonCriarID_Click1" />
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
