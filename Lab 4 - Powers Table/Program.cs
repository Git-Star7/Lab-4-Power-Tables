using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey, let's make a powers table!\n");
            
            CalculateTable();
        }
        public static void CalculateTable()
        {
            
            char userContinue = 'y';
            while (userContinue == 'y')
            {
                //prompt
                Console.Write("\nEnter an integer: ");

                //input will work with decimals as well so it doesn't break
                double userNum1 = double.Parse(Console.ReadLine());

                //validation
                if (userNum1 >= 0)
                {
                    double square, cube;

                    //string.Format for formatting the table
                    Console.WriteLine(string.Format("\n{0,-10}    {1,-10}    {2,-10}", "Number", "Square", "Cubed"));
                    Console.WriteLine(string.Format("{0,-10}    {0,-10}    {0,-10}", "========="));

                    //for loop with calculations inside. Using var "i" for the first column of the table
                    for (int i = 1; i <= userNum1; i++)
                    {
                        square = Math.Pow(i, 2);
                        cube = Math.Pow(i, 3);
                        Console.WriteLine(string.Format("{0,-10} |  {1,-10} |  {2,-10}", i, square, cube));
                    }

                    //validation for continuing
                    userContinue = ' ';
                    while (userContinue != 'y' && userContinue != 'n')
                    {
                        Console.WriteLine("\nWould you like to continue? y/n?");
                        userContinue = Console.ReadLine()[0];

                        if (userContinue == 'n')
                        {
                            Console.WriteLine("OKBAI!!");
                        }
                    }
                }
            }
        }
    }
}
