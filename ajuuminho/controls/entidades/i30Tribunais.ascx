<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i30Tribunais.ascx.cs" Inherits="ajuUminho.controls.entidades.i30Tribunais" %>

<div class="ViewsBox">

    <div class="ViewsButtonsBox">
        <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarTribunalID" CssClass="Initial" runat="server"
            OnClick="TabCriarTribunal_Click" />
        <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarTribunalID" CssClass="Initial" runat="server"
            OnClick="TabEditarTribunal_Click" />
        <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarTribunalID" CssClass="Initial" runat="server"
            OnClick="TabEliminarTribunal_Click" />
        <asp:Button Text="Pesquisar" BorderStyle="None" ID="TabPesquisarTribunalID" CssClass="Initial" runat="server"
            OnClick="TabPesquisarTribunal_Click" />
    </div>

    <div class="ViewBoxCRUD" runat="server" id="ViewBoxVisible" visible="false">
        <div class="InsideViewsBox">
            <div class="InsideViewsTableBox" runat="server" id="ListBoxVisibility">
                <div class="AlignBox">
                    <asp:ListBox ID="ListBoxEntidadesID" runat="server" CssClass="ListBoxEntidades-Item" AutoPostBack="True"></asp:ListBox>
                </div>
            </div>

            <div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox">
                <table class="ContentTable">
                    <tr>
                        <td>
                            <asp:Label ID="LabelNomeID" runat="server" Text="Label" CssClass="Labels-Item">
                          Nome: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxNomeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelMoradaID" runat="server" Text="Label" CssClass="Labels-Item">
                           Morada: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxMoradaID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelCodPostalID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Cód-Postal: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxCodPostalID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelLocalidadeID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Localidade: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxLocalidadeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
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
                    <tr>
                        <td>
                            <asp:Label ID="LabelTelemovelID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telemóvel: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxTelemovelID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelFaxID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Fax: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxFaxID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelIbanID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Iban: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxIbanID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelNifID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           NIF: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxNifID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelLastChangedID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Alterado por: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxLastChangedID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>

            <div id="ContentButtonsBox">
                <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton" OnClick="ButtonCriarID_Click" Visible="false" />
                <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" OnClick="ButtonEditarID_Click" Visible="false" />
                <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" Visible="false" OnClick="ButtonEliminarID_Click" />
                <asp:Button ID="ButtonPesquisarID" runat="server" Text="Pesquiar" CssClass="ContentButton" Visible="false" OnClick="ButtonPesquisarID_Click" />
            </div>

        </div>

    </div>

</div>
