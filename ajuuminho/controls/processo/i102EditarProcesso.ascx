<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i102EditarProcesso.ascx.cs" Inherits="ajuUminho.controls.processo.i102EditarProcesso" %>
<%@ Register TagPrefix="uc2" TagName="i60Eventos" Src="~/controls/processo/i60Eventos.ascx" %>
<%@ Register TagPrefix="uc3" TagName="i64Bens" Src="~/controls/processo/i64Bens.ascx" %>
<%@ Register TagPrefix="uc4" TagName="i68MovimentosFinanceiros" Src="~/controls/processo/i68MovimentosFinanceiros.ascx" %>
<%@ Register TagPrefix="uc5" TagName="i72Credores" Src="~/controls/processo/i72Credores.ascx" %>
<%@ Register TagPrefix="uc6" TagName="i75ServicosExternos" Src="~/controls/processo/i75ServicosExternos.ascx" %>
<%@ Register TagPrefix="uc7" TagName="i80FicheirosMultimedia" Src="~/controls/processo/i80FicheirosMultimedia.ascx" %>
<%@ Register TagPrefix="uc8" TagName="i83FicheirosTexto" Src="~/controls/processo/i83FicheirosTexto.ascx" %>
<%@ Register TagPrefix="uc9" TagName="i91CreditosReclamados" Src="~/controls/processo/i91CreditosReclamados.ascx" %>
<%@ Register TagPrefix="uc10" TagName="i86Arquivo" Src="~/controls/processo/i86Arquivo.ascx" %>
<%@ Register TagPrefix="uc11" TagName="i56AtribuicaoEntidades" Src="~/controls/processo/i56AtribuicaoEntidades.ascx" %>
<%@ Register TagPrefix="uc12" TagName="i89Tipos" Src="~/controls/processo/i89Tipos.ascx" %>
<%@ Register TagPrefix="uc15" TagName="i103DadosBase" Src="~/controls/processo/i103DadosBase.ascx" %>

<div class="ViewsBox">

  <div id="ProcessosBox">
    <div class="AlignBox">
        <div class="titleh3">
            <h3>Lista de processos</h3>
        </div>
        <asp:ListBox ID="ListBoxProcessosID" runat="server" CssClass="ListBoxProcessos-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxProcessosID_SelectedIndexChanged"></asp:ListBox>
    </div>
  </div>

    <%-- 2ª multiview --%>
    <div class="ViewsButtonsBox">
        <asp:Button Text="Dados Base" BorderStyle="None" ID="TabDadosBaseID" CssClass="Initial" runat="server"
            OnClick="TabDadosBase_Click" />
        <asp:Button Text="Entidades" BorderStyle="None" ID="TabEntidadesID" CssClass="Initial" runat="server"
            OnClick="TabEntidades_Click" />
        <asp:Button Text="Credores" BorderStyle="None" ID="TabCredoresID" CssClass="Initial" runat="server"
            OnClick="TabCredores_Click" />
        <asp:Button Text="Arquivo" BorderStyle="None" ID="TabArquivoID" CssClass="Initial" runat="server"
            OnClick="TabArquivo_Click" />
        <asp:Button Text="Eventos" BorderStyle="None" ID="TabEventosID" CssClass="Initial" runat="server"
            OnClick="TabEventos_Click" />
        <asp:Button Text="Bens" BorderStyle="None" ID="TabBensID" CssClass="Initial" runat="server"
            OnClick="TabBens_Click" />
        <asp:Button Text="Movimentos financeiros" BorderStyle="None" ID="TabMovimentosFinanceirosID" CssClass="Initial" runat="server"
            OnClick="TabMovimentosFinanceiros_Click" />
        <asp:Button Text="Serviços externos" BorderStyle="None" ID="TabServicosExternosID" CssClass="Initial" runat="server"
            OnClick="TabServicosExternos_Click" />
        <asp:Button Text="Ficheiros multimédia" BorderStyle="None" ID="TabFicheirosMultimediaID" CssClass="Initial" runat="server"
            OnClick="TabFicheirosMultimedia_Click" />
        <asp:Button Text="Ficheiros texto" BorderStyle="None" ID="TabFicheirosTextoID" CssClass="Initial" runat="server"
            OnClick="TabFicheirosTexto_Click" />
    </div>

    <asp:MultiView ID="MainViewID1" runat="server">
        <asp:View ID="ViewDadosBaseID" runat="server">
            <div class="ViewBoxCRUD">
                <uc15:i103DadosBase runat="server" ID="dadosBaseID" />
            </div>
        </asp:View>
        <asp:View ID="ViewEntidadesID" runat="server">
            <div class="ViewBoxCRUD">
                <uc11:i56AtribuicaoEntidades runat="server" ID="atribuicaoEntidadesID" />
            </div>
        </asp:View>
        <asp:View ID="ViewCredoresID" runat="server">
            <div class="ViewBoxCRUD">
                <uc5:i72Credores runat="server" ID="credoresID" />
            </div>
        </asp:View>
        <asp:View ID="ViewArquivoID" runat="server">
            <div class="ViewBoxCRUD">
                <uc10:i86Arquivo runat="server" ID="i86ArquivoID" />
            </div>
        </asp:View>
        <asp:View ID="ViewEventosID" runat="server">
            <div class="ViewBoxCRUD">
                <uc2:i60Eventos runat="server" ID="eventosID" />
            </div>
        </asp:View>
        <asp:View ID="ViewBensID" runat="server">
            <div class="ViewBoxCRUD">
                <uc3:i64Bens runat="server" ID="bensID" />
            </div>
        </asp:View>
        <asp:View ID="ViewMovimentosFinanceirosID" runat="server">
            <div class="ViewBoxCRUD">
                <uc4:i68MovimentosFinanceiros runat="server" ID="movimentosFinanceirosID" />
            </div>
        </asp:View>
        <asp:View ID="ViewServicosExternosID" runat="server">
            <div class="ViewBoxCRUD">
                <uc6:i75ServicosExternos runat="server" ID="servicosExternosID" />
            </div>
        </asp:View>
        <asp:View ID="ViewFicheirosMultimediaID" runat="server">
            <div class="ViewBoxCRUD">
                <uc7:i80FicheirosMultimedia runat="server" ID="ficheirosMultimediaID" controlpageload="false"  />
            </div>
        </asp:View>
        <asp:View ID="ViewFicheirosTextoID" runat="server">
            <div class="ViewBoxCRUD">
                <uc8:i83FicheirosTexto runat="server" ID="ficheirosTextoID" />
            </div>
        </asp:View>
    </asp:MultiView>

</div>
