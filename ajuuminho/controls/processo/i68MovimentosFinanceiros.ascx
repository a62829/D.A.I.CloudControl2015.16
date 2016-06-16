<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i68MovimentosFinanceiros.ascx.cs" Inherits="ajuUminho.controls.processos.i68MovimentosFinanceiros" %>

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
