<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i72Credores.aspx.cs" Inherits="ajuUminho.webforms.i72Credores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="EntidadesProcessoBox">
        <div class="titleh4">
            <h4>Credores</h4>
        </div>
        <div class="DropDpwnEntidadesProcesso">
            <asp:DropDownList ID="DropDownListCredoresID" CssClass="DropDpwnEntidadesProcesso-Item" runat="server"></asp:DropDownList>
        </div>
    </div>

    <div class="AtribuirEntidadesBox">
        <div class="titleh4big">
            <h4>Atribuir ao processo</h4>
        </div>
        <div class="AtribuirEntidadesListBox1">
            <div class="AtribuirEntidadesListBox2">
                <div class="titleh5">
                    <h5>Credores no Sistema</h5>
                </div>
                <div class="EntidadesListBox-Item">
                    <asp:ListBox ID="ListBoxCredoresID" runat="server" CssClass="EntidadesList-Item" DataSourceID="SqlDataSource1" AutoPostBack="True"></asp:ListBox>
                </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </div>
            <div id="AtrbuirEntidadesButtonsBox">
                <asp:Button ID="ButtonMoreID" runat="server" Text=">" CssClass="PerfilUserButton" OnClick="ButtonMoreID_Click" />
                <asp:Button ID="ButtonLessID" runat="server" Text="<" CssClass="PerfilUserButton" OnClick="ButtonLessID_Click" />
            </div>
            <div class="AtribuirEntidadesListBox3">
                <div class="titleh5">
                    <h5>Credores associados ao processo</h5>
                </div>
                <div class="EntidadesListBox-Item">
                    <asp:ListBox ID="ListBoxCredoresAssociadosID" runat="server" CssClass="EntidadesList-Item" AutoPostBack="True"></asp:ListBox>
                </div>
            </div>
        </div>
    </div>

    <div id="ContentButtonsBox">
        <asp:Button ID="ButtonGravarID" runat="server" Text="Gravar" CssClass="ContentButton" OnClick="ButtonGravarID_Click" />
    </div>
    </form>
</body>
</html>
