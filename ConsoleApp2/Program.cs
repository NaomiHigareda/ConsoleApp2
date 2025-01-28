using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //guessing game

            //generate a secret number
            Random random = new Random();

            int secret = random.Next(5);

            bool winning = false;
            //when user does not get a secret number correctly, keep asking to input
            //declare a variable to old user input 
            int guess = 0;
            bool wantToContinue = true; 
            while (wantToContinue == true)
            {
                while (!winning)
                {
                    //ask user to input a number to guess the secret number
                    Console.WriteLine("Please enter a number to guess the secret number");
                    guess = Convert.ToInt32(Console.ReadLine());
                    //if the number input is greater than secret number, tell user is to large, and ask them input a diferent number
                    if (guess > secret)
                    {
                        Console.WriteLine("The number you chose is to large than the secret number");
                    }
                    else if (guess < secret)
                    {
                        Console.WriteLine("The number you chose is to small");
                    }
                    else
                    {
                        //if the input is the secret number, the user win, the application exit
                        winning = true;
                    }
                }
            Console.WriteLine("You win!"); 
            Console.WriteLine("Do you want to continue to play? (Y/N)"); 
            //process continue play
            if (Console.ReadLine().ToLower().StartsWith("Y")) //if the user input Yes, Y
                {
                    wantToContinue = true; //set the flag to continue game
                    winning = false; //reset the result
                    secret = random.Next(5); //regenerate a random number
                }
            else
            {
                wantToContinue = false; //exit the game
            }
        }

            Console.WriteLine("Bye"); //exit program

            Console.ReadLine();
        }
    }
}
