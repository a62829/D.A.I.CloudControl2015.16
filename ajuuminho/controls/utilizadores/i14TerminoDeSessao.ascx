<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i14TerminoDeSessao.ascx.cs" Inherits="ajuUminho.controls.utilizadores.i14TerminoDeSessao" %>

<div id="HearderBox">

    <div id="LogoBox">
    </div>

    <div id="SearchBox">
        <div id="SearchBar">
            <asp:TextBox ID="SearchBarID" runat="server" CssClass="SearchBar-Item"></asp:TextBox>
        </div>
        <div id="SearchButton">
            <asp:Button ID="SearchButtonID" runat="server" CssClass="SearchButton-Item" />
        </div>
    </div>

    <div id="MenuBox">
        <div id="HeaderButtonsBox">
            <asp:Button ID="ButtonEntidadesID" runat="server" Text="Entidades" CssClass="HeaderButtonsBox-Item" OnClick="ButtonEntidades_Click" />
            <asp:Button ID="ButtonAdministracaoID" runat="server" Text="Administração" CssClass="HeaderButtonsBox-Item" OnClick="ButtonAdministracao_Click" />
            <asp:Button ID="ButtonProcessosID" runat="server" Text="Processos" CssClass="HeaderButtonsBox-Item" OnClick="ButtonProcessos_Click" />
            <asp:Button ID="ButtonRelatoriosID" runat="server" Text="Relatórios" CssClass="HeaderButtonsBox-Item" />
        </div>

        <div id="StatusBox">

            <div id="StatusBox2">
                <div id="StatusIcon">
                    <img src="../imagens/default_profile_avatar.png" alt="Alternate Text" class="StatusIconItem" />
                </div>
                <div id="StatusText">
                    <span>Bem vindo, <asp:Label ID="User" runat="server" Text="User"></asp:Label></span>
                </div>
<%--                <div id="StatusButton">--%>
                    <asp:Button ID="ButtonAlterarDadosPessoaisID" runat="server" Text="Button"/>
                <%--</div>--%>
            </div>
            <div id="StatusBox3">
                <div id="StatusButton">
                    <%-- <img ID="ButtonSair" src="../imagens/close_session.png" alt="Sair" OnClick="signOut"/>--%>
                    <asp:Button ID="ButtonSair" runat="server" OnClick="signOut" CssClass="ButtonSairItem" />
                </div>
            </div>

        </div>

    </div>

    <div id="SiteMapPathBox">
        <asp:SiteMapPath runat="server" ID="SiteMapPath" />
    </div>
</div>
