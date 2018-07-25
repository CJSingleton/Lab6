using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CSingleton_Lab6
{
    class Program
    {   
        static Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
        // technically still using the random class, but this is said to be a better wat to generate random numbers.

        static void Main(string[] args)
        {
            string ExitCheck = "y";//exit procedure

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");//salutation
            ExitCheck = Console.ReadLine();//This program can be closed right away if the user chooses not to play.
             
            while (ExitCheck == "y")
            {
                Console.WriteLine("How many sides should the die have? (Please choose 4, 6, 8, 10, 12, or 20)");
                int dice = int.Parse(Console.ReadLine());
                while (!Regex.IsMatch(dice.ToString(), @"^(4|6|8|10|12|20)$"))//This validation layer limits the input to a set of 6 numbers.
                {
                    Console.WriteLine("Please enter a valid number!");
                    dice = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Roll 1: {Roll(dice)}");// calling the method "Roll"
                Console.WriteLine($"Roll 2: {Roll(dice)}");// calling the method again for a different random number.
                
                Console.WriteLine("Would you like to continue (y/n)?");
                ExitCheck = Console.ReadLine();
            }
        }
        public static int Roll(int num)
        {
            int rnd = rndNum.Next(1, num);
            return rnd;
        }
        
    }

}
