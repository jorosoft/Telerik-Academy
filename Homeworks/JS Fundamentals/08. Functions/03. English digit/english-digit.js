function solve(args) {
    function getLastDigitAsWord(number) {
        var digits = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
        return digits[number[number.length - 1]];
    }
    console.log(getLastDigitAsWord(args[0]));
}