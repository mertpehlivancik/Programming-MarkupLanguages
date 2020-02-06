var express = require("express");
var app = express();

app.get("/", function(req,res){
	res.send("Hi Mert, welcome to here");
});

app.get("/speak/:animal", function(req, res){
	var sounds = {
		pig: "Oink",
		cow: "Mooo",
		dog: "Hav Hav",
		cat: "Miav Miav",
		goldfish: "Guv Guv"
	};
	var animal = req.params.animal;
	var sound = sounds[animal];
	res.send("The " + animal + " says " + sound);
});

app.get("/repeat/:message/:times", function(req, res){
	var message = req.params.message;
	var times = Number(req.params.times);
	var result = "";
	for(var i = 0; i < times; i++){
		result += message + " ";
	}
	res.send(result);
});

app.get("*", function(req, res){
	res.send("Page not found... Please check the link");
});

app.listen(3000, "localhost", function(){
	console.log("Now serving your app in three thousandth port!");
});