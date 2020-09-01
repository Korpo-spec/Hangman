using System;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Välj ett ord:");
            string word = Console.ReadLine();

            char[] lettersInWord = word.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("_ ");
            }
            
            System.Console.WriteLine();

            while (true)
            {
                
                
                
                if(lettersInWord.Contains(CheckValidInput())){



                }
            }
        }
        static char CheckValidInput(){

            string letterGuess = "hej";
            bool isLetter = true;
            while (letterGuess.Length != 1 ||  isLetter)
            {
                Console.WriteLine("Välj en bokstav:");
                
                letterGuess = Console.ReadLine();
                int hej;
                isLetter = int.TryParse(letterGuess, out hej);
            }

            return letterGuess.ToCharArray()[0];

        }
    }
}
