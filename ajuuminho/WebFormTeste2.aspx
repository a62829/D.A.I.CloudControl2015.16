<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTeste2.aspx.cs" Inherits="ajuUminho.WebFormTeste2" %>
<%@ Register TagPrefix="uc2" TagName="i22RepresentanteLegal" Src="~/controls/entidades/i22RepresentanteLegal.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="UTF-8"/>
	
	<title>Organic Tabs (with Replace State)</title>
    <link rel="stylesheet" href="css/StyleSheet.css"/>
	<link rel="stylesheet" href="css/styleTeste.css"/>
	
	<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js'></script>
	<script src="js/organictabs.jquery.js"></script>

	<script>
	    $(function () {
	        // Calling the plugin
	        $("#example-two").organicTabs({
	            "speed": 300, //+ speed = + lento
	            "param": "tab"
	        });

	    });
	</script>

</head>

<body>

<div id="BigBox">

	<form id="Form" runat="server">

	    <div id="example-two">
		
        <%--<div class="titles">--%>
    		<ul class="nav">
                <li class="nav-one"><a href="#tab-1">Featured</a></li>
                <li class="nav-two"><a href="#tab-2">Core</a></li>
                <li class="nav-three"><a href="#tab-3">jQuery</a></li>
                <li class="nav-four last"><a href="#tab-4">Classics</a></li>
            </ul>

                   
		<div class="list-wrap">
		
            <div id="tab-1" class="hide">
                <ul class="nav" >
                <li class="nav-one"><a href="#Criar">Criar</a></li>
			    <li class="nav-two"><a href="#Editar">Editar</a></li>
                </ul>
            </div>

            <div id="tab-2" class="hide">
                <ul class="nav">
                <li class="nav-one"><a href="#Criar" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#Editar">Editar</a></li>
                </ul>
            </div>

             <div id="Criar" class="hide">
                 <uc2:i22RepresentanteLegal runat="server" ID="I60RepresentanteLegal1" />
            </div>

             <div id="Editar" class="hide">
                 kasdkjadsadsajj
            </div>

		   <%-- <ul id="Criar">
                <li>
                <ul class="nav">
			        <li class="nav-one"><a href="RepresentanteLegal" class="current">Representante</a></li>
			        <li class="nav-two"><a href="Juizes">Juiz</a></li>
		        </ul>
                </li>
		    </ul>
		
		    <ul id="Editar" class="hide">
                <li>
                <ul class="nav2">
                	<li class="nav-one"><a href="#tab=RepresentanteLegal" class="current">Representante</a></li>
			        <li class="nav-two"><a href="#tab=Juizes">Juiz</a></li>
                </ul>
                </li>
		    </ul>



            <div class="list-wrap2">
		
                <ul id="RepresentanteLegal">
			        <li><a href="http://css-tricks.com/perfect-full-page-background-image/">Full Page Background Images</a></li>
			        <li><a href="http://css-tricks.com/designing-for-wordpress-complete-series-downloads/">Designing for WordPress</a></li>
			        <li><a href="http://css-tricks.com/build-your-own-social-home/">Build Your Own Social Home!</a></li>
			        <li><a href="http://css-tricks.com/absolute-positioning-inside-relative-positioning/">Absolute Positioning Inside Relative Positioning</a></li>
			        <li><a href="http://css-tricks.com/ie-css-bugs-thatll-get-you-every-time/">IE CSS Bugs That'll Get You Every Time</a></li>
			        <li><a href="http://css-tricks.com/404-best-practices/">404 Best Practices</a></li>
			        <li><a href="http://css-tricks.com/date-display-with-sprites/">Date Display with Sprites</a></li>
		        </ul>
		
		        <ul id="Juizes" class="hide">
			        <li><a href="http://css-tricks.com/video-screencasts/58-html-css-the-very-basics/">The VERY Basics of HTML &amp; CSS</a></li>
			        <li><a href="http://css-tricks.com/the-difference-between-id-and-class/">Classes and IDs</a></li>
			        <li><a href="http://css-tricks.com/the-css-box-model/">The CSS Box Model</a></li>
			        <li><a href="http://css-tricks.com/all-about-floats/">All About Floats</a></li>
			        <li><a href="http://css-tricks.com/the-css-overflow-property/">CSS Overflow Property</a></li>
			        <li><a href="http://css-tricks.com/css-font-size/">CSS Font Size - (px - em - % - pt - keyword)</a></li>
			        <li><a href="http://css-tricks.com/css-transparency-settings-for-all-broswers/">CSS Transparency / Opacity</a></li>
			        <li><a href="http://css-tricks.com/css-sprites/">CSS Sprites</a></li>
			        <li><a href="http://css-tricks.com/nine-techniques-for-css-image-replacement/">CSS Image Replacement</a></li>
			        <li><a href="http://css-tricks.com/what-is-vertical-align/">CSS Vertial Align</a></li>
			        <li><a href="http://css-tricks.com/the-css-overflow-property/">The CSS Overflow Property</a></li>
		        </ul>--%>


            </div> <!-- END List Wrap 2 -->
	   </div><!-- END List Wrap 1 -->
        </form>
	</div> 

	</div>

</body>

</html>