<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="contabilidade.ascx.cs" Inherits="ajuUminho.controls.contabilidade" %>

<%-- 6-i --%>

      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <h3>Lista de Elementos Financeiros</h3> <div class="hr-align"> <hr /> </div>

            <table id="table1">
            <tr>
                <th>Elemento financeiro</th>
                <th>Credito reclamado</th>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            </table>

        </div>

        <div class="InsideViewsDetailsBox">
            <h3>Detalhes</h3> <div class="hr-align"> <hr /> </div>
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelElementoFinanceiroID" runat="server" Text="Label" CssClass="Labels-Item">
                           Elemento financeiro: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxElementoFinanceiroID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTipoCreditoReclamadoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Credito reclamado: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTipoCreditoReclamadoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
            </table>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar" CssClass="ContentButton"/>
        </div>
      </div>
