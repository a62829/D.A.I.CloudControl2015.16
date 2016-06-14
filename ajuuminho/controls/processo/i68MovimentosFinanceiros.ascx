<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i68MovimentosFinanceiros.ascx.cs" Inherits="ajuUminho.controls.processos.i68MovimentosFinanceiros" %>

      <div class="InsideViewsBox">
        <div class="InsideViewsTableBox">
            <div class="titleh4big"> <h4>Lista de Elementos Financeiros</h4> </div>

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
            <div class="titleh4big"> <h3>Detalhes</h3> </div>
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
