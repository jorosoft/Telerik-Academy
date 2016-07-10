function solve(args) {
    var people = [],
        i = 0,
        minAgeIndex = 0;
    for (i = 0; i < args.length; i += 3) {
        people.push({
            FirstName: args[i],
            LastName: args[i + 1],
            Age: +args[i + 2]
        });
    }
    for (j = 1; j < people.length; j += 1) {
        if (people[j].Age < people[minAgeIndex].Age) {
            minAgeIndex = j;
        }
    }
    console.log(people[minAgeIndex].FirstName + ' ' + people[minAgeIndex].LastName);
}