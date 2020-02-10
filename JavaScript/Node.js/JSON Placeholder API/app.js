/*
// npm install request --save
const request = require('request');

request('https://jsonplaceholder.typicode.com/users/1', function(error, response, body){
	// npm i -D locus
	// eval(require('locus'));
	if(!error && response.statusCode == 200){
		const parsedData = JSON.parse(body);
		// console.log(parsedData['name']);
		// console.log(parsedData.name + ' lives in ' + parsedData.address.city);
		console.log(`${parsedData.name} lives in ${parsedData.address.city}`);
	}
});
*/


/*
// npm install request --save
const request = require('request');

request('https://jsonplaceholder.typicode.com/users/1', (error, response, body) => {
	// npm i -D locus
	// eval(require('locus'));
	if(!error && response.statusCode == 200){
		const parsedData = JSON.parse(body);
		// console.log(parsedData['name']);
		// console.log(parsedData.name + ' lives in ' + parsedData.address.city);
		console.log(`${parsedData.name} lives in ${parsedData.address.city}`);
	}
});
*/


// npm i -S request-promise
const rp = require('request-promise');

rp('https://jsonplaceholder.typicode.com/users/1')
	.then((body) => {
		const parsedData = JSON.parse(body);
		console.log(`${parsedData.name} lives in ${parsedData.address.city}`)
	})
	.catch((err) => {
		console.log('Error!', err);
	});



