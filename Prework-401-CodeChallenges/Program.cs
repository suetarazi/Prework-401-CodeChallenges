using System;

namespace Prework_401_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
            CalculateLeapyear();
        }

        public static void Challenge1()
        {
            int i;
            int[] array = new int[5];
            for(i=0; i<5; i++)
            {
            //user selects 5 numbers between 1-10 that are returned to the user as an array
            Console.WriteLine("Please select 5 numbers between 1-10. Please hit enter after each.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Return the array to the user:
            for(i=0; i<5; i++)
            {
                Console.WriteLine("You entered {0}", array[i]);
            }

            //user picks one of the 5 numbers
            Console.WriteLine("Please pick one of these numbers ");
            string answer = Console.ReadLine();
            int pickedNum = Int32.Parse(answer);
            
        //find frequency of that number in the array
                int count = 0;
            foreach(int n in array)
            {
                if(pickedNum == n)
                {
                    count++;
                }
                
            }
                int score = pickedNum * count;
                Console.WriteLine("Your score is {0}.", score);

        //calculate score = inputted number * frequency

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


    }
}
