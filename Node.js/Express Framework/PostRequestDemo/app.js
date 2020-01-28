var express = require("express");
var app = express();

app.use(express.static("public"));
app.set("view engine", "ejs");

app.get("/", function(req, res){
	//res.send("<h1>Welcome to the home page</h1>");
	res.render("home");
});

app.get("/friends", function(req, res){
	var friends = ["Tony","Miranda","Justin","Pierre","Lily"];
	res.render("friends", {friends: friends});
});

app.listen(3000, "localhost", function(){
	console.log("Server is listening!!!");
});