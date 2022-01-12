using System;

namespace Zadacha_lol
{
    class Program
    {
        static void Main(string[] args)
        { 
            
                int[] IntArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
                int target = 17;
                int pos = Array.BinarySearch(IntArray, target);
                if (pos >= 0)
                    Console.WriteLine($"Item {IntArray[pos].ToString()} found at position {pos + 1}.");
                else
                    Console.WriteLine("Item not found");
                Console.ReadLine();
            
        }
    }
}
