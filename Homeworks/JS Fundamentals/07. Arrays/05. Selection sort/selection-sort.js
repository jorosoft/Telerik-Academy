function solve(args) {
    var array = args[0].split('\n');
    var numberN = +array[0];
    var numbers = new Array(numberN);
    for (var i = 0; i < numbers.length; i += 1) {
        numbers[i] = +array[i + 1];
    }
    for (var current = 0; current < numbers.length - 1; current += 1) {
        for (var compared = current + 1; compared < numbers.length; compared += 1) {
            if (numbers[current] > numbers[compared]) {
                var temp = numbers[current];
                numbers[current] = numbers[compared];
                numbers[compared] = temp;
            }
        }
    }
    console.log(numbers.join('\n'));
}