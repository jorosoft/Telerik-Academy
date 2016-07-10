function solve(args) {
	var input = args[0],
    	openCount = 0;
    	closeCount = 0;
    	isCorrect = true;
    for (var i = 0; i < input.length; i += 1) {
        if (input[i] === '(') {
            openCount += 1;
        }
        if (input[i] === ')') {
            closeCount += 1;
        }
        if (closeCount > openCount) {
            isCorrect = false;
            break;
        }
    }
    if (openCount != closeCount) {
        isCorrect = false;
    }
    console.log(isCorrect ? "Correct" : "Incorrect");
}