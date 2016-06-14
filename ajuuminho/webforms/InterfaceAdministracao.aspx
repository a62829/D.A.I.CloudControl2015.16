<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceAdministracao.aspx.cs" Inherits="ajuUminho.webforms.InterfaceAdministracao" %>
<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx"%>
<%@ Register TagPrefix="uc2" TagName="i3AdministradorUtilizadores" Src="~/controls/administracao/i3AdministradorUtilizadores.ascx"%>
<%@ Register TagPrefix="uc3" TagName="i9AtribuirPerfil" Src="~/controls/administracao/i9AtribuirPerfil.ascx"%>
<%@ Register TagPrefix="uc4" TagName="i10ConfirmarPerfil" Src="~/controls/administracao/i10ConfirmarPerfil.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>
<body>
    <form id="Form" runat="server">
        <uc1:i14TerminoDeSessao runat="server" ID="header" />
    <div id="BigBox">
            <div class="AlignBox">
                <div class="titleh3"> <h3>Gestão de utilizadores e perfis</h3> </div>
            </div>

        <div id="MultiViewBox">

            <div id="MultiViewButtonsBox">
                <asp:Button Text="Administrador de Utilizadores" BorderStyle="None" ID="TabAdministradorUtilizadoresID" CssClass="Initial" runat="server"
                    OnClick="TabAdministradorUtilizadores_Click" />
                <asp:Button Text="Atribuir Perfil" BorderStyle="None" ID="TabAtribuirPerfilID" CssClass="Initial" runat="server"
                    OnClick="TabAtribuirPerfil_Click" />
                <asp:Button Text="Confirmar Perfil" BorderStyle="None" ID="TabConfirmarPerfilID" CssClass="Initial" runat="server"
                    OnClick="TabConfirmarPerfil_Click" />
            </div>

                <asp:MultiView ID="MainViewID" runat="server">
                    <asp:View ID="ViewAdministradorUtilizadoresID" runat="server">
                            <uc2:i3AdministradorUtilizadores runat="server" ID="administradorUtilizadoresID" />
                    </asp:View>
                    <asp:View ID="ViewAtribuirPerfilID" runat="server">
                       <div class="ViewsBox">
                           <uc3:i9AtribuirPerfil runat="server" id="atribuirPerfilID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewConfirmarPerfilID" runat="server">
                        <div class="ViewsBox">
                            <uc4:i10ConfirmarPerfil runat="server" id="confirmarPerfilID" />
                        </div>
                    </asp:View>
                 </asp:MultiView>
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
