function solve(args) {
    var number = +args[0];

    function isPrime(num) {
        for (var j = 2; j <= Math.sqrt(num); j += 1) {
            if (num % j === 0) {
                return false;
            }
        }
        return true;
    }
    for (var i = number; i > 1; i -= 1) {
        if (isPrime(i)) {
            console.log(i);
            break;
        }
    }
}