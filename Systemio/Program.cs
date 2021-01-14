using System;
using System.IO;
namespace Systemio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            //Console.WriteLine(ChallengeOne());
            ChallengeThree();
            Console.WriteLine(ChallengeFive(numArray));
            ChallengeSix();
        }

        //Send to Mike.
        public static int ChallengeOne()
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

        public static int Challenge2()
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

        public static void ChallengeThree()
        {
            //Worked with Matt

            // Total of nine character per line
            // To Center it up going to need to currentNum / length + 1
            // subtract the amount of character  
            int charCounter = 1;
            int midpoint = (9 / 2) + 1;
            string ast;
            //0000*0000
            //000***000
            //00*****00
            while (charCounter < 4)
            {
                for (int i = 4; i <= 0; i--)
                {
                    Console.Write(" ");
                    for (int q = 1; q >= charCounter; q++)
                    {
                        Console.Write("*");
                    }
                }
                charCounter += 2;
                Console.WriteLine();
            }
        }

        public static void ChallengeFour(int[] intArr)
        {
            //Completed with Kjell


            int intArrLength = intArr.Length;
            int tempValue = 0;
            int mostRepeatedIdx;
            //Each index for comparison
            for (int i = 0; i <  intArrLength; i++)
            {
                int count = 0;
                // scan the array for the i value index.
                for (int q = 0; q < intArrLength; q++)
                {
                    if (intArr[q] == intArr[i])
                    {
                        
                        count++;

                    }
                }

            }
            //iterate through the entire array
            //grab a value at i
            //we store that value somehow
            //we make sure we haven't already had that value
            //if it is a unique value, iterate with a second loop
            
            // First for loop will iterate through each indxElement //1
            // second will ALSO loop through the Array, counting the number of time idxElement occurs.  Keep that total.

            // look at the count and compare it to the previous count.  If it is more, then that becomes the most repeated.

        }

        public static int ChallengeFive(int[] numArray)
        {
            // Worked With David

            int highestValue = numArray[0];

            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i] > highestValue)
                {
                    highestValue = numArray[i];
                }
            }
            return highestValue;
        }

        public static void ChallengeSix()
        {
            Console.WriteLine("Please enter your most FAVORITE word");
            string userInput = Console.ReadLine();
            string path = @"E:\CodeFellows\401\Lab03-SystemIO\words.txt";
            if (!File.Exists(path)) { Console.WriteLine("All signs point to NOPE"); }
                        
            File.AppendAllText(path, userInput);
           
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


