<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i9AtribuirPerfil.ascx.cs" Inherits="ajuUminho.controls.administracao.i9AtribuirPerfil" %>

<div id="IdentidadesBox">
    <div class="titleh4">
        <h4>Utilizadores</h4>
    </div>
    <div id="ListBoxIdentidades">
        <asp:ListBox ID="ListBoxIdentidadesID" runat="server" CssClass="ListBoxIdentidades-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxIdentidadesID_SelectedIndexChanged"></asp:ListBox>
    </div>
</div>

<div id="RolesBox">
    <div class="titleh4">
        <h4>Perfis</h4>
    </div>
    <div id="PerfisListBox1">
        <div id="PerfisListBox3">
            <div class="titleh5">
                <h5>Perfis do Sistema</h5>
            </div>
            <div class="PerfisListBox-Item">
                <asp:ListBox ID="ListBoxPerfisID" runat="server" CssClass="PerfisList-Item" DataSourceID="SqlDataSource1" AutoPostBack="True"></asp:ListBox>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <div class="AlignBoxEliminarPerfil">
                 <asp:Button ID="ButtonEliminarID" runat="server" Text="x" CssClass="PerfilRemoveSistemaButton" /> Remover do sistema 
            </div>
        </div>
        <div id="PerfisButtonsBox">
            <asp:Button ID="ButtonMoreID" runat="server" Text=">" CssClass="PerfilUserButton" OnClick="ButtonMoreID_Click" />
            <asp:Button ID="ButtonLessID" runat="server" Text="<" CssClass="PerfilUserButton" OnClick="ButtonLessID_Click" />
        </div>
        <div id="PerfisListBox4">
            <div class="titleh5">
                <h5>Perfis Associados ao Utilizador</h5>
            </div>
            <div class="PerfisListBox-Item">
                <asp:ListBox ID="ListBoxPerfisAssociadosID" runat="server" CssClass="PerfisList-Item" AutoPostBack="True"></asp:ListBox>
            </div>
        </div>
    </div>

    <div id="PerfisListBox2">
        <div id="AdicionarPerfilBox">
            <div class="titleh5">
                <h5>Adicionar novo perfil ao sistema</h5>
            </div>
            <asp:TextBox ID="TextBoxAdicionarPerfilID" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAdicionarPerfilID" runat="server" Text="+" CssClass="PerfilAddSistemaButton" OnClick="ButtonAdicionarPerfilID_Click" />
        </div>
    </div>
</div>

