function dieRoll(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

const dice = ["one", "two", "three", "four", "five", "six"];

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

for (let i = 0; i < 10; i++) {
  let die1 = dieRoll(1, 6);
  let die2 = dieRoll(1, 6);

  let die1string = dice[die1 - 1];
  let die2string = dice[die2 - 1];

  if (die1 === die2) {
    console.log(
      `Set ${i + 1}: ${die1string} + ${die2string} = ${die1 + die2} DOUBLES!`
    );
  } else {
    console.log(`Set ${i + 1}: ${die1string} + ${die2string} = ${die1 + die2}`);
  }
}
