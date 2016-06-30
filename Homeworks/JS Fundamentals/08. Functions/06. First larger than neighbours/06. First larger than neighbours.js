function solve(args) {
    var numbers = args[1].split(' ');

    function getFirstNumbersWithSmallerNeighbours(array) {
        var index = -1;
        for (var i = 1; i < array.length - 1; i += 1) {
            if (+array[i] > +array[i - 1] && +array[i] > +array[i + 1]) {
                index = i;
                break;
            }
        }
        return index;
    }
    console.log(getFirstNumbersWithSmallerNeighbours(numbers));
}