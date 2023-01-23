interface TS {
    name: string;
    age: number;
}

function greet(person: TS) {
    return "Hello " + person.name;
}