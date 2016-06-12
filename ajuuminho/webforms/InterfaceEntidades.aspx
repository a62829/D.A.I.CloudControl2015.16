<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceEntidades.aspx.cs" Inherits="ajuUminho.webforms.InterfaceEntidades" %>
<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx"%>
<%@ Register TagPrefix="uc2" TagName="i22RepresentanteLegal" Src="~/controls/entidades/i22RepresentanteLegal.ascx"%>
<%@ Register TagPrefix="uc3" TagName="i26AdministradoresJudiciais" Src="~/controls/entidades/i26AdministradoresJudiciais.ascx"%>
<%@ Register TagPrefix="uc4" TagName="i30Tribunais" Src="~/controls/entidades/i30Tribunais.ascx"%>
<%@ Register TagPrefix="uc5" TagName="i34Juizes" Src="~/controls/entidades/i34Juizes.ascx"%>
<%@ Register TagPrefix="uc6" TagName="i38Credores" Src="~/controls/entidades/i38Credores.ascx"%>
<%@ Register TagPrefix="uc7" TagName="i42Insolventes" Src="~/controls/entidades/i42Insolventes.ascx"%>
<%@ Register TagPrefix="uc8" TagName="i46Contabilistas" Src="~/controls/entidades/i46Contabilistas.ascx"%>
<%@ Register TagPrefix="uc9" TagName="i50PrestadoresServico" Src="~/controls/entidades/i50PrestadoresServico.ascx"%>
<%@ Register TagPrefix="uc10" TagName="i54OutrasEntidades" Src="~/controls/entidades/i54OutrasEntidades.ascx"%>


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
            <div class="AlignBox">
                <h3>Gestão de entidades</h3> <div class="hr-alignMore"> <hr /> </div>
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
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div id="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="ButtonCriar" CssClass="Initial" runat="server"
                                    OnClick="TabCriarRepresentanteLegal_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="ButtonEditar" CssClass="Initial" runat="server"
                                     OnClick="TabEditarRepresentanteLegal_Click" />

                                <asp:MultiView ID="MultiViewID2" runat="server">
                                    <asp:View ID="ViewCriarRepresentanteLegal" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc2:i22RepresentanteLegal runat="server" ID="representanteLegalID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarRepresentanteLegal" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc2:i22RepresentanteLegal runat="server" ID="I22RepresentanteLegalID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>
                            </div>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewAdministradoresJudiciaisID" runat="server">
                       <div class="ViewsBox">
                           <uc3:i26AdministradoresJudiciais runat="server" id="administradoresJudiciaisID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewTribunaisID" runat="server">
                        <div class="ViewsBox">
                            <uc4:i30Tribunais runat="server" id="tribunaisID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewJuizesID" runat="server">
                        <div class="ViewsBox">
                            <uc5:i34Juizes runat="server" id="juizesID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewCredoresID" runat="server">
                        <div class="ViewsBox">
                            <uc6:i38Credores runat="server" id="credoresID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewInsolventesID" runat="server">
                        <div class="ViewsBox">
                            <uc7:i42Insolventes runat="server" id="insolventesID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewContabilistasID" runat="server">
                        <div class="ViewsBox">
                            <uc8:i46Contabilistas runat="server" id="contabilistasID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewPrestadoresServicoID" runat="server">
                        <div class="ViewsBox">
                            <uc9:i50PrestadoresServico runat="server" id="prestadoresServicoID" />
                        </div>
                    </asp:View>
                    <asp:View ID="ViewOutrasEntidadesID" runat="server">
                        <div class="ViewsBox">
                            <uc10:i54OutrasEntidades runat="server" id="outrasEntidadesID" />
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
