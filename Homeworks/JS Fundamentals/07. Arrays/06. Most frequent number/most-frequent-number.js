function solve(args) {
    var array = args[0].split('\n');
    var numberN = +array[0];
    var numbers = new Array(numberN);
    for (var i = 0; i < numbers.length; i += 1) {
        numbers[i] = +array[i + 1];
    }
    var tempCount = 1;
    var tempIndex = 0;
    var maxCount = 0;
    var maxIndex = 0;
    for (var current = 0; current < numbers.length - 1; current += 1, tempCount = 1) {
        for (var compared = current + 1; compared < numbers.length; compared += 1) {
            if (numbers[current] === numbers[compared]) {
                tempCount += 1;
                tempIndex = current;
            }
        }
        if (maxCount < tempCount) {
            maxCount = tempCount;
            maxIndex = tempIndex;
        }
    }
    console.log(numbers[maxIndex] + ' (' + maxCount + ' times' + ')');
}