<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i86Arquivo.ascx.cs" Inherits="ajuUminho.controls.processos.i86Arquivo" %>

        <div id="ProcessosBox">

            <div class="AlignBox">
                <h3>Lista de processos</h3> <div class="hr-alignMore"> <hr /> </div>
                <asp:ListBox ID="ListBoxProcessosID" runat="server" CssClass="ListBoxProcessos-Item" OnSelectedIndexChanged="ListBoxProcessosID_SelectedIndexChanged1" ></asp:ListBox>
            </div>
                 <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelNomeInsolventeID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome do insolvente: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeInsolventeID" runat="server" CssClass="LabelsInputs-Item" ></asp:TextBox> </td>
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
                  <tr>
                      <td> <asp:Label ID="LabelEstadoID" runat="server" Text="Label" CssClass="Labels-Item">
                            Estado: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxEstadoID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelIdLegalID" runat="server" Text="Label" CssClass="Labels-Item">
                            Id legal: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxIdLegalID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelDataInicioID" runat="server" Text="Label" CssClass="Labels-Item">
                            Data de inicio: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxDataInicioID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                </table>
            
        </div>