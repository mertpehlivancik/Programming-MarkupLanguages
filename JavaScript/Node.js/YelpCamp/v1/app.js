var express = require("express");
var app = express();

app.set("view engine", "ejs");

app.get("/", function(req, res){
	// res.send("This will be the landing page soon!");
	res.render("landing");
});

app.get("/campgrounds", function(req, res){
	var campgrounds = [
		{name: "Salmon Creek", image: "https://www.photosforclass.com/download/pixabay-4817872?webUrl=https%3A%2F%2Fpixabay.com%2Fget%2F52e8d4444255ae14f6da8c7dda793f7f1636dfe2564c704c7d2e78dd924ec35d_960.jpg&user=chulmin1700"},
		{name: "Granite Hill", image: "https://images.pexels.com/photos/1061640/pexels-photo-1061640.jpeg?cs=srgb&dl=bonfire-surrounded-with-green-grass-field-1061640.jpg&fm=jpg"},
		{name: "Mountain Goat's Rest", image: "https://www.photosforclass.com/download/pixabay-4522970?webUrl=https%3A%2F%2Fpixabay.com%2Fget%2F52e5d7414355ac14f6da8c7dda793f7f1636dfe2564c704c7d2e78dd924ec35d_960.jpg&user=Ben_Frieden"}
	];
	res.render("campgrounds", {campgrounds:campgrounds});
});

app.listen(3000, "localhost", function(){
	console.log("YelpCamp Server Has Started in 3000!");
});