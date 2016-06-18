<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i102EditarProcesso.aspx.cs" Inherits="ajuUminho.webforms.i102EditarProcesso" %>

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
                <asp:TreeView ID="TreeViewID" CssClass="TreeView" runat="server" DataSourceID="SiteMapDataSource1" ImageSet="Msdn" NodeIndent="10">
                    <HoverNodeStyle Font-Underline="false" BackColor="#CCCCCC" BorderColor="#888888" BorderStyle="none" />
                    <NodeStyle Font-Names="Helvetica" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="2px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="False" HorizontalPadding="3px" VerticalPadding="1px" BackColor="White" BorderColor="#888888" BorderStyle="Solid" BorderWidth="1px" />
                </asp:TreeView>
                <asp:TreeView ID="TreeViewID1" CssClass="TreeView" runat="server" DataSourceID="SiteMapDataSource2" ImageSet="Msdn" NodeIndent="10" Visible="false">
                    <HoverNodeStyle Font-Underline="false" BackColor="#CCCCCC" BorderColor="#888888" BorderStyle="none" />
                    <NodeStyle Font-Names="Helvetica" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="2px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="False" HorizontalPadding="3px" VerticalPadding="1px" BackColor="White" BorderColor="#888888" BorderStyle="Solid" BorderWidth="1px" />
                </asp:TreeView>
            </div>

            <asp:SiteMapDataSource ID="SiteMapDataSource2" StartFromCurrentNode="true" runat="server" />
            <asp:SiteMapDataSource ID="SiteMapDataSource1" StartingNodeUrl="~/webforms/InterfaceProcesso.aspx" SiteMapProvider="MyNewSiteMapProvider" runat="server" />


            <div class="ViewsBoxProcessos">

                <div class="InsideViewsDetailsBoxProcessos">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />

                    <div class="AlignBox">
                        <div class="titleh4">
                            <h4>Selecione um processo</h4>
                        </div>
                        <asp:ListBox ID="ListBoxProcessosID" runat="server" CssClass="ListBoxProcessos-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxProcessosID_SelectedIndexChanged"></asp:ListBox>
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
