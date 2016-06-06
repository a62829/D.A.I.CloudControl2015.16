<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTeste3.aspx.cs" Inherits="ajuUminho.WebFormTeste3" %>
<%@ Register TagPrefix="uc2" TagName="i22RepresentanteLegal" Src="~/controls/entidades/i22RepresentanteLegal.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="UTF-8"/>
	
	<title>Organic Tabs (with Replace State)</title>
    <link rel="stylesheet" href="css/StyleSheet.css"/>
	<link rel="stylesheet" href="css/styleTiny.css"/>
	

<script src="http://code.jquery.com/jquery-1.12.4.min.js"></script>
<script src="js/jquery.organictabs.js"></script>
    <script>
        $(function() {
    
            $("#example-one").organicTabs();
            
            $("#example").organicTabs({
                "speed": 200
            });
    
        });
    </script>
</head>

<body>

	<div id="container">
        <form id="Form" runat="server">

	     <div id="example">
					
    		<ul class="nav">
                <li class="nav-one"><a href="#tab-1" class="current">Featured</a></li>
                <li class="nav-two"><a href="#tab-2">Core</a></li>
                <li class="nav-three"><a href="#tab-3">jQuery</a></li>
                <li class="nav-four last"><a href="#tab-4">Classics</a></li>
            </ul>
    		
    		<div class="content-wrap">
    		
    			
        		 
        	<div id="tab-1">
            <ul class="nav">
                <li class="nav-one"><a href="#tab-5" class="current">Criar</a></li>
                <li class="nav-two"><a href="#tab-6">Editar</a></li>
                <li class="nav-three"><a href="#tab-7">Eliminar</a></li>
                <li class="nav-four last"><a href="#tab-8">Pesquisar</a></li>
            </ul>
            </div>


            <div id="tab-2" class="hide">   

            </div>


            <div id="tab-3" class="hide">
 
            </div>	 
        		
                 
            <div id="tab-4" class="hide">
 
            </div>	    		 
        		
                 
            <div id="tab-5" class="hide">
                <div id="tab-1">
                <ul class="nav">
                    <li class="nav-one"><a href="#tab-5" class="current">Criar</a></li>
                    <li class="nav-two"><a href="#tab-6">Editar</a></li>
                    <li class="nav-three"><a href="#tab-7">Eliminar</a></li>
                    <li class="nav-four last"><a href="#tab-8">Pesquisar</a></li>
                </ul>
                </div>
                
                <uc2:i22RepresentanteLegal runat="server" ID="I60RepresentanteLegal1" />

            </div>	        		 
        		 

            <div id="tab-6" class="hide">
 
            </div>	  


            <div id="tab-7" class="hide">
 
            </div>	  

            <div id="tab-8" class="hide">
 
            </div>	  


    		 </div> 
		 
		 </div> 
	
	
	  </form>
	</div>
	
</body>
<script type="text/javascript">

  var _gaq = _gaq || [];
  _gaq.push(['_setAccount', 'UA-36251023-1']);
  _gaq.push(['_setDomainName', 'jqueryscript.net']);
  _gaq.push(['_trackPageview']);

  (function() {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
  })();

</script>
</html>