// Check Off Specific Todos By Clicking

/*
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
*/


/*Below code block makes same job above code block.*/
/*
$("li").click(function(){
	$(this).toggleClass("completed");
});


$("span").click(function(event){
	$(this).parent().fadeOut(500,function(){
		$(this).remove();
	});
	event.stopPropogation();
});

$("input[type='text']").keypress(function(event){
	if(event.which === 13){
		// Grabbing new todo text from input
		var todoText = $(this).val();
		// Create a new li and add to ul
		$("ul").append("<li><span>X</span> " + todoText + "</li>");
	}
});
*/

// Check Off Specific Todos By Clicking
$("ul").on("click","li",function(){
	$(this).toggleClass("completed");
});

// Click on X to Delete Todo<
$("ul").on("click", "span", function(event){
	$(this).parent().fadeOut(500,function(){
		$(this).remove();
	});
	event.stopPropogation();
});

$("input[type='text']").keypress(function(event){
	if(event.which === 13){
		// Grabbing new todo text from input
		var todoText = $(this).val();
		// Create a new li and add to ul
		$("ul").append("<li><span><i class='fa fa-trash'></i></span> " + todoText + "</li>")
	}
});

