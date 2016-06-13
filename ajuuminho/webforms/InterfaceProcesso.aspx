<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceProcesso.aspx.cs" Inherits="ajuUminho.webforms.InterfaceProcesso" %>
<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx"%>
<%@ Register TagPrefix="uc2" TagName="i60Eventos" Src="~/controls/processo/i60Eventos.ascx"%>
<%@ Register TagPrefix="uc3" TagName="i64Bens" Src="~/controls/processo/i64Bens.ascx"%>
<%@ Register TagPrefix="uc4" TagName="i68MovimentosFinanceiros" Src="~/controls/processo/i68MovimentosFinanceiros.ascx"%>
<%@ Register TagPrefix="uc5" TagName="i72Credores" Src="~/controls/processo/i72Credores.ascx"%>
<%@ Register TagPrefix="uc6" TagName="i75ServicosExternos" Src="~/controls/processo/i75ServicosExternos.ascx"%>
<%@ Register TagPrefix="uc7" TagName="i80FicheirosMultimedia" Src="~/controls/processo/i80FicheirosMultimedia.ascx"%>
<%@ Register TagPrefix="uc8" TagName="i83FicheirosTexto" Src="~/controls/processo/i83FicheirosTexto.ascx"%>
<%@ Register TagPrefix="uc9" TagName="i91CreditosReclamados" Src="~/controls/processo/i91CreditosReclamados.ascx"%>
<%@ Register TagPrefix="uc10" TagName="i86Arquivo" Src="~/controls/processo/i86Arquivo.ascx"%>
<%@ Register TagPrefix="uc11" TagName="i56AtribuicaoEntidades" Src="~/controls/processo/i56AtribuicaoEntidades.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>

</head>

<body>
    <form id="Form" runat="server">
        <uc1:i14TerminoDeSessao runat="server" ID="headerID" />
    <div id="BigBox">

        <uc10:i86Arquivo runat="server" id="i86Arquivo" />

        <div id="MultiViewBox">

            <div id="MultiViewButtonsBox">
                <asp:Button Text="Eventos" BorderStyle="None" ID="TabEventosID" CssClass="Initial" runat="server"
                    OnClick="TabEventos_Click" />
                <asp:Button Text="Bens" BorderStyle="None" ID="TabBensID" CssClass="Initial" runat="server"
                    OnClick="TabBens_Click" />
                <asp:Button Text="Movimentos Financeiros" BorderStyle="None" ID="TabMovimentosFinanceirosID" CssClass="Initial" runat="server"
                    OnClick="TabMovimentosFinanceiros_Click" />
                <asp:Button Text="Credores" BorderStyle="None" ID="TabCredoresID" CssClass="Initial" runat="server"
                    OnClick="TabCredores_Click" />
                <asp:Button Text="Serviços Externos" BorderStyle="None" ID="TabServicosExternosID" CssClass="Initial" runat="server"
                    OnClick="TabServicosExternos_Click" />
                <asp:Button Text="Ficheiros Multimédia" BorderStyle="None" ID="TabFicheirosMultimediaID" CssClass="Initial" runat="server"
                    OnClick="TabFicheirosMultimedia_Click" />
                <asp:Button Text="Ficheiros Texto" BorderStyle="None" ID="TabFicheirosTextoID" CssClass="Initial" runat="server"
                    OnClick="TabFicheirosTexto_Click" />
                <asp:Button Text="Créditos Reclamados" BorderStyle="None" ID="TabCreditosReclamadosID" CssClass="Initial" runat="server"
                    OnClick="TabCreditosReclamados_Click" />
                <asp:Button Text="Atribuição Entidades" BorderStyle="None" ID="TabAtribuicaoEntidadesID" CssClass="Initial" runat="server"
                    OnClick="TabAtribuicaoEntidades_Click" />
            </div>

                <asp:MultiView ID="MainViewID" runat="server">
                    <asp:View ID="ViewEventosID" runat="server">
                        <div class="ViewsBox">
                            <uc2:i60Eventos runat="server" ID="eventosID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewBensID" runat="server">
                       <div class="ViewsBox">
                           <uc3:i64Bens runat="server" id="bensID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewMovimentosFinanceirosID" runat="server">
                        <div class="ViewsBox">
                            <uc4:i68MovimentosFinanceiros runat="server" id="movimentosFinanceirosID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewCredoresID" runat="server">
                        <div class="ViewsBox">
                            <uc5:i72Credores runat="server" id="credoresID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewServicosExternosID" runat="server">
                        <div class="ViewsBox">
                            <uc6:i75ServicosExternos runat="server" id="servicosExternosID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewFicheirosMultimediaID" runat="server">
                        <div class="ViewsBox">
                            <uc7:i80FicheirosMultimedia runat="server" id="ficheirosMultimediaID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewFicheirosTextoID" runat="server">
                        <div class="ViewsBox">
                            <uc8:i83FicheirosTexto runat="server" id="ficheirosTextoID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewCreditosReclamadosID" runat="server">
                        <div class="ViewsBox">
                            <uc9:i91CreditosReclamados runat="server" id="creditosReclamadosID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewAtribuicaoEntidadesID" runat="server">
                        <div class="ViewsBox">
                            <uc11:i56AtribuicaoEntidades runat="server" id="atribuicaoEntidadesID" />
                        </div>
                    </asp:View>
                 </asp:MultiView>

    </div>
</div>
    </form>
        <div id="FooterBox">
            <div id="FooterBox2">
                <% 
                    Response.WriteFile("../html/footer.html");
                %>
            </div>
        </div>
    
</body>
</html>
