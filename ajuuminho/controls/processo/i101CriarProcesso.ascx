<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i101CriarProcesso.ascx.cs" Inherits="ajuUminho.controls.processo.i101CriarProcesso" %>

      <div class="ViewsBox">
          <div class="InsideViewsTableBox">
              <div class="titleh4"> <h4>Dados base</h4> </div>
          <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelIdLegalID" runat="server" Text="Label"  CssClass="Labels-Item">
                          Número processo: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxIdLegalID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelIdEstadoID" runat="server" Text="Label"  CssClass="Labels-Item">
                           Estado: </asp:Label> </td>
                      <td> <asp:DropDownList ID="DropDownListIdEstadoID" runat="server"></asp:DropDownList> </td>    
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelIdTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo processo: </asp:Label> </td>
                      <td> <asp:DropDownList ID="DropDownListIdTipoProcessoID" runat="server"></asp:DropDownList> </td>
                  </tr>
            </table>
            </div>

          <div class="InsideViewsDetailsBox">
              <div class="titleh4"> <h4>Selecione um insolvente</h4> </div>
                <div class="AlignBox">
                    <asp:ListBox ID="ListBoxInsolventesID" runat="server" CssClass="ListBoxEntidades-Item" AutoPostBack="True"></asp:ListBox>
                </div>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonCriarID" runat="server" Text="Criar" CssClass="ContentButton"/>
        </div>
      </div>
