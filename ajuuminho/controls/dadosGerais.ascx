<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dadosGerais.ascx.cs" Inherits="ajuUminho.controls.dadosGerais" %>

<%-- 6-i --%>

      <div class="InsideViewsBox">

        <h3>Detalhes do Processo</h3> <div class="hr-align"> <hr /> </div>

        <div class="InsideViewsTableBox">

            <table id="table1">
            <tr>
                <th>Estado</th>
                <th>Id Legal</th>
                <th>Data Inicio</th> 
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
<%--            <h3>  </h3> <div class="hr-align"> <hr /> </div>--%>
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelNomeInsolventeID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome do insolvente: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeInsolventeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelNomeProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Nome do processo: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeProcessoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelNomeTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome do tipo de processo: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeTipoProcessoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelWorkflowID" runat="server" Text="Label" CssClass="Labels-Item">
                            Workflow: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxWorkflowID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
            </table>
          </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonGuardarID" runat="server" Text="Guardar" CssClass="ContentButton"/>
        </div>
      </div>