function solve(args) {
    var array = args[1].split(' ');

    function countNumbersWithSmallestNeighbours(array) {
        var count = 0;
        for (var i = 1; i < array.length - 1; i += 1) {
            if (+array[i] > +array[i - 1] && +array[i] > +array[i + 1]) {
                count += 1;
            }
        }
        return count;
    }
    console.log(countNumbersWithSmallestNeighbours(array));
}