
using System;
using System.Xml.Linq;

namespace HangTheMan
{
    public class Program
    {
        static void Main(string[] args)
        {
            //greeting
            Console.WriteLine("Hello! What's your name?\n");

            //ask player for name
            string? lastName = Console.ReadLine();
            Console.WriteLine("Hi, " + lastName + "!");
            Console.WriteLine("Let's play Hangman! Guess the word below: \n");

            Random randomWord = new Random(); //create random variable
            string[] words = new string[] { "soup", "ham", "milk", "pie" }; //the game dictionary
            int wordSelector = randomWord.Next(words.Length); //use the random variable to choose a word from the array
            string selectedWord = words[wordSelector]; //set variable selectedWord to the word chosen from the array
            char[] gameBlanks = new char[selectedWord.Length]; //set number of gameBlanks characters to the length of the 

            for (int gameBlankIndex = 0; gameBlankIndex < gameBlanks.Length; gameBlankIndex++)
            {
                gameBlanks[gameBlankIndex] = '_'; //set characters of the answerbook to underscores
            }

            int allowedGuess = selectedWord.Length + 5; //set the allowed number of 

            //set and print allowed guesses
            Console.WriteLine("The number of letters in this word is " + selectedWord.Length + ".");
            Console.WriteLine("You have " + allowedGuess + " tries to guess the word.");

            //debugging
            Console.WriteLine("Hint! Word is a food. ");

            //while loop for the game ,, basically keeps running until break;
            while (true)
            {
                //print out the word's blanks
                for (int answerBookIndex = 0; answerBookIndex < gameBlanks.Length; answerBookIndex++)
                {
                    Console.Write(gameBlanks[answerBookIndex]);
                }

                Console.WriteLine(); //new line for legibility
                string? playerGuess = Console.ReadLine(); //reads the player's input

                //when the player gets a letter right
                if (playerGuess != null && selectedWord.Contains(playerGuess[0])) //checks if the guess is right
                {
                    Console.WriteLine("Correct!");

                    int guessPosition = selectedWord.IndexOf(playerGuess[0]); //set the int to the guess's index in the word 
                    gameBlanks[guessPosition] = playerGuess[0]; //changes gameBlanks to show the guess in the right blank
                }
                //when the player gets a letter wrong
                else
                {
                    Console.WriteLine("Wrong!");

                    --allowedGuess; //moves the player towards lose con
                    Console.WriteLine("You have " + allowedGuess + " guesses left."); //prints allowed guesses left
                }

                /*if (Array.IndexOf(answerBook, '_') == -1) //this is another option for the win condition
                {
                    Console.WriteLine("Win!");
                }*/

                if (gameBlanks.Contains('_') != true) //win condition by checking if the gameBlanks array still has "_"s or not
                {
                    for (int answerBookIndex = 0; answerBookIndex < gameBlanks.Length; answerBookIndex++) //prints the word again
                    {
                        Console.Write(gameBlanks[answerBookIndex]);
                    }
                    Console.WriteLine("\nWow! You Win!"); //win message
                    break; //breaks the while loop, ends the game.
                }

                if (allowedGuess == 0) //lose condition
                {
                    Console.WriteLine("YOU LOST!!! HAHHAHA");
                    break; //same thing
                }


            }
        }
    }
}