var express = require("express");
var app = express();
var bodyParser = require("body-parser");

app.use(bodyParser.urlencoded({extented: true}));
app.use(express.static("public"));
app.set("view engine", "ejs");

var friends = ["Tony","Miranda","Justin","Pierre","Lily"];

app.get("/", function(req, res){
	//res.send("<h1>Welcome to the home page</h1>");
	res.render("home");
});

app.post("/addfriend", function(req, res){
	var newFriend = req.body.newfriend;
	friends.push(newFriend)
	//res.send("YOU HAVE REACHED THE POST ROUTE!!");
	res.redirect("/friends");
});

app.get("/friends", function(req, res){
	res.render("friends", {friends: friends});
});

app.listen(3000, "localhost", function(){
	console.log("Server is listening!!!");
});