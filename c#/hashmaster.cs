using System;
using System.Security.Cryptography;
using System.Text;

namespace HMAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Created by: Corvus Codex");
            Console.WriteLine("Github: https://github.com/CorvusCodex/");
            Console.WriteLine("Licence : MIT License");
            Console.WriteLine("Support my work:");
            Console.WriteLine("BTC: bc1q7wth254atug2p4v9j3krk9kauc0ehys2u8tgg3");
            Console.WriteLine("ETH & BNB: 0x68B6D33Ad1A3e0aFaDA60d6ADf8594601BE492F0");
            Console.WriteLine("Buy me a coffee: https://www.buymeacoffee.com/CorvusCodex");
            Console.WriteLine("============================================================");

            Console.Write("Enter input string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("============================================================");
            Console.Write("Enter secret key: ");
            byte[] key = Encoding.UTF8.GetBytes(Console.ReadLine());
            Console.WriteLine("============================================================");

            // Compute HMAC-SHA-256 hash
            string sha256Hash = BitConverter.ToString(new HMACSHA256(key).ComputeHash(Encoding.UTF8.GetBytes(inputString))).Replace("-", "");
            // Compute HMAC-SHA-512 hash
            string sha512Hash = BitConverter.ToString(new HMACSHA512(key).ComputeHash(Encoding.UTF8.GetBytes(inputString))).Replace("-", "");
            // Compute HMAC-SHA-384 hash
            string sha384Hash = BitConverter.ToString(new HMACSHA384(key).ComputeHash(Encoding.UTF8.GetBytes(inputString))).Replace("-", "");
            // Compute HMAC-SHA-224 hash
            string sha224Hash = BitConverter.ToString(new HMACSHA224(key).ComputeHash(Encoding.UTF8.GetBytes(inputString))).Replace("-", "");

            // Concatenate the results
            string concatenatedHashes = sha256Hash + sha512Hash + sha384Hash + sha224Hash;
            Console.WriteLine($"Concatenated hashes: {concatenatedHashes}");
        }
    }
}
