﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ajuUminho.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="UTF-8"/>
	
	<title>Organic Tabs (with Replace State)</title>
	
	<link rel="stylesheet" href="css/style.css"/>
	
	<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js'></script>
	<script src="js/organictabs.jquery.js"></script>
	
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

<div id="page-wrap">
	
	<h1>Organic Tabs</h1>

	<p>This is a plugin, so you can call it on multiple tabbed areas, which can be styled totally differently</p>
	
	
	
	<div id="example-two">
		
		<ul class="nav">
			<li class="nav-one"><a href="#featured2" class="current">Featured</a></li>
			<li class="nav-two"><a href="#core2">Core</a></li>
			<li class="nav-three"><a href="#jquerytuts2">jQuery</a></li>
			<li class="nav-four last"><a href="#classics2">Classics</a></li>
		</ul>
		
		<div class="list-wrap">
		
		<ul id="featured2">
			<li><a href="http://css-tricks.com/perfect-full-page-background-image/">Full Page Background Images</a></li>
			<li><a href="http://css-tricks.com/designing-for-wordpress-complete-series-downloads/">Designing for WordPress</a></li>
			<li><a href="http://css-tricks.com/build-your-own-social-home/">Build Your Own Social Home!</a></li>
			<li><a href="http://css-tricks.com/absolute-positioning-inside-relative-positioning/">Absolute Positioning Inside Relative Positioning</a></li>
			<li><a href="http://css-tricks.com/ie-css-bugs-thatll-get-you-every-time/">IE CSS Bugs That'll Get You Every Time</a></li>
			<li><a href="http://css-tricks.com/404-best-practices/">404 Best Practices</a></li>
			<li><a href="http://css-tricks.com/date-display-with-sprites/">Date Display with Sprites</a></li>
		</ul>
		
		<ul id="core2" class="hide">
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
		
		<ul id="jquerytuts2" class="hide">
			<li><a href="http://css-tricks.com/anythingslider-jquery-plugin/">Anything Slider jQuery Plugin</a></li>
			<li><a href="http://css-tricks.com/moving-boxes/">Moving Boxes</a></li>
			<li><a href="http://css-tricks.com/simple-jquery-dropdowns/">Simple jQuery Dropdowns</a></li>
			<li><a href="http://css-tricks.com/creating-a-slick-auto-playing-featured-content-slider/">Featured Content Slider</a></li>
			<li><a href="http://css-tricks.com/startstop-slider/">Start/Stop Slider</a></li>
			<li><a href="http://css-tricks.com/banner-code-displayer-thing/">Banner Code Displayer Thing</a></li>
			<li><a href="http://css-tricks.com/highlight-certain-number-of-characters/">Highlight Certain Number of Characters</a></li>
			<li><a href="http://css-tricks.com/auto-moving-parallax-background/">Auto-Moving Parallax Background</a></li>
		</ul>
		
		<ul id="classics2" class="hide">
			<li><a href="http://css-tricks.com/css-wishlist/">Top Designers CSS Wishlist</a></li>
			<li><a href="http://css-tricks.com/what-beautiful-html-code-looks-like/">What Beautiful HTML Code Looks Like</a></li>
			<li><a href="http://css-tricks.com/easily-password-protect-a-website-or-subdirectory/">Easily Password Protect a Website or Subdirectory</a></li>
			<li><a href="http://css-tricks.com/how-to-create-an-ie-only-stylesheet/">IE-Only Stylesheets</a></li>
			<li><a href="http://css-tricks.com/ecommerce-considerations/">eCommerce Considerations</a></li>
			<li><a href="http://css-tricks.com/php-for-beginners-building-your-first-simple-cms/">PHP: Build Your First CMS</a></li>
		</ul>
		
		</div> <!-- END List Wrap -->
	
	</div> <!-- END Organic Tabs (Example One) -->
	
	<p>This is some content below the tabs. I will be moved up or down to accommodate the tabbed area above me.</p>
	
	</div>

</body>

</html>