using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, let's make a powers table! Enter an integer");

            int userNum1 = int.Parse(Console.ReadLine());
            CalculateTable(userNum1);

        }
        public static void CalculateTable(int num1)
        {
            double square = 1;
            double cube = 1;
            Console.WriteLine(string.Format("{0,-10}    {1,-10}    {2,-10}", "Number", "Square", "Cubed"));
            Console.WriteLine(string.Format("{0,-10}    {0,-10}    {0,-10}", "========="));

            for (int i = 1; i <= num1; i++)
            {
                square = Math.Pow(i, 2);
                cube = Math.Pow(i, 3);
                Console.WriteLine(string.Format("{0,-10} |  {1,-10} |  {2,-10}", i, square, cube));
            }
        }
    }
}
