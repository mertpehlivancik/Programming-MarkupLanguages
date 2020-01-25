var express = require("express");
var app = express();

app.get("/", function(req, res){
	//res.send("<h1>Welcome to the home page</h1>");
	res.render("home.ejs");
});

app.get("/fallinlovewith/:thing", function(req, res){
	var thing = req.params.thing;
	//res.send("You fell in love with " + thing);
	res.render("love.ejs", {thingVar : thing});
});

app.listen(3000, "localhost", function(){
	console.log("Server is listening!!!");
});