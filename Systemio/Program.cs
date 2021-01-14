using System;

namespace Systemio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChallengeOne());
        }

        //Send to Mike.
        static int ChallengeOne()
        {

            int product = 1;
            Console.WriteLine("Please Enter 3 Numbers (Separated by a ','):");
            string userInput = Console.ReadLine();
            string[] numStringArray = userInput.Split(',');

            int[] numArray = new int[numStringArray.Length];
            //This will catch the short array
            if (numStringArray.Length < 3) { return 0; }
            
            //This is going the conversion
            try
            {
                bool isNumber = false;
                for (int i = 0; i < numStringArray.Length; i++)
                {
                    if (!int.TryParse(numStringArray[i], out numArray[i]))
                    {
                        numArray[i] = 1;
                    }
                                         
                    

                }
            }
            catch
            {
                //Will handle a non-integer.
                return 1;
            }

            return product;
        }

        static int Challenge2()
        {
            bool isEnough = false;
            int userNum = 0;
            int sum = 0;
            while (!isEnough)
            {
                Console.WriteLine("Please enter a number between 2 and 10: ");
                string userInput = Console.ReadLine();
                try
                {
                    userNum = Convert.ToInt32(userInput);
                }
                catch
                {
                    Console.WriteLine("Invalid number entered.");
                }
                if (userNum < 2 || userNum > 10)
                {
                    Console.WriteLine("Number is not within range.");
                }
                else
                {
                    isEnough = true;
                }
            }
            int[] numArray = new int[userNum];
            for (int i = 0; i < numArray.Length; i++)
            {
                bool isAcceptable = false;
                while (!isAcceptable)
                {
                    Console.Write($"Enter number {i} of {userNum}");
                    string userInput = Console.ReadLine();
                    int testNum = ConvertStringToInt(userInput);
                    if (testNum > 0)
                    {
                        numArray[i] = testNum;
                        sum += testNum;
                        isAcceptable = true;
                    }
                }

            }
            return sum / userNum;

        }

        static int ConvertStringToInt(string s)
        {
            int convertInt = 0;
            try
            {
                return convertInt = int.Parse(s);
            }

            catch
            {
                Console.WriteLine("Unable to Parse Value. Zero Returned");
                return convertInt;
            }
        }
    }
}
