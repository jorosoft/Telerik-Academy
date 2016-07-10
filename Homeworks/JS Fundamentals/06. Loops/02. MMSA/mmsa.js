function solve(args) {
	var min = +args[0];
	var max = +args[0];
	var sum = 0;
	var avg = 0;
	for(var i = 0;i < args.length;i += 1) {
		if(+args[i] < min) {
			min = +args[i];
		}
		if(+args[i] > max) {
			max = +args[i];
		}
		sum += +args[i];
	}
	avg = sum / args.length;
	console.log('min=' + min.toFixed(2));
	console.log('max=' + max.toFixed(2));
	console.log('sum=' + sum.toFixed(2));
	console.log('avg=' + avg.toFixed(2));
}