function solve(args) { 
    var result = '';
        searchIndex = 0;
    while (true)
    {
        var appendIndex = args[0].indexOf("<a href=", searchIndex);
        if (appendIndex < 0)
        {
            result += args[0].substr(searchIndex);
            break;
        }
        result += args[0].substr(searchIndex, appendIndex - searchIndex);
        var linkBeginIndex = args[0].indexOf("\"", appendIndex + 7);
        var linkEndIndex = args[0].indexOf("\"", linkBeginIndex + 1);
        var nameBeginIndex = args[0].indexOf(">", linkEndIndex + 1);
        var nameEndIndex = args[0].indexOf("<", nameBeginIndex + 1);
        var link = args[0].substr(linkBeginIndex + 1, linkEndIndex - linkBeginIndex - 1);
        var name = args[0].substr(nameBeginIndex + 1, nameEndIndex - nameBeginIndex - 1);
        result += '[' + name + '](' + link + ')';
        searchIndex = nameEndIndex + 4;
    }
    console.log(result);
}