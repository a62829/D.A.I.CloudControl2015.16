<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i4AlteracaoDeDadosPessoais.ascx.cs" Inherits="ajuUminho.controls.utilizadores.i4AlteracaoDeDadosPessoais" %>

            <div class="AlignBox">
                <div class="titleh3">
                    <h3>Editar dados de utilizador</h3>
                </div>
             </div>

            <div class="InsideViewsBox">
                <%--<div id="AtributosBox">--%>
                <table class="ContentTable">
                    <tr>
                        <td>
                            <asp:Label ID="LabelUsernameID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Nome de utilizador:  </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxUsernameID" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Palavra-passe antiga: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelNovaPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Nova palavra-passe: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxNovaPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelConfirmarPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Confirmar palavra-passe:  </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxConfirmarPasswordID" type="password" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelEmailID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Correio eletrónico: </asp:Label>
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
                <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" OnClick="ButtonEditarID_Click" />
            </div>