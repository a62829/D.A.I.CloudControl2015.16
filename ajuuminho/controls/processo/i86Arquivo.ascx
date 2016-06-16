<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i86Arquivo.ascx.cs" Inherits="ajuUminho.controls.processos.i86Arquivo" %>
<%@ Register TagPrefix="uc15" TagName="i103DadosBase" Src="~/controls/processo/i103DadosBase.ascx" %>

<div class="ViewsButtonsBox2">
    <asp:Button Text="Suspender processo" BorderStyle="None" ID="TabSuspenderProcessoID" CssClass="Initial" runat="server"
        OnClick="TabSuspenderProcesso_Click" />
    <asp:Button Text="Arquivar processo" BorderStyle="None" ID="TabArquivarProcessoID" CssClass="Initial" runat="server"
        OnClick="TabArquivarProcesso_Click"/>
    <asp:Button Text="Reativar processo" BorderStyle="None" ID="TabReativarProcessoID" CssClass="Initial" runat="server"
        OnClick="TabReativarProcesso_Click" />
</div>

<div class="ViewsBox3" runat="server" id="HideContenteDive" visible="false">

<div class="InsideViewsTableBox" runat="server" id="ContentListBox" visible="false">
    <div class="titleh4big">
        <h4>Lista de processos arquivados</h4>
    </div>
    <div class="ListBoxParaTabsProcessos">
        <asp:ListBox ID="ListBoxParaTabsProcessosID" CssClass="ListBoxParaTabsProcessos-Item" runat="server"></asp:ListBox>
    </div>
</div>


<div class="InsideViewsDetailsBox" runat="server" id="ContentDetailsBox" visible="false">
    
    <div class="titleh4big" runat="server" id="DetailsTitleBox" visible="false" >
        <h4>Detalhes do processo aquivado</h4>
    </div>

        <table class="ContentTable">
            <tr>
                <td>
                    <asp:Label ID="LabelIdLegalID" runat="server" Text="Label" CssClass="Labels-Item">
                          Número processo: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxIdLegalID" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelIdEstadoID" runat="server" Text="Label" CssClass="Labels-Item">
                           Estado: </asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListIdEstadoID" runat="server" Enabled="false"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelIdTipoProcessoID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Tipo processo: </asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListIdTipoProcessoID" runat="server" Enabled="false"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="Labels-Item">
                         Data inicio: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="Labels-Item">
                          Nome insolvente: </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="LabelsInputs-Item" Enabled="false"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>

    <div id="ContentButtonsBox">
        <asp:Button ID="ButtonSuspenderID" runat="server" Text="Suspender" CssClass="ContentButton" Visible="false" />
        <asp:Button ID="ButtonArquivarID" runat="server" Text="Arquivar" CssClass="ContentButton" Visible="false" />
        <asp:Button ID="ButtonReativarID" runat="server" Text="Reativar" CssClass="ContentButton" Visible="false" />
    </div>


    <%--                                <asp:MultiView ID="MainViewID2" runat="server">
                                    <asp:View ID="ViewSuspenderProcessoID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            

                                            Suspender


                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewArquivarProcessoID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            

                                            Arquivar


                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewReativarProcessoID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            


                                            Reativar

                                        </div>
                                    </asp:View>
                                </asp:MultiView>--%>
</div>










<%--<div id="ProcessosBox">

            <div class="AlignBox">
                 <div class="titleh3"> <h3>Lista de processos</h3> </div>
                <asp:ListBox ID="ListBoxProcessosID" runat="server" CssClass="ListBoxProcessos-Item"></asp:ListBox>
            </div>
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
            
        </div>--%>