// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script type="text/javascript">
	function changeColor(colorValues){
		objectValues = colorValues.split(":");
	selBgColor=objectValues[0];
	selFgColor=objectValues[1];
	selFontSize=objectValues[2];

	document.getElementById('area_product').style.backgroundColor=selBgColor;
	document.getElementById('changeColor').style.color=selFgColor;
	document.getElementById('changeColor').style.fontSize=selFontSize+"px";
}
</script>