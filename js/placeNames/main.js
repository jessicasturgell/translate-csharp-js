const names = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];

console.log("All Place Names");

names.map((n) => {
  console.log(n);
});

console.log("");

console.log("'The' Place Names");

names.some((n) => {
  if (n.toLocaleLowerCase().startsWith("the")) {
    console.log(n);
  }
});
