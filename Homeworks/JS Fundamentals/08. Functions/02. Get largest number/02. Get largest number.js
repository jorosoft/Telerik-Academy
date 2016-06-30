function solve(args) {
    var numbers = args[0].split(' ');
    var max;

    function getMax(first, second) {
        return Math.max(first, second);
    }
    max = getMax(+numbers[0], +numbers[1]);
    max = getMax(max, +numbers[2]);
    console.log(max);
}