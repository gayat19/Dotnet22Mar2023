using System.Diagnostics.CodeAnalysis;

namespace UnderstandingConstructsApp
{
    internal class Program
    {


        void UnderstandingFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        void UnderstandingWhile()
        {
            int count = 0;
            while(count<5)
            {
                count++;
                if (count == 2)
                    continue;
                Console.WriteLine(count);
                
            }
        }
        void UnderstandingDoWhile()
        {
            int sum = 0;
            int count = 0;
            do
            {
                Console.WriteLine("Please enter a number");
                count = Convert.ToInt32(Console.ReadLine());
               
                if (count % 7 == 0)
                    sum += count;

            } while (count>-1);
            Console.WriteLine(sum);
        }
        void UnderstandingSwitch()
        {
            int number = 5;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday"); 
                    break;
                case 6:
                case 7:
                        Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("No such day");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.UnderstandingDoWhile();
        }
    }
}