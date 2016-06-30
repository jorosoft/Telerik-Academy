function solve(args) {
    var array = args[0].split('\n');
    var numberN = +array[0];
    var numbers = new Array(numberN);
    for (var i = 0; i < numbers.length; i += 1) {
        numbers[i] = +array[i + 1];
    }
    var tempSequence = 1;
    var maxSequence = 1;
    for (var i = 1; i < numbers.length; i += 1) {
        if (numbers[i] == numbers[i - 1]) {
            tempSequence += 1;
        } else {
            tempSequence = 1;
        }
        if (maxSequence < tempSequence) {
            maxSequence = tempSequence;
        }
    }
    console.log(maxSequence);
}