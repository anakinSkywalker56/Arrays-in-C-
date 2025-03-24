using System;

namespace Arrays
{
    public class TestArray
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = new int[5];
            int[,] c = new int[2, 3];

            Console.WriteLine("""
            Select Option:
            1. Declared array contents
            2. Single-dimensional array
            3. Multi-dimensional or 2D array
            4. Jagged array 
            """);

            string input = Console.ReadLine();
            int num = int.Parse(input);


            switch (num)
            {
                case 1:
                    foreach (int numbers in a)
                    {
                        Console.Write(numbers + " ");
                    }
                    break;
                case 2:
                    foreach (int numbers in b)
                    {
                        string inn = Console.ReadLine();
                        int numbers = int.Parse(inn);
                    }
                    foreach (int item in b)
                    {
                        Console.Write(numbers + " ");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}