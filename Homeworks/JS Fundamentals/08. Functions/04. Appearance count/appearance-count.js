function solve(args) {
    var numbers = args[1].split(' ');

    function getCountOfNumberRepeats(searchedNumber, array) {
        var count = 0;
        for (var index = 0; index < array.length; index += 1) {
            if (array[index] === searchedNumber) {
                count += 1;
            }
        }
        return count;
    }
    console.log(getCountOfNumberRepeats(args[2], numbers));
}