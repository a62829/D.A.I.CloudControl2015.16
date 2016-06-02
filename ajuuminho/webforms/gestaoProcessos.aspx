<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestaoProcessos.aspx.cs" Inherits="ajuUminho.webforms.gestaoProcessos" %>
<%@ Register TagPrefix="uc1" TagName="header" Src="~/controls/header.ascx"%>
<%@ Register TagPrefix="uc2" TagName="dadosGerais" Src="~/controls/dadosGerais.ascx"%>
<%@ Register TagPrefix="uc3" TagName="contabilidade" Src="~/controls/contabilidade.ascx"%>
<%@ Register TagPrefix="uc4" TagName="credores" Src="~/controls/credores.ascx"%>
<%@ Register TagPrefix="uc5" TagName="anexos" Src="~/controls/anexos.ascx"%>
<%@ Register TagPrefix="uc6" TagName="relatorios" Src="~/controls/relatorios.ascx"%>
<%@ Register TagPrefix="uc7" TagName="eventos" Src="~/controls/eventos.ascx"%>
<%@ Register TagPrefix="uc8" TagName="servicosExternos" Src="~/controls/servicosExternos.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>

<body>
    <form id="Form" runat="server">
    <uc1:header runat="server" ID="headerID" />
    <div id="BigBox">

        <div id="ProcessosBox">
            <div class="AlignBox">
                <h3>Lista de processos existentes</h3> <div class="hr-alignMore"> <hr /> </div>
                <asp:ListBox ID="ListBoxProcessosID" runat="server" CssClass="ListBoxProcessos-Item"></asp:ListBox>
            </div>
        </div>

        <div id="MultiViewBox">

            <div id="MultiViewButtonsBox">
                <asp:Button Text="Dados Gerais" BorderStyle="None" ID="TabDadosGeraisID" CssClass="Initial" runat="server"
                    OnClick="TabDadosGerais_Click" />
                <asp:Button Text="Contabilidade" BorderStyle="None" ID="TabContabilidadeID" CssClass="Initial" runat="server"
                    OnClick="TabContabilidade_Click" />
                <asp:Button Text="Credores" BorderStyle="None" ID="TabCredoresID" CssClass="Initial" runat="server"
                    OnClick="TabCredores_Click" />
                <asp:Button Text="Anexos" BorderStyle="None" ID="TabAnexosID" CssClass="Initial" runat="server"
                    OnClick="TabAnexos_Click" />
                <asp:Button Text="Relatórios" BorderStyle="None" ID="TabRelatoriosID" CssClass="Initial" runat="server"
                    OnClick="TabRelatorios_Click" />
                <asp:Button Text="Eventos" BorderStyle="None" ID="TabEventosID" CssClass="Initial" runat="server"
                    OnClick="TabEventos_Click" />
                <asp:Button Text="Serviços Externos" BorderStyle="None" ID="TabServicosExternosID" CssClass="Initial" runat="server"
                    OnClick="TabServicosExternos_Click" />
            </div>

                <asp:MultiView ID="MainViewID" runat="server">
                    <asp:View ID="ViewDadosGeraisID" runat="server">
                        <div class="ViewsBox">
                            <uc2:dadosGerais runat="server" ID="dadosGeraisID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewContabilidadeID" runat="server">
                       <div class="ViewsBox">
                           <uc3:contabilidade runat="server" id="contabilidadeID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewCredoresID" runat="server">
                        <div class="ViewsBox">
                            <uc4:credores runat="server" id="credores" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewAnexosID" runat="server">
                        <div class="ViewsBox">
                            <uc5:anexos runat="server" id="anexos" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewRelatoriosID" runat="server">
                        <div class="ViewsBox">
                            <uc6:relatorios runat="server" id="relatorios" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewEventosID" runat="server">
                        <div class="ViewsBox">
                            <uc7:eventos runat="server" id="eventosID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewServicosExternosID" runat="server">
                        <div class="ViewsBox">
                            <uc8:servicosExternos runat="server" id="servicosExternos" />
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
