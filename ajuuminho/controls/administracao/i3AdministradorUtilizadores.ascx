<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i3AdministradorUtilizadores.ascx.cs" Inherits="ajuUminho.controls.administracao.i3AdministradorUtilizadores" %>

<div id="EntidadesBox">
            <div class="titleh4"> <h4>Utilizadores</h4> </div>
            <div id="ListEdentidades">
                <div class="AlignBox">
                    <asp:ListBox ID="ListBoxEntidadesID" runat="server" CssClass="ListBoxEntidades-Item" AutoPostBack="True"></asp:ListBox>
                </div>
            </div>

        <div id="AtributosBox">
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelNomeID" runat="server" Text="Label"  CssClass="Labels-Item">
                          Nome: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelMoradaID" runat="server" Text="Label"  CssClass="Labels-Item">
                           Morada: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxMoradaID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelCodPostalID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Cód-Postal: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxCodPostalID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelLocalidadeID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Localidade: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxLocalidadeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelEmailID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Email: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxEmailID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTelefoneID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telefone: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTelefoneID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTelemovelID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telemóvel: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTelemovelID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelFaxID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Fax: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxFaxID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelCcID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Cartão de cidadão: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxCcID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelIbanID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Iban: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxIbanID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelNifID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           NIF: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNifID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelLastChangedID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Alterado por: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxLastChangedID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
             </table>
          </div>
        </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonSalvarID" runat="server" Text="Salvar"  CssClass="ContentButton"/>
        </div>
