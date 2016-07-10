function solve(args) {
    function getLineLength(line) {
        var lineLength = Math.sqrt(Math.pow(line.x1 - line.x2, 2) + Math.pow(line.y1 - line.y2, 2));
        return lineLength;
    }

    function isAvailableTriangle(sideA, sideB, sideC) {
        var tmp;
        if (sideB > sideA) {
            tmp = sideA;
            sideA = sideB;
            sideB = tmp;
        }
        if (sideC > sideA) {
            tmp = sideA;
            sideA = sideC;
            sideC = tmp;
        }
        if (sideA < sideB + sideC) {
            return true;
        }
        return false;
    }
    var lines = [];
    var linesLength = [];
    for (var i = 0; i < args.length; i += 4) {
        lines.push({
            x1: +args[i],
            y1: +args[i + 1],
            x2: +args[i + 2],
            y2: +args[i + 3]
        });
        linesLength.push(getLineLength(lines[i / 4]));
        console.log(linesLength[i / 4].toFixed(2));
    }
    if (isAvailableTriangle(linesLength[0], linesLength[1], linesLength[2])) {
        console.log('Triangle can be built');
    } else {
        console.log('Triangle can not be built');
    }
}