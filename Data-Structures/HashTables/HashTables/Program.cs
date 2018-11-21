using HashTables.Classes;
using System;

namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHashTable();
        }

        public static void CreateHashTable()
        {
            HashTable table = new HashTable();

            table.Add("brian", "love DSA");
            Console.WriteLine("Add: brian, love DSA");
            Console.WriteLine($"Found in Hash Table: {table.Contains("brian")}");

            table.Add("I am", "6'4");
            Console.WriteLine("Add: I am, 6'4");
            Console.WriteLine($"Found in Hash Table: {table.Contains("I am")}");

            table.Add("sonics", "2022 or bust");
            Console.WriteLine("Add: sonics, 2022 or bust");
            Console.WriteLine($"Found in Hash Table: {table.Contains("sonics")}");

            table.Add("we I turn this in", "i'll be above 90%!");
            Console.WriteLine("Add: we I turn this in, i'll be above 90%");
            Console.WriteLine($"Found in Hash Table: {table.Contains("we I turn this in")}");
        }
    }
}
