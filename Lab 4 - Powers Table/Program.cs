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
                Console.Write("\nEnter an integer: ");
                int userNum1 = int.Parse(Console.ReadLine());
                if (userNum1 >= 0)
                {
                    double square, cube;

                    Console.WriteLine(string.Format("\n{0,-10}    {1,-10}    {2,-10}", "Number", "Square", "Cubed"));
                    Console.WriteLine(string.Format("{0,-10}    {0,-10}    {0,-10}", "========="));

                    for (int i = 1; i <= userNum1; i++)
                    {
                        square = Math.Pow(i, 2);
                        cube = Math.Pow(i, 3);
                        Console.WriteLine(string.Format("{0,-10} |  {1,-10} |  {2,-10}", i, square, cube));
                    }
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
