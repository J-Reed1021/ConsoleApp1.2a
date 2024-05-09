// Program to accept two integers

namespace ConsoleApp1._2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int sum2 = Convert.ToInt32(Console.ReadLine());

            if (sum1 == sum2)
            {
                Console.WriteLine("The two numbers you entered are equal");
            }


            else
            {
                Console.WriteLine("The two numbers you entered are not equal");

            }

        }

    }

}