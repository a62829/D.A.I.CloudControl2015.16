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
	<link rel="stylesheet" href="../css/style.css"/>
	<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js'></script>
	<script src="../js/organictabs.jquery.js"></script>
	<script>
		$(function() {
		
			// Calling the plugin
			$("#example-two").organicTabs({
				"speed": 300, //+ speed = + lento
				"param": "tab"
			});
			
		});
	</script>
</head>

<body>
    <form id="Form" runat="server">
        <uc1:i14TerminoDeSessao runat="server" ID="headerID" />
    
        <div id="BigBox">
            <div class="AlignBox">
                <h3>Gestão de entidades</h3> <div class="hr-alignMore"> <hr /> </div>
            </div>

<%--        <div id="MultiViewBox">--%>

                        <div id="page-wrap">
            	<div id="example-two">
		
		<ul class="nav">
			<li class="nav-one" runat="server" onclick="mostrar_operacoes"><a href="#RepresentanteLegal">Representante Legal</a></li>
			<li class="nav-two"><a href="#AdministradoresJudiciais">Administrador Judicial</a></li>
			<li class="nav-three"><a href="#Tribunais">Tribunal</a></li>
            <li class="nav-three"><a href="#Credores">Credores</a></li>
			<li class="nav-three"><a href="#Juizes">Juiz</a></li>
			<li class="nav-four"><a href="#Credores">Credor</a></li>
            <li class="nav-five"><a href="#Insolventes">Insolvente</a></li>
            <li class="nav-six"><a href="#Contabilistas">Contabilista</a></li>
            <li class="nav-seven"><a href="#PrestadoresServico">Prestador Serviço</a></li>
            <li class="nav-eight last"><a href="#OutrasEntidades">Outra Entdade</a></li>
		</ul>
		
		<div class="list-wrap">
		
		<div id="RepresentanteLegal" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarRepresentanteLegal" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarRepresentanteLegal">Editar</a></li>
                <li class="nav-one"><a href="#EliminarRepresentanteLegal" class="current">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarRepresentanteLegal">Pesquisar??</a></li>
            </ul>
		</div>
		
		<div id="AdministradoresJudiciais" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarAdministradoresJudiciais" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarAdministradoresJudiciais">Editar</a></li>
                <li class="nav-one"><a href="#EliminarAdministradoresJudiciais">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarAdministradoresJudiciais">Pesquisar??</a></li>
            </ul>
		</div>
		
		<div id="Tribunais" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarTribunais" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarTribunais">Editar</a></li>
                <li class="nav-one"><a href="#EliminarTribunais">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarTribunais">Pesquisar??</a></li>
            </ul>
		</div>

        <div id="Juizes" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarJuizes" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarJuizes">Editar</a></li>
                <li class="nav-one"><a href="#EliminarJuizes">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarJuizes">Pesquisar??</a></li>
            </ul>
		</div>

		<div id="Credores" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarCredores" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarCredores">Editar</a></li>
                <li class="nav-one"><a href="#EliminarCredores">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarCredores">Pesquisar??</a></li>
            </ul>
		</div>

        <div id="Insolventes" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarInsolventes" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarInsolventes">Editar</a></li>
                <li class="nav-one"><a href="#EliminarInsolventes">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarInsolventes">Pesquisar??</a></li>
            </ul>
		</div>

        <div id="Contabilistas" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarContabilistas" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarContabilistas">Editar</a></li>
                <li class="nav-one"><a href="#EliminarContabilistas">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarContabilistas">Pesquisar??</a></li>
            </ul>
		</div>

        <div id="PrestadoresServico" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarPrestadoresServico" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarPrestadoresServico">Editar</a></li>
                <li class="nav-one"><a href="#EliminarPrestadoresServico">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarPrestadoresServico">Pesquisar??</a></li>
			</ul>
		</div>

        <div id="OutraEntidade" class="hide">
            <ul class="nav">
                <li class="nav-one"><a href="#CriarOutrasEntidades" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#EditarOutrasEntidades">Editar</a></li>
                <li class="nav-one"><a href="#EliminarOutrasEntidades">Eliminar</a></li>
			    <li class="nav-two"><a href="#PesquisarOutrasEntidades">Pesquisar??</a></li>
			</ul>
		</div>

            <div id="CriarRepresentanteLegal" class="hide">
                <uc2:i22RepresentanteLegal runat="server" ID="I22RepresentanteLegal1" />
            </div>

            <div id="EditarRepresentanteLegal" class="hide">
                <uc2:i22RepresentanteLegal runat="server" ID="I22RepresentanteLegal2" />
            </div>

            <div id="EliminarRepresentanteLegal" class="hide">
                <uc2:i22RepresentanteLegal runat="server" ID="I22RepresentanteLegal3" />
            </div>

            <div id="PesquisarRepresentanteLegal" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarAdministradoresJudiciais" class="hide">
                <uc3:i26AdministradoresJudiciais runat="server" id="I26AdministradoresJudiciais1" />
            </div>
          
            <div id="EditarAdministradoresJudiciais" class="hide">
                <uc3:i26AdministradoresJudiciais runat="server" id="I26AdministradoresJudiciais2" />
            </div>

            <div id="EliminarAdministradoresJudiciais" class="hide">
                <uc3:i26AdministradoresJudiciais runat="server" id="I26AdministradoresJudiciais3" />
            </div>

            <div id="PesquisarAdministradoresJudiciais" class="hide">
                pesquisa
            </div>
             <%--------%>
            <div id="CriarTribunais" class="hide">
                <uc4:i30Tribunais runat="server" id="I30Tribunais1" />
            </div>
          
            <div id="EditarTribunais" class="hide">
                <uc4:i30Tribunais runat="server" id="I30Tribunais2" />
            </div>

            <div id="EliminarTribunais" class="hide">
                <uc4:i30Tribunais runat="server" id="I30Tribunais3" />
            </div>

            <div id="PesquisarTribunais" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarJuizes" class="hide">
                <uc5:i34Juizes runat="server" id="I34Juizes1" />
            </div>
          
            <div id="EditarJuizes" class="hide">
                <uc5:i34Juizes runat="server" id="I34Juizes2" />
            </div>

            <div id="EliminarJuizes" class="hide">
                <uc5:i34Juizes runat="server" id="I34Juizes3" />
            </div>

            <div id="PesquisarJuizes" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarCredores" class="hide">
                <uc6:i38Credores runat="server" id="I38Credores1" />
            </div>
          
            <div id="EditarCredores" class="hide">
                <uc6:i38Credores runat="server" id="I38Credores2" />
            </div>

            <div id="EliminarCredores" class="hide">
                <uc6:i38Credores runat="server" id="I38Credores3" />
            </div>

            <div id="PesquisarCredores" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarInsolventes" class="hide">
                <uc7:i42Insolventes runat="server" ID="i42Insolventes1" />
            </div>
          
            <div id="EditarInsolventes" class="hide">
                <uc7:i42Insolventes runat="server" ID="i42Insolventes2" />
            </div>

            <div id="EliminarInsolventes" class="hide">
                <uc7:i42Insolventes runat="server" ID="i42Insolventes3" />
            </div>

            <div id="PesquisarInsolventes" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarContabilistas" class="hide">
                <uc8:i46Contabilistas runat="server" id="I46Contabilistas1" />
            </div>
          
            <div id="EditarContabilistas" class="hide">
                <uc8:i46Contabilistas runat="server" id="I46Contabilistas2" />
            </div>

            <div id="EliminarContabilistas" class="hide">
                <uc8:i46Contabilistas runat="server" id="I46Contabilistas3" />
            </div>

            <div id="PesquisarContabilistas" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarPrestadoresServico" class="hide">
                <uc9:i50PrestadoresServico runat="server" id="I50PrestadoresServico1" />
            </div>
          
            <div id="EditarPrestadoresServico" class="hide">
                <uc9:i50PrestadoresServico runat="server" id="I50PrestadoresServico2" />
            </div>

            <div id="EliminarPrestadoresServico" class="hide">
                <uc9:i50PrestadoresServico runat="server" id="I50PrestadoresServico3" />
            </div>

            <div id="PesquisarPrestadoresServico" class="hide">
                pesquisa
            </div>
            <%--------%>
            <div id="CriarOutrasEntidades" class="hide">
                <uc10:i54OutrasEntidades runat="server" id="I54OutrasEntidade1" />
            </div>
          
            <div id="EditarOutrasEntidades" class="hide">
                <uc10:i54OutrasEntidades runat="server" id="I54OutrasEntidades2" />
            </div>

            <div id="EliminarOutrasEntidades" class="hide">
                <uc10:i54OutrasEntidades runat="server" id="I54OutrasEntidades3" />
            </div>

            <div id="PesquisarOutrasEntidades" class="hide">
                pesquisa
            </div>



		</div>
		</div> <!-- END List Wrap -->
<%--        </div>  --%> 


            <%--<div id="MultiViewButtonsBox">
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
                            <uc2:i22RepresentanteLegal runat="server" ID="representanteLegalID" />
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
                    </asp:MultiView>--%>

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
