using System;

namespace NumberGuesser
{
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();//Run function to get info

            GreetUser();//ask for user's name and greet

            while (true)
            {



                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);


                //init guess var
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get user's input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match Guess to correct number
                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //print success number
                PrintColorMessage(ConsoleColor.Yellow, "Correct! You guessed it!");


                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");
                //get answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Michael Dickmann";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        //ask user's name and greet
        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Output success message
            Console.ForegroundColor = color;

            //Write out app info
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
