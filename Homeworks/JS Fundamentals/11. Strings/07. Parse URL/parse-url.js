function solve(args) { 
    var firstSeparatorIndex = args[0].indexOf('://');
    var secondSeparatorIndex = args[0].indexOf('/', firstSeparatorIndex + 3);
    var protocol = args[0].substring(0, firstSeparatorIndex);    
    var server = args[0].substring(firstSeparatorIndex + 3, secondSeparatorIndex);
    var resource = args[0].substring(secondSeparatorIndex);
    console.log('protocol: ' + protocol);
    console.log('server: ' + server);
    console.log('resource: ' + resource);
}