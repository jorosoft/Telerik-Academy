function solve(args) {
	var numberX = +args[0];
    var numberY = +args[1];
    var distanceCircle;
    var stateCircle;
    var stateRectangle;
    distanceCircle = Math.sqrt((numberX-1) * (numberX-1) + (numberY-1) * (numberY-1));
    if (distanceCircle > 1.5)
    {
    stateCircle = 'outside';
    }
    else
    {
    stateCircle = 'inside';
    }
    if (numberX > 5 || numberX < -1 || numberY > 1 || numberY < -1)
    {
    stateRectangle = 'outside';
    }
    else
    {
    stateRectangle = 'inside';
    }
    console.log(stateCircle + ' circle ' + stateRectangle + ' rectangle');
}