<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i3AdministradorUtilizadores.ascx.cs" Inherits="ajuUminho.controls.administracao.i3AdministradorUtilizadores" %>

<div class="ViewsBox">

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
                    <asp:ListBox ID="ListBoxEntidadesID" runat="server" CssClass="ListBoxEntidades-Item" AutoPostBack="True"></asp:ListBox>
                </div>
            </div>

            <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox">
                <%--<div id="AtributosBox">--%>
                <table class="ContentTable">
                    <tr>
                        <td>
                            UserName:</td>
                        <td>
                            <asp:TextBox ID="TextBoxNomeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Password:</td>
                        <td>
                            <asp:TextBox ID="TextBoxPasswordID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            ConfirmarPassword:
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxConfirmarPasswordID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelEmailID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Email: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxEmailID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelTelefoneID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telefone: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxTelefoneID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>

            <div id="ContentButtonsBox">
                <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton" OnClick="ButtonCriarID_Click" Visible="false" />
                <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" OnClick="ButtonEditarID_Click" Visible="false" />
                <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" Visible="false" OnClick="ButtonEliminarID_Click" />
            </div>
        </div>
    </div>
</div>
