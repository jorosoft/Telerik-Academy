function solve(args) {     
    var regex = new RegExp('<' + '.*?' + '>', 'g');
    for (var i = 0; i < args.length; i += 1) {
      args[i] = args[i].replace(regex, '').trim();
    }  
    console.log(args.join(''));
}