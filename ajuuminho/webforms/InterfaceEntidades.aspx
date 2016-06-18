<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceEntidades.aspx.cs" Inherits="ajuUminho.webforms.InterfaceEntidades" %>

<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx" %>
<%@ Register TagPrefix="uc2" TagName="i22RepresentanteLegal" Src="~/controls/entidades/i22RepresentanteLegal.ascx" %>
<%@ Register TagPrefix="uc3" TagName="i26AdministradoresJudiciais" Src="~/controls/entidades/i26AdministradoresJudiciais.ascx" %>
<%@ Register TagPrefix="uc4" TagName="i30Tribunais" Src="~/controls/entidades/i30Tribunais.ascx" %>
<%@ Register TagPrefix="uc5" TagName="i34Juizes" Src="~/controls/entidades/i34Juizes.ascx" %>
<%@ Register TagPrefix="uc6" TagName="i38Credores" Src="~/controls/entidades/i38Credores.ascx" %>
<%@ Register TagPrefix="uc7" TagName="i42Insolventes" Src="~/controls/entidades/i42Insolventes.ascx" %>
<%@ Register TagPrefix="uc8" TagName="i46Contabilistas" Src="~/controls/entidades/i46Contabilistas.ascx" %>
<%@ Register TagPrefix="uc9" TagName="i50PrestadoresServico" Src="~/controls/entidades/i50PrestadoresServico.ascx" %>
<%@ Register TagPrefix="uc10" TagName="i54OutrasEntidades" Src="~/controls/entidades/i54OutrasEntidades.ascx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8" />
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet" />
    <script src="<%=ResolveUrl("~/scripts/entidadeValida.js")%>" type="text/javascript"></script>
    
    <script src="../scripts/entidadeValida.js" type="text/javascript"></script>
</head>

<body>
    <form id="Form" runat="server">
        <uc1:i14TerminoDeSessao runat="server" ID="headerID" />
        <div id="BigBox">

            <div class="ViewsBoxProcessos">

                <div class="AlignBox">
                    <div class="titleh3">
                        <h3>Gestão de entidades</h3>
                    </div>
                </div>

                <div id="MultiViewBox">

                    <div id="MultiViewButtonsBox">
                        <asp:Button Text="Representante Legal" BorderStyle="None" ID="TabRepresentanteLegalID" CssClass="Initial" runat="server"
                            OnClick="TabRepresentanteLegal_Click" />
                        <asp:Button Text="Administradores Judiciais" BorderStyle="None" ID="TabAdministradoresJudiciaisID" CssClass="Initial" runat="server"
                            OnClick="TabAdministradoresJudiciais_Click" />
                        <asp:Button Text="Tribunais" BorderStyle="None" ID="TabTribunaisID" CssClass="Initial" runat="server"
                            OnClick="TabTribunais_Click" />
                        <asp:Button Text="Juizes" BorderStyle="None" ID="TabJuizesID" CssClass="Initial" runat="server"
                            OnClick="TabJuizes_Click" />
                        <asp:Button Text="Credores" BorderStyle="None" ID="TabCredoresID" CssClass="Initial" runat="server"
                            OnClick="TabCredores_Click" />
                        <asp:Button Text="Insolventes" BorderStyle="None" ID="TabInsolventesID" CssClass="Initial" runat="server"
                            OnClick="TabInsolventes_Click" />
                        <asp:Button Text="Contabilistas" BorderStyle="None" ID="TabContabilistasID" CssClass="Initial" runat="server"
                            OnClick="TabContabilistas_Click" />
                        <asp:Button Text="Prestadores Serviço" BorderStyle="None" ID="TabPrestadoresServicoID" CssClass="Initial" runat="server"
                            OnClick="TabPrestadoresServico_Click" />
                        <asp:Button Text="Outras Entidades" BorderStyle="None" ID="TabOutrasEntidadesID" CssClass="Initial" runat="server"
                            OnClick="TabOutrasEntidades_Click" />
                    </div>

                    <asp:MultiView ID="MainViewID" runat="server">
                        <asp:View ID="ViewRepresentanteLegalID" runat="server">
                            <uc2:i22RepresentanteLegal runat="server" ID="representanteLegalID" />
                        </asp:View>
                        <asp:View ID="ViewAdministradoresJudiciaisID" runat="server">
                            <uc3:i26AdministradoresJudiciais runat="server" ID="administradoresJudiciaisID" />
                        </asp:View>
                        <asp:View ID="ViewTribunaisID" runat="server">
                            <uc4:i30Tribunais runat="server" ID="tribunaisID" />
                        </asp:View>
                        <asp:View ID="ViewJuizesID" runat="server">
                            <uc5:i34Juizes runat="server" ID="juizesID" />
                        </asp:View>
                        <asp:View ID="ViewCredoresID" runat="server">
                            <uc6:i38Credores runat="server" ID="credoresID" />
                        </asp:View>
                        <asp:View ID="ViewInsolventesID" runat="server">
                            <uc7:i42Insolventes runat="server" ID="insolventesID" />
                        </asp:View>
                        <asp:View ID="ViewContabilistasID" runat="server">
                            <uc8:i46Contabilistas runat="server" ID="contabilistasID" />
                        </asp:View>
                        <asp:View ID="ViewPrestadoresServicoID" runat="server">
                            <uc9:i50PrestadoresServico runat="server" ID="prestadoresServicoID" />
                        </asp:View>
                        <asp:View ID="ViewOutrasEntidadesID" runat="server">
                            <uc10:i54OutrasEntidades runat="server" ID="outrasEntidadesID" />
                        </asp:View>
                    </asp:MultiView>
                </div>
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
