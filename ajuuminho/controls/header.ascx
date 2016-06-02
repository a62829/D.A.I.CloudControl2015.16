<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="ajuUminho.controls.header" %>
        <div id ="HearderBox">

            <div id="LogoBox">
                
            </div>

            <div id="SearchBox">
                <div id="SearchBar">
                    <asp:TextBox ID="SearchBarID" runat="server" Cssclass="SearchBar-Item"></asp:TextBox>
                </div>
                <div id="SearchButton">
                    <asp:Button ID="SearchButtonID" runat="server" Cssclass="SearchButton-Item" />
                </div>
            </div>
        
        <div id="MenuBox">
            <div id="HeaderButtonsBox">
                <asp:Button ID="ButtonGestaoEtidades" runat="server" Text="Gestão de Entidades" Cssclass="HeaderButtonsBox-Item" OnClick="ButtonGestaoEtidades_Click"/>
                <asp:Button ID="ButtonGestaoIdentidades" runat="server" Text="Gestão de Identidades" Cssclass="HeaderButtonsBox-Item" OnClick="ButtonGestaoIdentidades_Click"/>
<%--                <asp:Button ID="ButtonGestaoAcessos" runat="server" Text="Gestão de Acessos" Cssclass="HeaderButtonsBox-Item"/>
                <asp:Button ID="ButtonConfigProcessos" runat="server" Text="Configurações de Processos" Cssclass="HeaderButtonsBox-Item"/>--%>
                <asp:Button ID="ButtonGestaoProcessos" runat="server" Text="Gestão de Processos" Cssclass="HeaderButtonsBox-Item" OnClick="ButtonGestaoProcessos_Click"/>
            </div>

            <div id="StatusBox">
                <div id="StatusBox2">
                <div id="StatusIcon">
                    <img src="../imagens/default_profile_avatar.png" alt="Alternate Text" class="StatusIconItem" />
                </div>
                <div id="StatusText">
                    <span>Bem vindo, <asp:Label ID="User" runat="server" Text="User"></asp:Label></span>
                </div>
                </div>
                <div id="StatusBox3">
                <div id="StatusButton">
                   <%-- <img ID="ButtonSair" src="../imagens/close_session.png" alt="Sair" OnClick="signOut"/>--%>
                    <asp:Button ID="ButtonSair" runat="server" OnClick="signOut" CssClass="ButtonSairItem"/>
                </div>
                </div>
            </div>

        </div>

        <div id="SiteMapPathBox">
            <asp:SiteMapPath runat="server" id="SiteMapPath"/>
        </div>
    </div>