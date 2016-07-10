function solve(args) {
    var array = new Array(+args[0])
    for (var index = 0; index < +args[0]; index += 1) {
        array[index] = index * 5;
        console.log(array[index]);
    }
}