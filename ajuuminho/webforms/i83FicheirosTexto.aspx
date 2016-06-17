<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i83FicheirosTexto.aspx.cs" Inherits="ajuUminho.webforms.i83FicheirosTexto" %>

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

            <asp:SiteMapDataSource ID="SiteMapDataSource1"  StartingNodeUrl="~/webforms/i102EditarProcesso.aspx"  runat="server" />

            <div class="ProcessosContentBox">

                <div class="ViewsBoxProcessosCRUD">

                    <div class="InsideViewsBox">
                        <div class="titleh4big">
                            <h4>Lista de Ficheiros</h4>
                        </div>

                        <table id="table1">
                            <tr>
                                <th>
                                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome do ficheiro </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo de ficheiro </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="LabelUploadedFromID" runat="server" Text="Label" CssClass="Labels-Item">
                           Submetido por </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="Label3" runat="server" Text="Label" CssClass="Labels-Item">
                           Anotações </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="Label4" runat="server" Text="Label" CssClass="Labels-Item">
                           Data de upload </asp:Label>
                                </th>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDownloadID" runat="server" Text="" CssClass="DownloadButton" />
                                </td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDeleteID" runat="server" Text="" CssClass="DeleteButton" />
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDownloadID1" runat="server" Text="" CssClass="DownloadButton" />
                                </td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDeleteID1" runat="server" Text="" CssClass="DeleteButton" />
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDownloadID2" runat="server" Text="" CssClass="DownloadButton" />
                                </td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDeleteID2" runat="server" Text="" CssClass="DeleteButton" />
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDownloadID3" runat="server" Text="" CssClass="DownloadButton" />
                                </td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDeleteID3" runat="server" Text="" CssClass="DeleteButton" />
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDownloadID4" runat="server" Text="" CssClass="DownloadButton" />
                                </td>
                                <td class="lastRow">
                                    <asp:Button ID="ButtonDeleteID4" runat="server" Text="" CssClass="DeleteButton" />
                                </td>
                            </tr>
                        </table>

                        <br />
                        <br />
                        <br />

                        <div class="AlignBox">
                            <div class="titleh4big">
                                <h4>Sumissão de ficheiros</h4>
                            </div>

                            <asp:FileUpload ID="FileUploadTextoID" runat="server" />
                        </div>
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
