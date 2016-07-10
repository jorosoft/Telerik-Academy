function solve(args) {
	var pattern = args[0].toLowerCase(),
	    text = args[1].toLowerCase(),
        count = 0,
        startIndex = 0,
        foundIndex = 0;
    while (true)
    {
        foundIndex = text.indexOf(pattern, startIndex);
        if (foundIndex < 0)
        {
            break;
        }
        count += 1;
        startIndex = foundIndex + 1;
    }
    console.log(count);
}