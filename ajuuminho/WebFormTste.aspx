<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTste.aspx.cs" Inherits="ajuUminho.WebFormTste" %>

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

    <div id="page-wrap">
	
	    <div id="example-two">
		
        <div class="titles">
		    <ul class="nav">
			    <li class="nav-one"><a href="#Criar" class="current">Criar</a></li>
			    <li class="nav-two"><a href="#Editar">Editar</a></li>
		    </ul>
		</div>

		<div class="list-wrap">
		
		    <ul id="Criar">
                <li>
                <ul class="nav">
			        <li class="nav2-one"><a href="#RepresentanteLegal" class="current">Representante</a></li>
			        <li class="nav2-two"><a href="#Juizes">Juiz</a></li>
		        </ul>
                </li>
		    </ul>
		
		    <ul id="Editar" class="hide">
                <li>
                <ul class="nav">
                	<li class="nav2-one"><a href="#RepresentanteLegal" class="current">Representante</a></li>
			        <li class="nav2-two"><a href="#Juizes">Juiz</a></li>
                </ul>
                </li>
		    </ul>



            <div class="list-wrap2">
		
                <ul id="RepresentanteLegal" class="hide">
                    <li>
                        <ul class="nav">
                	    <li class="nav2-one"><a href="#RepresentanteLegal" class="current">Representante</a></li>
			            <li class="nav2-two"><a href="#Juizes">Juiz</a></li>
                        </ul>
                    </li>
			        <li><a href="http://css-tricks.com/perfect-full-page-background-image/">Full Page Background Images</a></li>
			        <li><a href="http://css-tricks.com/designing-for-wordpress-complete-series-downloads/">Designing for WordPress</a></li>
			        <li><a href="http://css-tricks.com/build-your-own-social-home/">Build Your Own Social Home!</a></li>
			        <li><a href="http://css-tricks.com/absolute-positioning-inside-relative-positioning/">Absolute Positioning Inside Relative Positioning</a></li>
			        <li><a href="http://css-tricks.com/ie-css-bugs-thatll-get-you-every-time/">IE CSS Bugs That'll Get You Every Time</a></li>
			        <li><a href="http://css-tricks.com/404-best-practices/">404 Best Practices</a></li>
			        <li><a href="http://css-tricks.com/date-display-with-sprites/">Date Display with Sprites</a></li>
		        </ul>
		
		        <ul id="Juizes" class="hide">
                                    <li>
                <ul class="nav">
                	<li class="nav2-one"><a href="#RepresentanteLegal" class="current">Representante</a></li>
			        <li class="nav2-two"><a href="#Juizes">Juiz</a></li>
                </ul>
                </li>
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
		        </ul>


            </div> <!-- END List Wrap 2 -->
	   </div><!-- END List Wrap 1 -->
	</div> 

	</div>
</div>
</body>

</html>