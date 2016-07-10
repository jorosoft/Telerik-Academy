function solve(args) {
	var number = +args[0];
	for(var row = 1;row <= number;row += 1) {
		var line = '';
		for(var col = row;col < number + row;col += 1) {
			if(col < number + row - 1) {
				line += col + ' ';
			} else {
				line += col;
			}			
		}
		console.log(line);
	}	
}