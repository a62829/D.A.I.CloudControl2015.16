§<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceProcesso.aspx.cs" Inherits="ajuUminho.webforms.InterfaceProcesso" %>
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
        
        <uc10:i86Arquivo runat="server" id="i86Arquivo" />

        <div id="MultiViewBox">


            <div id="page-wrap">
            	<div id="example-two">
		
		<ul class="nav">
			<li class="nav-one"><a href="#Eventos" class="current">Eventos</a></li>
			<li class="nav-two"><a href="#Bens">Bens</a></li>
			<li class="nav-three"><a href="#MovimentosFinanceiros">Movimentos Financeiros</a></li>
            <li class="nav-three"><a href="#Credores">Credores</a></li>
			<li class="nav-three"><a href="#ServicosExternos">Serviços Externos</a></li>
			<li class="nav-four"><a href="#FicheirosMultimédia">Ficheiros Multimédia</a></li>
            <li class="nav-five"><a href="#FicheirosTexto">Ficheiros Texto</a></li>
            <li class="nav-six"><a href="#CreditosReclamados">Créditos Reclamados</a></li>
            <li class="nav-seven last"><a href="#AtribuicaoEntidades">Atribuição Entidades</a></li>
		</ul>
		
		<div class="list-wrap">
		
		<ul id="Eventos">
			<li>
                <uc2:i60Eventos runat="server" ID="I60Eventos1" />
			</li>
		</ul>
		
		<ul id="Bens" class="hide">
			<li>
                <uc3:i64Bens runat="server" id="I64Bens1" />
			</li>
		</ul>
		
		<ul id="MovimentosFinanceiros" class="hide">
			<li>
                <uc4:i68MovimentosFinanceiros runat="server" id="I68MovimentosFinanceiros1" />
			</li>
		</ul>
		
        <ul id="Credores" class="hide">
			<li>
               <uc5:i72Credores runat="server" id="I72Credores1" /> 
			</li>
		</ul>

        <ul id="ServicosExternos" class="hide">
			<li>
                <uc6:i75ServicosExternos runat="server" id="I75ServicosExternos1" />
			</li>
		</ul>

		<ul id="FicheirosMultimédia" class="hide">
			<li>
                <uc7:i80FicheirosMultimedia runat="server" id="I80FicheirosMultimedia1" />
			</li>
		</ul>

        <ul id="FicheirosTexto" class="hide">
			<li>
                <uc8:i83FicheirosTexto runat="server" id="I83FicheirosTexto1" />
			</li>
		</ul>

        <ul id="CreditosReclamados" class="hide">
			<li>
                <uc9:i91CreditosReclamados runat="server" id="I91CreditosReclamados1" />
			</li>
		</ul>

        <ul id="AtribuicaoEntidades" class="hide">
			<li>
                <uc11:i56AtribuicaoEntidades runat="server" id="I56AtribuicaoEntidades1" />
			</li>
		</ul>

		</div>
		</div> <!-- END List Wrap -->
        </div>          

<%--            <div id="MultiViewButtonsBox">
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
