<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i3AdministradorUtilizadores.ascx.cs" Inherits="ajuUminho.controls.administracao.i3AdministradorUtilizadores" %>

<div class="ViewsBoxNoPadding" runat="server" id="ViewsBoxNoPadding">

    <div class="ViewsButtonsBox">
        <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarUtilizadorID" CssClass="Initial" runat="server"
            OnClick="TabCriarUtilizador_Click" />
        <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarUtilizadorID" CssClass="Initial" runat="server"
            OnClick="TabEditarUtilizador_Click" />
        <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarUtilizadorID" CssClass="Initial" runat="server"
            OnClick="TabEliminarUtilizador_Click" />
    </div>


    <div class="ViewBoxCRUD" runat="server" id="ViewBoxVisible" visible="false">

        <div class="InsideViewsBox">
            <div class="titleh4">
                <h4>Utilizadores</h4>
            </div>
            <div class="InsideViewsTableBox" runat="server" id="ListBoxVisibility">
                <%--<div id="EntidadesBox">--%>
                <%--<div id="ListEdentidades">--%>
                <div class="AlignBox">
                    <asp:ListBox ID="ListBoxUtilizadoresID" runat="server" CssClass="ListBoxEntidades-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxUtilizadoresID_SelectedIndexChanged"></asp:ListBox>
                </div>
            </div>

            <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox">
                <%--<div id="AtributosBox">--%>
                <table class="ContentTable">
                    <tr>
                        <td>
                            <asp:Label ID="LabelUsernameID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Nome de utilizador:  </asp:Label> </td>
                        <td>
                            <asp:TextBox ID="TextBoxUsernameID" runat="server" CssClass="LabelsInputs-Item" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                    <tr ID="TrPasswordID" runat="server" >
                        <td>
                            <asp:Label ID="LabelPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Palavra-passe: </asp:Label> </td>
                        <td>
                            <asp:TextBox ID="TextBoxPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                    <tr  ID="TrConfirmarPasswordID" runat="server">
                        <td>
                            <asp:Label ID="LabelConfirmarPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Confirmar palavra-passe:  </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxConfirmarPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelEmailID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Correio eletrónico: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxEmailID" runat="server" CssClass="LabelsInputs-Item" Enabled="false" ClientIDMode="Static" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelTelefoneID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telefone: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxTelefoneID" runat="server" CssClass="LabelsInputs-Item" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>

            <div id="ContentButtonsBox">
                <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton" OnClick="ButtonCriarID_Click" Visible="false" OnClientClick="return utilizadorValido()"/>
                <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" OnClick="ButtonEditarID_Click" Visible="false" OnClientClick="return utilizadorValidoEditar()"/>
                <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" Visible="false" OnClick="ButtonEliminarID_Click" />
            </div>
        </div>
    </div>
</div>