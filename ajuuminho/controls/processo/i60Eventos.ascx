<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i60Eventos.ascx.cs" Inherits="ajuUminho.controls.processos.i60Eventos" %>

    <%-- falta calendario --%>
      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <h3>Lista de Eventos</h3> <div class="hr-align"> <hr /> </div>

            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        </div>

        <div class="InsideViewsDetailsBox">
            <h3>Detalhes do Evento</h3> <div class="hr-align"> <hr /> </div>
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelProcessoAssociadoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Processo Associado: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxProcessoAssociadoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTipoEventoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo de Evento: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTipoEventoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDataID" runat="server" Text="Label" CssClass="Labels-Item">
                           Data e hora: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxDataID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDescricaoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Descrição: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxDescricaoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
            </table>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonCriarID" runat="server" Text="Criar Evento" CssClass="ContentButton"/>
            <asp:Button ID="Button1" runat="server" Text="Criar Evento" CssClass="ContentButton"/>
            <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar Alterações" CssClass="ContentButton"/>
        </div>
      </div>
