function solve(args) {
	var a = +args[0];
	var b = +args[1];
	var c = +args[2];
	var temp;
	if (a < b) {
		temp = a;
		a = b;
		b = temp;		
	}
	if (b < c) {
		temp = b;
		b = c;
		c = temp;
	}
	if (a < b) {
		temp = a;
		a = b;
		b = temp;		
	}
	console.log(a + ' ' + b + ' ' + c);
}