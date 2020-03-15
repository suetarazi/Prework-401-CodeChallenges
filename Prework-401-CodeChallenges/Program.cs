using System;

namespace Prework_401_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateLeapyear();
            Challenge3();
            //challenge1 and 4 calls
        }

        public static void Challenge1()
        {

        }

        public static void CalculateLeapyear()
        {

            Console.WriteLine("Please enter a 4-digit year and I'll tell you if it is a leap year");
            Console.Write("Your year:  ");
            string answer = Console.ReadLine();
            int year = Int32.Parse(answer);

            if (year % 400 == 0)
            {
                Console.WriteLine("You chose a leap year!");
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("You chose a leap year!");
            }
            else
            {
                Console.WriteLine("Sorry, that's not a leap year.");


            }

        }
        public static void Challenge3()
        {
            //accept an array

            int[] array = new int[3];
            Console.WriteLine("Please input 3 numbers. Please hit ENTER after each.");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("I'm in the for loop");
                array[i] = Int32.Parse(Console.ReadLine());
            Console.WriteLine(array[i]);
            }
            
            //declare sum and product variables
            int sum = 0;
            int product = 0;
            //sum loop
            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum is {sum}");
            //product loop
            for (var i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine("Product is {product}");
            //if statement sum==product
            if (sum == product)
            {
                Console.WriteLine("You have a Perfect Sequence!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a Perfect Sequence");
            }

        }
    }
}

