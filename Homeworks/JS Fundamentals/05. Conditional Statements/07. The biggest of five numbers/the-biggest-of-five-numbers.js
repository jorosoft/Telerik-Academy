function solve(args) {
	var max = +args[0];
    if (+args[1] > max)
    {
        max = +args[1];
    }
    if (+args[2] > max)
    {
        max = +args[2];
    }
    if (+args[3] > max)
    {
        max = +args[3];
    }
    if (+args[4] > max)
    {
        max = +args[4];
    }
    console.log(max);
}