<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="credores.ascx.cs" Inherits="ajuUminho.controls.credores" %>

<%-- 6-i --%>

      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <h3>Lista de Credores</h3> <div class="hr-align"> <hr /> </div>

            <table id="table1">
            <tr>
                <th>Nome</th>
                <th>...</th>
                <th>...</th> 
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
            <h3>Detalhes do Credor</h3> <div class="hr-align"> <hr /> </div>
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelProcessoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxProcessoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTipoEventoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           ...: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTipoEventoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDataID" runat="server" Text="Label" CssClass="Labels-Item">
                           ...: </asp:Label> </td>
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
