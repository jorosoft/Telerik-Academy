function solve(args) {
    args.remove = function(value) {
        for (var i = 0; i < this.length; i += 1) {
            if (this[i].localeCompare(value) === 0) {
                this.splice(i, 1);
                i -= 1;
            }
        }
    };
    args.remove(args[0]);
    console.log(args.join('\n'));
}