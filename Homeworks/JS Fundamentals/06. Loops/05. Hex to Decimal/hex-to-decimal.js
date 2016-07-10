function solve(args) {
	var input = args[0].toUpperCase();
	var alphabet = ['0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'];
	var decimalPresentation = 0;
	var power = 0;
	for(var i = input.length - 1;i >= 0 ;i -= 1) {
		decimalPresentation += alphabet.indexOf(input[i]) * Math.pow(16, power);
		power += 1;
	}
	console.log(decimalPresentation);
}