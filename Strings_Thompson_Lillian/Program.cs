using System;

namespace Strings_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Askes user to input a character and assigns input to a variable
            Console.WriteLine("Please input a character!");
            char myChar = Console.ReadKey().KeyChar;
            
            // Checks if the character user entered is a letter
            bool isLetter = Char.IsLetter(myChar);

            // Prints the results to console 
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");

            // Asks user a question and saves reponse to a varialbe, sentence
            Console.WriteLine("Why do you like video games");
            string sentence = Console.ReadLine();

            // Ask user to enter a word, saves response to a variable called word
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            // Check if the word is in sentence
            bool isIn = sentence.Contains(word);

            // Prints if the word is in the sentence
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!"); 










        }

    }
}
