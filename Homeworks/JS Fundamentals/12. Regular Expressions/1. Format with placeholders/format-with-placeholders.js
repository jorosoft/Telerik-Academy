function solve(args) {
	String.prototype.formatString = function(placeholders) {
    var text = this;
    var object = JSON.parse(placeholders);    
    for(var property in object) {        
        var re = new RegExp('#{' + property + '}', 'gm');
        text = text.replace(re, object[property]);
    }    
    return text;
    };

    console.log(args[1].formatString(args[0]));  
}