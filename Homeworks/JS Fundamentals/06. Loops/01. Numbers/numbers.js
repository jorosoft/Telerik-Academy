function solve(args) {
	var result = '';
	for(var i=1;i <= +args[0];i += 1) {
		if(i != +args[0]){
			result += i + ' ';
		} else {
			result += i;
		}		
	}
	console.log(result);
}