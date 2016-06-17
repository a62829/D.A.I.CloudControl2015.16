<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i64Bens.aspx.cs" Inherits="ajuUminho.webforms.i64Bens" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            <h4>Lista de Bens</h4>
        </div>
        <div class="ListBoxParaTabsProcessos">
            <asp:ListBox ID="ListBoxParaTabsProcessosID" CssClass="ListBoxParaTabsProcessos-Item" runat="server"></asp:ListBox>
        </div>
    </div>

    <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox" visible="false">
        <div class="titleh4big" runat="server" id="DetailsTitleBox" visible="false">
            <h4>Detalhes do Evento</h4>
        </div>
        <table class="ContentTable">
            <tr>
                <td>
                    <asp:Label ID="LabelAtivosID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Ativos: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxAtivosID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNomeInsolventeID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome insolvente: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomeInsolventeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelTipoAtivoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Tipo de ativo: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxTipoAtivoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                </td>
            </tr>
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
                    <asp:Label ID="LabelValorAquisicaoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Valor de aquisição: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxValorAquisicaoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelValorMercadoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Valor de mercado: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxValorMercadoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelValorLiquidacaoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Valor de liquidação: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxValorLiquidacaoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
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

    </form>
</body>
</html>
