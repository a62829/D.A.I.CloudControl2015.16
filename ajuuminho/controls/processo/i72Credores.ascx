<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i72Credores.ascx.cs" Inherits="ajuUminho.controls.processos.i72Credores" %>

      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <div class="titleh4big"> <h4>Lista de Credores</h4> </div>

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
            <div class="titleh4big"> <h4>Detalhes do Credor</h4> </div>
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
