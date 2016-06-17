<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i56AtribuicaoEntidades.aspx.cs" Inherits="ajuUminho.webforms.i56AtribuicaoEntidades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="EntidadesProcessoBox">
        <div class="titleh4">
            <h4>Entidades</h4>
        </div>
        <div class="DropDpwnEntidadesProcesso">
            <asp:DropDownList ID="DropDownListEntidadesID" CssClass="DropDpwnEntidadesProcesso-Item" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListEntidadesID_SelectedIndexChanged">
                <asp:ListItem>Representante Legal</asp:ListItem>
                <asp:ListItem>Administrador Judicial</asp:ListItem>
                <asp:ListItem>Tribunal</asp:ListItem>
                <asp:ListItem>Juiz</asp:ListItem>
                <asp:ListItem>Credor</asp:ListItem>
                <asp:ListItem>Insolvente</asp:ListItem>
                <asp:ListItem>Contabilista</asp:ListItem>
                <asp:ListItem>Prestador de Serviços</asp:ListItem>
                <asp:ListItem>Outras Entidades</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>

    <div class="AtribuirEntidadesBox">
        <div class="titleh4big">
            <h4>Atribuir ao processo</h4>
        </div>
        <div class="AtribuirEntidadesListBox1">
            <div class="AtribuirEntidadesListBox2">
                <div class="titleh5">
                    <h5>Entidades no Sistema</h5>
                </div>
                <div class="EntidadesListBox-Item">
                    <asp:ListBox ID="ListBoxEntidadesID" runat="server" CssClass="EntidadesList-Item" DataSourceID="SqlDataSource1" AutoPostBack="True" OnSelectedIndexChanged="ListBoxEntidadesID_SelectedIndexChanged"></asp:ListBox>
                </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </div>
            <div id="AtrbuirEntidadesButtonsBox">
                <asp:Button ID="ButtonMoreID" runat="server" Text=">" CssClass="PerfilUserButton" OnClick="ButtonMoreID_Click" />
                <asp:Button ID="ButtonLessID" runat="server" Text="<" CssClass="PerfilUserButton" OnClick="ButtonLessID_Click" />
            </div>
            <div class="AtribuirEntidadesListBox3">
                <div class="titleh5">
                    <h5>Entidades associadas ao processo</h5>
                </div>
                <div class="EntidadesListBox-Item">
                    <asp:ListBox ID="ListBoxEntidadesAssociadosID" runat="server" CssClass="EntidadesList-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxEntidadesAssociadosID_SelectedIndexChanged"></asp:ListBox>
                </div>
            </div>
        </div>
    </div>

    <div id="ContentButtonsBox">
        <asp:Button ID="ButtonGravarID" runat="server" Text="Gravar" CssClass="ContentButton" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>

    </form>
</body>
</html>
