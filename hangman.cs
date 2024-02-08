using System;
class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine(" The answer is the name of food!");

        Console.WriteLine("_ _ _ _ _ ");

        string[] letters = new string[] { "P", "I", "Z", "Z", "A"};
        string[] answer = new string[10];

        int answer = 5;

        foreach (var letters in answer)
        {
            Console.WriteLine($"What letter do you choose {letters}?");
            string input = Console.ReadLine().ToLower();

            if (input == ("P")
                || input == ("I")
                || input == ("Z")
                || input == ("A"))

                
            {
                theDead[deathindex] = letters;
                correctanswer++;
                Console.WriteLine($"{letters} That is correct!");

            }
            else (input == ("B")
                || input == ("C")
                || input == ("D")
                || input == ("E"))



            {
                Console.WriteLine($"{letters} That is incorrect!");

            }
        }

        Console.WriteLine("\n The following people are killed.");
        foreach (var theDeadList in theDead)
        {
            Console.WriteLine(theDeadList);
        }



        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();


    }




}



Console.WriteLine("Hello, World!");
