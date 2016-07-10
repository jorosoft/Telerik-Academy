function solve(args) {
    function biSearch(array, searchedNumber, start, end) {
        for (var i = start; i <= end; i += 1) {
            if (+array[i] === searchedNumber) {
                return i;
            }
        }
        return -1;
    }
    var data = args[0].split('\n'),
        numberN = +data.shift(),
        numberX = +data.pop();
    var firstIndex = 0;
    var lastIndex = data.length - 1;
    var resultIndex = 0;
    var middle = 0;
    for (var j = firstIndex; j < lastIndex; j += 1) {
        middle = (lastIndex / 2) | 0;
        if (+data[middle] === numberX) {
            resultIndex = middle;
            break;
        }
        if (+data[middle] < numberX) {
            firstIndex = middle;
            resultIndex = biSearch(data, numberX, firstIndex, lastIndex);
        }
        if (+data[middle] > numberX) {
            lastIndex = middle;
            resultIndex = biSearch(data, numberX, firstIndex, lastIndex);
        }
    }
    if (resultIndex >= 0 && resultIndex < data.length) {
        console.log(resultIndex);
    } else {
        console.log('-1');
    }
}