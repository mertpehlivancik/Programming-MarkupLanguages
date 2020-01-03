// Check Off Specific Todos By Clicking
$("li").click(function(){
	// If li is gray
	console.log($(this).css("color"));
	if ($(this).css("color") === "rgb(255, 0, 0)") {
		// Turn it black
		$(this).css("color","black");
		$(this).css("text-decoration","none");
	}
	else {
		$(this).css({
		color: "red",
		textDecoration: "line-through"
	});
	}
});

/*Below code block makes same job above code block.*/

/*
$("li").click(function(){
	$(this).toggleClass("completed");
});
*/

$("span").click(function(event){
	$(this).parent().fadeOut(500,function(){
		$(this).remove();
	});
	event.stopPropogation();
});