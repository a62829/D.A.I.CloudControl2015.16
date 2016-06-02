<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="anexos.ascx.cs" Inherits="ajuUminho.controls.anexos" %>

<%-- 6-i --%>

      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <h3>Lista de Ficheiros</h3> <div class="hr-align"> <hr /> </div>

            <table id="table1">
            <tr>
                <th>Nome</th>
                <th>Tipo</th>
                <th>Data</th> 
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            </table>

        </div>

        <div class="InsideViewsDetailsBox">
            <h3>Detalhes do Ficheiro</h3> <div class="hr-align"> <hr /> </div>
              <table class="ContentTable">
                   <tr>
                      <td> <asp:Label ID="LabelFicheiro" runat="server" Text="Label" CssClass="Labels-Item">
                           Ficheiro: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxFicheiro" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelNomeFicheiroID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome do ficheiro: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxProcessoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTipoFicheiroID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo de ficheiro: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTipoEventoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelAnotacoesID" runat="server" Text="Label" CssClass="Labels-Item">
                           Anotações: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxAnotacoesID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDataID" runat="server" Text="Label" CssClass="Labels-Item">
                           Arquivar processo???: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxDataID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
            </table>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar" CssClass="ContentButton"/>
        </div>
      </div>
