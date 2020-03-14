using System;

namespace Prework_401_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateLeapyear();
            Challenge4();
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

    public static void Challenge4()
        {
            //user input for length and width of matrix
            Console.WriteLine("Please enter the number of rows and columns for your array   ");

            //create 2d array and populate with random numbers
            /*
            int[,] multiDimensionalArray1 = new int[rows, columns];
            Random rand = new Random();
            for (i=0; i<rows; i++)
            {
                for(j=0; j<columns; j++)
                {
                    twoDimArray[i] = rand.Next(0, 9);
                }
            }
            */
            //making a test matrix with sample data shown in challenge4 info
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

            //nested for loop to add each row
            int sum = 0;
            for(var i=0; i<myArray.Length; i++)
            {
                for (var j = 0; j < myArray[i].Length; j++)
                {
                    sum += myArray[i][j];
                }
            }
            //return new array
            Console.WriteLine(myArray);
        }
    }
}
