function solve(args) {
	args[0] = Math.floor(args[0] / 10);
	args[0] = Math.floor(args[0] / 10);
	var digit = args[0] % 10;
	if (digit === 7) {
		console.log('true');
	}
	else {
		console.log('false ' + digit);	
	}	
}