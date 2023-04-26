import * as fs from 'fs';

const myData = fs.readFileSync("./data.txt","utf-8");
console.log(myData)