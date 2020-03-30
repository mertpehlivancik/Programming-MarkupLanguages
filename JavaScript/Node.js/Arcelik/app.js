var express = require("express");
var app = express();
var bodyParser = require("body-parser");

app.use(bodyParser.urlencoded({extended: true}));
app.set("view engine", "ejs");

var campgrounds = [
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
	const getCamp=campgrounds.find(camp => camp.name == name);
	if(getCamp == undefined){
		var newCampground = {name: name, image: image};
		campgrounds.push(newCampground);
	}else{
		let index = 0;
		for (index = 0; index < campgrounds.length; index++) {
			const element = campgrounds[index].name;
			if(element == name){
				break;
			}
		}
		var x = campgrounds[index].image;
		x = parseInt(x);
		x = x + 1;
		x = x.toString();
		campgrounds[index].image = x;
		



		// var x = campgrounds[index].image;
		// console.log(typeof x);
		// var x = parseInt(x);
		// x = x + 1;
		// campgrounds[index].image = x;
	}
	// const getCamp=campgrounds.find(camp => camp.name == 1);
	// console.log(getCamp.name);
	// campgrounds.find(camp => camp.name = name).image = 10;
	res.redirect("/campgrounds");
	// redirect back to campgrounds page
});

app.get("/campgrounds/new", function(req, res){
	res.render("new");
});

app.listen(3000, "localhost", function(){
	console.log("YelpCamp Server Has Started in 3000!");
});