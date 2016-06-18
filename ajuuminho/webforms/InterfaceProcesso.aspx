<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceProcesso.aspx.cs" Inherits="ajuUminho.webforms.InterfaceProcesso" %>

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

            <div class="ViewsBoxProcessos">

                <div class="AlignBox">
                    <div class="titleh3">
                        <h3>Gestão de processos</h3>
                    </div>
                </div>

                <div class="TreeViewBoxCenter">
                    <asp:TreeView ID="TreeView1" CssClass="TreeView" runat="server" DataSourceID="SiteMapDataSource1" ImageSet="Msdn" NodeIndent="10">
                        <HoverNodeStyle Font-Underline="false" BackColor="#CCCCCC" BorderColor="#888888" BorderStyle="none" />
                        <NodeStyle Font-Names="Helvetica" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="2px" />
                        <ParentNodeStyle Font-Bold="False" />
                        <SelectedNodeStyle Font-Underline="False" HorizontalPadding="3px" VerticalPadding="1px" BackColor="White" BorderColor="#888888" BorderStyle="Solid" BorderWidth="1px" />
                    </asp:TreeView>
                </div>

                <asp:SiteMapDataSource ID="SiteMapDataSource1" SiteMapProvider="MyNewSiteMapProvider" StartFromCurrentNode="true" runat="server" />

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
