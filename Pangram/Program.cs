using System;
using System.Collections.Generic;



namespace Pangram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Intro();
            EnterString();
            TryAgain();
            //Console.ReadLine();            
        }


        static void Intro()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Greetings, {userName}. We'll check if a phrase you enter is a PANGRAM.");
            Console.WriteLine("A pangram is a sentence or phrase that contains ALL 26 letters of the alphabet.");
            Console.WriteLine();
            }
        static void EnterString()
        {
            Console.WriteLine("Enter a phrase");
            string userPhrase = Console.ReadLine();

            // string userPhrase = RemoveDuplicateChars(Console.ReadLine());

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            //List<string> Temp = new List<string>();

            //foreach (char x in alphabet)
            foreach (char y in userPhrase)
            {
                //foreach (char y in userPhrase)
                foreach (char x in alphabet)
                {
                    if (y == x)
                    {
                        count++;  
                    }
                }
            }
            if (count >= 26)
            {
                Console.WriteLine("Your phrase is a pangram");
            }
            //if (count != 26)
            else
            {
                Console.WriteLine("Your phrase is NOT a pangram");
            }
        }

        //Option to keep going
        static void TryAgain()
            {        
                Console.WriteLine("Would you like to try another phrase?");
                string yesOrNo = Console.ReadLine();
        
                if (yesOrNo == "yes")
                {
                    EnterString();
                }
                if (yesOrNo == "no")
                {
                    Console.WriteLine("Have a good day.");
                }
                else
                {
                    Console.WriteLine("Not a valid answer.  Try again with a YES or a NO.");
                    TryAgain();
                }
            }
        
    }
}
