using System.Threading;
using System.Diagnostics;
using System.Timers;
using System;



namespace Pass_Week5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RB WAZ ERE!!!");
            Console.WriteLine("Joel here");
            Console.WriteLine("Anurag here");
            Console.WriteLine("Hey, Caleb here!");
            Console.WriteLine("Matty was here");
            //Q3();

            //float C = hypo(3,4);

            //Console.WriteLine(C);

            //int i = 0; 
            //int j = 0;
            //Console.WriteLine(biggerOrSmaller(i,j));

            //alphaNumTest();
            //searchtest();
            rickRoll();

        }
        //method to test alphanum
        static void alphaNumTest()
        {
            string input;
            do
            {
                Console.WriteLine("");
                input = Console.ReadLine();
                char[] charArray = input.ToCharArray();

                bool iAN = isAlphaNumeric(charArray);
                Console.WriteLine(iAN);
            } while (input != "exit");
        }


        //method to test search array
        static void searchtest()
        {
            string[] newArray = { "matt", "dave", "trent", "linus",};

            Nullable<int> index= searchArray("gary",newArray);
            //using null for when search is unseccesful. 
            if (index == null)
            { 
            Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine($"index location: {index}");
            }
        }

        //search for word in arrray, return index number
        static Nullable<int> searchArray(string words, string[] currentArry)
        {
            for (int i = 0; i < currentArry.Length; i++)
            {
                if (currentArry[i] == words)
                {
                    return i;
                }           
            }
            return null;        


            //if we dont find the string in the array, we return a null hence nullable int. meaning not found
        }

        static bool isAlphaNumeric(char[] characterArray)         
        { 
            
            int i = characterArray.Length;
            bool hasNum = false;
            bool hasAlpha = false;

            foreach (char c in characterArray)
            {
                if (hasAlpha && hasNum)
                {
                    break; 
                }

                if (!hasNum)
                {
                    if (c >= '0' && c <= '9')
                    {
                        hasNum = true;                    
                    }
                }
                if (!hasAlpha) 
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        hasAlpha = true;
                    }
                    else if ((c >= 'a' && c <= 'z'))
                    {
                        hasAlpha = true;
                    }
                }               

            }
                        
            return hasNum && hasAlpha; 
        
        }

        //matts C++ mongrel solution, dont stare at it too hard, might give you a headache :P
        static string CIN()
        {
            return Console.ReadLine();

        }

        static void COUT(string input)
        {
            Console.WriteLine(input);
        }

        //pythag theorem, return C
        static float hypo(float a, float b)
        {
            float C = MathF.Sqrt(a * a + b * b);
            return C;
        }

        //example of Q3 for A1
        static void Q3()
        {
            //q3 exampler
            //tasks
            //ask for password 3 times, count valid inputs
            // check for alphanum input 
            //welcome user when password is correct
            //pre-defined password, (alphanumeric)
            //after welcome, say goodbye
            int guesses = 0;
            string password = "brainWrek4";
            string userInput = null;


            do
            {
                Console.Write("Insert Password:");
                userInput = Console.ReadLine();

                bool hasNum = false;
                bool hasAlpha = false;


                foreach (char c in userInput)
                {
                    if (hasAlpha && hasNum)
                    {
                        break;
                    }

                    if (!hasNum)
                    {
                        // https://learn.microsoft.com/en-us/dotnet/api/system.char.issymbol?view=net-7.0
                        if (c >= '0' && c <= '9')
                        {
                            hasNum = true;
                            //Console.WriteLine("has num");
                            continue;

                        }
                    }

                    if (!hasAlpha)
                    {
                        if (c >= 'a' && c <= 'z')
                        {
                            hasAlpha = true;
                            //Console.WriteLine("has letter");
                            continue;
                        }
                        if (c >= 'A' && c <= 'Z')
                        {
                            hasAlpha = true;
                            //Console.WriteLine("has letter");
                            continue;
                        }

                    }
                    //how to check if symbol, thankyou Matthew Rohrich!!!!
                    //if (Char.IsSymbol(character))

                }

                bool validInput = hasNum && hasAlpha;

                if (validInput)
                {
                    guesses++;
                }
                else
                {
                    Console.WriteLine("bad input!!!");
                }


            } while (guesses < 3 && userInput != password);

            if (userInput == password)
            {
                Console.WriteLine("correct password");
            }
            else
            {
                Console.WriteLine("Your such a bad hacker, gtfo");
            }

        }


        static void rickRoll()
        {
            string charLeft  = "\n\t   (._.)\n\t  <)  )-\n\t   |  |\n";
            string charRight = "\n\t   (._.)\n\t  -)  )>\n\t   |  |\n";


            int i = 1500;
            Console.WriteLine("Never gonna give you up");
            Console.Write(charLeft);
            Thread.Sleep(i);

            Console.Clear();
            Console.WriteLine("Never gonna let you down");
            Console.Write(charRight);
            Thread.Sleep(i);

            Console.Clear();
            Console.WriteLine("Never gonna run around and desert you");
            Console.Write(charLeft);
            Thread.Sleep(i);

            Console.Clear();
            Console.WriteLine("Never gonna make you cry");
            Console.Write(charRight);
            Thread.Sleep(i);

            Console.Clear();
            Console.WriteLine("Never gonna say goodbye");
            Console.Write(charLeft);
            Thread.Sleep(i);

            Console.Clear();
            Console.WriteLine("Never gonna tell a lie and hurt you");
            Console.Write(charRight);
            Thread.Sleep(i);
            Console.Clear();

            Console.WriteLine("YOU GOT RICK ROLLED!!");
        }

        //basic function that returns string
        static string biggerOrSmaller(int i, int j)
        {
            if (i < j)
                return "bigger";
            if (i > j)
                return "smaller";
            
            return "equal";          
        
        }

    }
}