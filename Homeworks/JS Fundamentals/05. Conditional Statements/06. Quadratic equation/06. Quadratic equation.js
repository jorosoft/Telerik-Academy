function solve(args) {
	var a = +args[0];
	var b = +args[1];
	var c = +args[2];
	var determinant = (b * b) - (4 * a * c);
	var rootOne = (-b + Math.sqrt(determinant)) / (2 * a);
    var rootTwo = (-b - Math.sqrt(determinant)) / (2 * a);
    if (determinant > 0) {
        console.log('x1=' + Math.min(rootOne, rootTwo).toFixed(2) + '; x2=' + Math.max(rootOne, rootTwo).toFixed(2));        
    }
    else if (determinant == 0) {
        console.log('x1=x2=' + rootOne.toFixed(2));
    } else {
        console.log("no real roots");
    }
}