console.log("Suoritus alkaa.");
const fs = require("fs");

const data = fs.readFileSync("Luvut.txt");
console.log("Tiedoston sisältö luettu.");

let summa = 0;

const teksti = data.toString().split("\r\n");
for (rivi in teksti) {
    if (teksti[rivi] != "") {
        const luku = parseInt(teksti[rivi]);
        summa = summa + luku; // summa += luku;
    }
}

console.log("Tiedostossa olevien lukujen summa on: " + summa);
console.log("Suoritus päättyy.");
