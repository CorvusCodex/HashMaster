const crypto = require('crypto');
const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

console.log("============================================================");
console.log("Created by: Corvus Codex");
console.log("Github: https://github.com/CorvusCodex/");
console.log("Licence : MIT License");
console.log("Support my work:");
console.log("BTC: bc1q7wth254atug2p4v9j3krk9kauc0ehys2u8tgg3");
console.log("ETH & BNB: 0x68B6D33Ad1A3e0aFaDA60d6ADf8594601BE492F0");
console.log("Buy me a coffee: https://www.buymeacoffee.com/CorvusCodex");
console.log("============================================================");

rl.question('Enter input string: ', (inputString) => {
  console.log("============================================================");
  rl.question('Enter secret key: ', (key) => {
    console.log("============================================================");

    // Compute HMAC-SHA-256 hash
    const sha256Hash = crypto.createHmac('sha256', key).update(inputString).digest('hex');
    // console.log(`HMAC-SHA-256: ${sha256Hash}`);

    // Compute HMAC-SHA-512 hash
    const sha512Hash = crypto.createHmac('sha512', key).update(inputString).digest('hex');
    // console.log(`HMAC-SHA-512: ${sha512Hash}`);

    // Compute HMAC-SHA-384 hash
    const sha384Hash = crypto.createHmac('sha384', key).update(inputString).digest('hex');
    // console.log(`HMAC-SHA-384: ${sha384Hash}`);

    // Compute HMAC-SHA-224 hash
    const sha224Hash = crypto.createHmac('sha224', key).update(inputString).digest('hex');
    // console.log(`HMAC-SHA-224: ${sha224Hash}`);

    // Concatenate the results
    const concatenatedHashes = sha256Hash + sha512Hash + sha384Hash + sha224Hash;
    console.log(`Concatenated hashes: ${concatenatedHashes}`);

    rl.close();
  });
});

