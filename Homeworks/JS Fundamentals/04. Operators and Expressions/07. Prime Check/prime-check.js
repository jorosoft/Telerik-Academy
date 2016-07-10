function solve(args) {
	var number = args[0];
	var isPrime = true;
	if (number < 2) {
		isPrime = false;
	}
	for (var i = 2; i < number; i += 1) {
		if (number % i === 0) {
			isPrime = false;
			break;
		}
	}	
	if (isPrime) {
		console.log('true');
	}
	else {
		console.log('false');
	}
}