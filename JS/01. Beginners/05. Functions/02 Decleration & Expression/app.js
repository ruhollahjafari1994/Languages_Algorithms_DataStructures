// Function Declaration
function sayHello(username) {
  console.log(`Hello ${username}`);
}

sayHello("HuXn");

// Function Expressions
const greetings = function (user) {
  console.log(`Hello ${user}`);
};
const x = function (user) {
  console.log(`Hello ${user}`);
};

greetings("Doe");

// -------------------------
x(10);
console.log(x); // ERROR
