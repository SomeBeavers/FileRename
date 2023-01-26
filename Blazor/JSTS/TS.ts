interface TS {
    name: string;
    age: number;
}

class TSImpl implements TS {
    age: number;
    name: string;
}

function greet(person: TS) {
    return "Hello " + person.name;
}