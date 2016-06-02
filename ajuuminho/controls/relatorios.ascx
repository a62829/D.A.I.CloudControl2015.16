<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="relatorios.ascx.cs" Inherits="ajuUminho.controls.relatorios" %>

<%-- 6-i --%>

      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <h3>Lista de Relatórios</h3> <div class="hr-align"> <hr /> </div>

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
            <h3>Detalhes do Relatório</h3> <div class="hr-align"> <hr /> </div>
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelRelatorioID" runat="server" Text="Label" CssClass="Labels-Item">
                           Relatório: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxRelatorioID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
            </table>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar" CssClass="ContentButton"/>
        </div>
        </div>
      </div>
