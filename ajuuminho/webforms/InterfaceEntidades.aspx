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
                 <div class="titleh3"> <h3>Gestão de entidades</h3> </div>
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
                       <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarAdministradorJudicialID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarAdministradorJudicial_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarAdministradorJudicialID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarAdministradorJudicial_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarAdministradorJudicialID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarAdministradorJudicial_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID2" runat="server">
                                    <asp:View ID="ViewCriarAdministradorJudicialID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc3:i26AdministradoresJudiciais runat="server" id="administradoresJudiciaisID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarAdministradorJudicialID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc3:i26AdministradoresJudiciais runat="server" id="administradoresJudiciaisID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarAdministradorJudicialID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc3:i26AdministradoresJudiciais runat="server" id="administradoresJudiciaisID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewTribunaisID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarTribunalID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarTribunal_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarTribunalID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarTribunal_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarTribunalID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarTribunal_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID3" runat="server">
                                    <asp:View ID="ViewCriarTribunalID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc4:i30Tribunais runat="server" id="tribunaisID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarTribunalID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                             <uc4:i30Tribunais runat="server" id="tribunaisID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarTribunalID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                              <uc4:i30Tribunais runat="server" id="tribunaisID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewJuizesID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarJuizID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarJuiz_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarJuizID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarJuiz_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarJuizID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarJuiz_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID4" runat="server">
                                    <asp:View ID="ViewCriarJuizID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc5:i34Juizes runat="server" id="juizesID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarJuizID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                             <uc5:i34Juizes runat="server" id="juizesID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarJuizID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                              <uc5:i34Juizes runat="server" id="juizesID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewCredoresID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarCredorID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarCredor_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarCredorID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarCredor_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarCredorID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarCredor_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID5" runat="server">
                                    <asp:View ID="ViewCriarCredorID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc6:i38Credores runat="server" id="credoresID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarCredorID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc6:i38Credores runat="server" id="credoresID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarCredorID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc6:i38Credores runat="server" id="credoresID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewInsolventesID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarInsolventeID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarInsolvente_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarInsolventeID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarInsolvente_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarInsolventeID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarInsolvente_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID6" runat="server">
                                    <asp:View ID="ViewCriarInsolventeID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc7:i42Insolventes runat="server" id="insolventesID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarInsolventeID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc7:i42Insolventes runat="server" id="insolventesID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarInsolventeID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc7:i42Insolventes runat="server" id="insolventesID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewContabilistasID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarContabilistaID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarContabilista_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarContabilistaID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarContabilista_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarContabilistaID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarContabilista_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID7" runat="server">
                                    <asp:View ID="ViewCriarContabilistaID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc8:i46Contabilistas runat="server" id="contabilistasID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarContabilistaID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc8:i46Contabilistas runat="server" id="contabilistasID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarContabilistaID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc8:i46Contabilistas runat="server" id="contabilistasID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewPrestadoresServicoID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarPrestadorServicoID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarPrestadorServico_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarPrestadorServicoID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarPrestadorServico_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarPrestadorServicoID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarPrestadorServico_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID8" runat="server">
                                    <asp:View ID="ViewCriarPrestadorServicoID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc9:i50PrestadoresServico runat="server" id="prestadoresServicoID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarPrestadorServicoID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc9:i50PrestadoresServico runat="server" id="prestadoresServicoID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarPrestadorServicoID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc9:i50PrestadoresServico runat="server" id="prestadoresServicoID2" />
                                        </div>
                                    </asp:View>
                                </asp:MultiView>

                        </div>
                    </asp:View>
                    <asp:View ID="ViewOutrasEntidadesID" runat="server">
                        <div class="ViewsBox">

                            <%-- 2ª multiview --%>
                            <div class="ViewsButtonsBox">
                                <asp:Button Text="Criar" BorderStyle="None" ID="TabCriarOutraEntidadeID" CssClass="Initial" runat="server"
                                    OnClick="TabCriarOutraEntidade_Click" />
                                <asp:Button Text="Editar" BorderStyle="None" ID="TabEditarOutraEntidadeID" CssClass="Initial" runat="server"
                                     OnClick="TabEditarOutraEntidade_Click" />
                                <asp:Button Text="Eliminar" BorderStyle="None" ID="TabEliminarOutraEntidadeID" CssClass="Initial" runat="server"
                                     OnClick="TabEliminarOutraEntidade_Click" />
                            </div>

                                <asp:MultiView ID="MainViewID9" runat="server">
                                    <asp:View ID="ViewCriarOutraEntidadeID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc10:i54OutrasEntidades runat="server" id="outrasEntidadesID" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEditarOutraEntidadeID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc10:i54OutrasEntidades runat="server" id="outrasEntidadesID1" />
                                        </div>
                                    </asp:View>
                                    <asp:View ID="ViewEliminarOutraEntidadeID" runat="server"> 
                                        <div class ="ViewBoxCRUD">
                                            <uc10:i54OutrasEntidades runat="server" id="outrasEntidadesID2" />
                                        </div>
                                    </asp:View>
                               </asp:MultiView>
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
