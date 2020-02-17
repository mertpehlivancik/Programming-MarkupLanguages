var express = require("express");
var app = express();
var bodyParser = require("body-parser");

app.use(bodyParser.urlencoded({extended: true}));
app.set("view engine", "ejs");

var campgrounds = [
	{name: "Salmon Creek", image: "https://www.photosforclass.com/download/pixabay-4817872?webUrl=https%3A%2F%2Fpixabay.com%2Fget%2F52e8d4444255ae14f6da8c7dda793f7f1636dfe2564c704c7d2e78dd924ec35d_960.jpg&user=chulmin1700"},
	{name: "Granite Hill", image: "https://images.pexels.com/photos/1061640/pexels-photo-1061640.jpeg?cs=srgb&dl=bonfire-surrounded-with-green-grass-field-1061640.jpg&fm=jpg"},
	{name: "Mountain Goat's Rest", image: "https://www.photosforclass.com/download/pixabay-4522970?webUrl=https%3A%2F%2Fpixabay.com%2Fget%2F52e5d7414355ac14f6da8c7dda793f7f1636dfe2564c704c7d2e78dd924ec35d_960.jpg&user=Ben_Frieden"}
];

app.get("/", function(req, res){
	// res.send("This will be the landing page soon!");
	res.render("landing");
});

app.get("/campgrounds", function(req, res){
	res.render("campgrounds", {campgrounds:campgrounds});
});

app.post("/campgrounds", function(req, res){
	// res.send("You hit the post route");	
	// Get data from form and add to campgrounds array
	var name = req.body.name;
	var image = req.body.image;
	var newCampground = {name: name, image: image};
	campgrounds.push(newCampground);
	res.redirect("/campgrounds");
	// redirect back to campgrounds page

});

app.get("/campgrounds/new", function(req, res){
	res.render("new");
});

app.listen(3000, "localhost", function(){
	console.log("YelpCamp Server Has Started in 3000!");
});