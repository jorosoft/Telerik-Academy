function solve(args) {
    var firstArray = args[1].split(' ');

    function getMaxElement(array, index) {
        var maxElementIndex = index;
        for (var i = 0; i <= index; i += 1) {
            if (+array[i] > +array[maxElementIndex]) {
                maxElementIndex = i;
            }
        }
        return maxElementIndex;
    }

    function sortArray(theArray) {
        for (var j = theArray.length - 1; j >= 0; j -= 1) {
            var maxElementIndex = getMaxElement(theArray, j);
            var temp = theArray[j];
            theArray[j] = theArray[maxElementIndex];
            theArray[maxElementIndex] = temp;
        }
    }
    sortArray(firstArray);
    console.log(firstArray.join(' '));
}