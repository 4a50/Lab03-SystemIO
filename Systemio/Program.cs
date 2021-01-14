using System;
using System.IO;
namespace Systemio
{
 
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            //Challenge One
            Console.WriteLine("Please Enter 3 Numbers (Separated by a ','):");
            string userInput = Console.ReadLine();
            Console.WriteLine(ChallengeOne(userInput));
            //
            //Challenge Two
            int[] createdIntArray = CreateNumArray();
            Console.WriteLine(ChallengeTwo(createdIntArray));
            //
            ChallengeThree();
            //
            //Challenge Four
            int[] findRepeat = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            Console.WriteLine(ChallengeFour(findRepeat));
            //
            // Challenge Five
            Console.WriteLine(ChallengeFive(numArray));
            //
            ChallengeSix();
            ChallengeSeven();
            ChallengeEight();
        }

        //Mike.
        public static int ChallengeOne(string userInput)
        {

            int product = 1;
            string[] numStringArray = userInput.Split(',');
            int[] numArray = new int[numStringArray.Length];
            //This will catch the short array
            if (numStringArray.Length < 3) { return 0; }

            //This will perform the conversion
            try
            {

                for (int i = 0; i < numStringArray.Length; i++)
                {
                    if (!int.TryParse(numStringArray[i], out numArray[i]))
                    {
                        numArray[i] = 1;
                    }
                    if (i < 3) { product *= numArray[i]; }
                }
            }
            catch
            {
                //Will handle a non-integer.
                return 1;
            }
            return product;
        }

        //Kjell
        public static int ChallengeTwo(int[] numArray)
        {
            int sum = 0;

            foreach (int n in numArray)
            {
                sum += n;
            }
            if (sum == 0) { return 0; }
            else { return sum / numArray.Length; }

        }        
        public static int[] CreateNumArray()
        {
            bool isEnough = false;
            int userNum = 0;

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
                    Console.Write($"Enter number {i + 1} of {userNum}: ");
                    string userInput = Console.ReadLine();
                    int testNum = ConvertStringToInt(userInput);
                    if (testNum > 0)
                    {
                        numArray[i] = testNum;
                        isAcceptable = true;
                    }
                }
            }
            return numArray;
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
        //Matt
        public static void ChallengeThree()
        {
            //Worked with Matt

            // Total of nine character per line
            // To Center it up going to need to currentNum / length + 1
            // subtract the amount of character  

            string[] masterString = new string[9];
            int counter = 0;
            int numSpace = 4;
            int numAst = 1;
            //0000*0000
            //000***000
            //00*****00

            //Upper Diamond Half
            while (numSpace >= 0)
            {
                for (int i = 0; i < masterString.Length; i++)
                {
                    if (counter < numSpace)
                    {
                        masterString[i] = " ";
                    }
                    if (counter >= numSpace && counter < (numSpace + numAst))
                    {
                        masterString[i] = "*";
                    }
                    else
                    {
                        masterString[i] = " ";
                    }
                    counter++;
                }
                counter = 0;
                foreach (string s in masterString)
                {
                    Console.Write(s);

                }

                Console.Write("\n");
                numSpace--;
                numAst += 2;
            }
            masterString = new string[9];
            //Lower Half of Diamond
            // ********* <--Already Displayed
            // 0*******0
            // 00*****00
            // 000***000

            numSpace = 1;
            numAst = 7;
            counter = 0;
            while (numSpace <= 4)
            {
                for (int i = 0; i < masterString.Length; i++)
                {
                    if (counter < numSpace)
                    {
                        masterString[i] = " ";
                    }
                    if (counter >= numSpace && counter < (numSpace + numAst))
                    {
                        masterString[i] = "*";
                    }
                    else
                    {
                        masterString[i] = " ";
                    }
                    counter++;
                }
                counter = 0;
                foreach (string s in masterString)
                {
                    Console.Write(s);
                }
                Console.Write("\n");
                numSpace++;
                numAst -= 2;
            }

        }
        //Kjell
        public static int ChallengeFour(int[] intArr)
        {
            //Completed with Kjell


            int intArrLength = intArr.Length;
            int tempValue = 0;
            int mostRepeatedIdx = 0;
            //Each index for comparison
            for (int i = 0; i < intArrLength; i++)
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
                if (count > tempValue)
                {
                    tempValue = count;
                    mostRepeatedIdx = i;
                }
            }

            return intArr[mostRepeatedIdx];
        }
        //David
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
        //Jordan
        public static void ChallengeSix()
        {
            Console.WriteLine("Please enter your most FAVORITE word");
            string userInput = "\n" + Console.ReadLine();
            string path = "../words.txt";            
            File.AppendAllText (path, userInput);

        }
        //Jordan
        public static void ChallengeSeven()
        {
            string path = "../words.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
        }
        //Solo
        public static void ChallengeEight()
        {
            string path = "../words.txt";
            string[] line = File.ReadAllLines(path);
            int lineToRemove = 1;
            string[] removedLine = new string[line.Length - 1];
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (i != lineToRemove)
                {
                    removedLine[counter] = line[i];
                    counter++;
                }
            }
                File.WriteAllLines(path, removedLine);
                File.WriteAllLines(path, line);
        }
        //Solo
        public static void ChallengeNine()
        {

        }

    }
}


