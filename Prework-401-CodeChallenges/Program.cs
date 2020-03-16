using System;

namespace Prework_401_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
            CalculateLeapyear();
            //random comment
            Challenge4();
            Challenge3();
        }

        //Challenge 1:
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
              //calculate score = inputted number * frequency
              int score = pickedNum * count;
                Console.WriteLine("Your score is {0}.", score);

        
        }

        //Challenge2:
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

        //Challenge 3:
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
            int product = 1;
            //sum loop
            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum is {sum}");
            //product loop
            for (var i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine($"Product is {product}");
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

        //Challenge 4:
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
            for (var i = 0; i < myArray.GetLength(0); i++)
            {
                for (var j = 0; j < myArray.GetLength(1); j++)
                {
                    sum += myArray[i,j];
                }
            }
            //return new array
            Console.WriteLine(myArray);



        }
    }
}
