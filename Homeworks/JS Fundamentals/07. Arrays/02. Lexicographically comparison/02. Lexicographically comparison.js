function solve(args) {
    var text = args[0].split('\n');
    var textA = text[0];
    var textB = text[1];
    var state = 0;
    for (var i = 0; i < Math.min(textA.length, textB.length); i += 1) {
        if (textA[i] > textB[i]) {
            state = 1;
            break;
        }
        if (textA[i] < textB[i]) {
            state = 2;
            break;
        }
    }
    if (state === 0 && textA.length > textB.length) {
        state = 1;
    }
    if (state === 0 && textB.length > textA.length) {
        state = 2;
    }
    switch (state) {
        case 0:
            console.log('=');
            break;
        case 1:
            console.log('>');
            break;
        case 2:
            console.log('<');
            break;
        default:
            break;
    }
}