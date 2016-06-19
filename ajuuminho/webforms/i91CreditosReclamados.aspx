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
                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarID" CssClass="Initial" runat="server"
                    OnClick="TabCriar_Click" />
                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarID" CssClass="Initial" runat="server"
                    OnClick="TabEditar_Click" />
                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarID" CssClass="Initial" runat="server"
                    OnClick="TabEliminar_Click" />
                <asp:Button Text="Pesquisar" BorderStyle="None" ID="TabPesquisarID" CssClass="Initial" runat="server"
                    OnClick="TabPesquisar_Click" />
            </div>

            <div class="ViewsBoxProcessosCRUD">

                <div class="InsideViewsTableBoxBens" runat="server" id="ContentListBox" visible="false">
                    <div class="titleh4">
                        <h4>Lista de Elementos Financeiros</h4>
                    </div>
                    <div class="DropDpwnEntidadesProcesso">
                    <asp:DropDownList ID="DropDownListCredorID" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListCredorID_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    <br />
                <asp:ListBox ID="ListBoxParaTabsCreditosReclamadosID" CssClass="ListBoxParaTabsProcessos-Item" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="ListBoxParaTabsCreditosReclamadosID_SelectedIndexChanged"></asp:ListBox>
                   
                </div>

                 <br /> <br />

                <div class="InsideViewsDetailsBoxProcessos" runat="server" id="ContentDetailsBox" visible="false">
                    <div class="titleh4" runat="server" id="DetailsTitleBox" visible="false">
                        <h3>Detalhes</h3>
                    </div>
                                        <table class="ContentTable">
                        <tr>
                            <td>
                                <asp:Label ID="LabelCredorID" runat="server" Text="Label" CssClass="Labels-Item">
                           Credor: </asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxCredorID" runat="server" Enabled="false" CssClass="LabelsInputs-Item"></asp:TextBox>
                                <asp:HiddenField ID="HiddenFieldCredorID" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelDescricaoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Descrição: </asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxDescricaoID" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelValorDividaID" runat="server" Text="Label" CssClass="Labels-Item">
                            Valor em Dívida: </asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxValorDividaID" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelValorRecebidoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Valor Pago: </asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxValorRecebidoID" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>

                <div id="ContentButtonsBox">
                    <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton" Visible="false" OnClick="ButtonCriarID_Click" />
                    <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" Visible="false" OnClick="ButtonEditarID_Click" />
                    <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" Visible="false" OnClick="ButtonEliminarID_Click" />
                    <asp:Button ID="ButtonPesquisarID" runat="server" Text="Pesquisar" CssClass="ContentButton" Visible="false" OnClick="ButtonPesquisarID_Click" />
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
