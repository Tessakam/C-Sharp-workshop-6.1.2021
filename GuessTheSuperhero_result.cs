// Goal: create a guessing game that ask the player for a random superhero
// Our game will have two classes: Game and Program
// The method Play will run the game.


using System;

namespace GuessTheSuperhero
{
    class Game
    {
        
		// Add two variables, one for the players input and one for the target
		// Add an string array of your superheroes the player needs to guess
		
        string Input = "";
        string[] Hero = { "Spider-Man", "Hulk", "Wonderwoman" };
		int Target;
		
		// Our random number will be used to select an element. 
		Random RandomNumber = new Random();

        public void Play()
        {
            
			// Select a random superhero, this depends on the lenght of your array
			Target = RandomNumber.Next(Hero.Length);

			// The player will see the different superheroes
            Console.Write(" Guess which Superhero I am thinking of... is it ");
			
			// Create a for loop for your superheroes 
			
            for (int i = 0; i < Hero.Length; i++)
            {
                if (i == (Hero.Length - 1))
                    Console.Write("or " + Hero[i] + "? ");
                else
                    Console.Write(Hero[i] + ", ");
            }

            Input = Console.ReadLine();
			
			// Compare what the player has typed to the random element from your superhero array by using an if else statement.

            if (Input == Hero[Target])
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
            else
            {
                Console.WriteLine("Not a match. Try again!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();
            }

			// Add a method to "read" the input when the player presses a key
            Console.ReadKey();
        }
    }
	
    class Program
    {
        static void Main()
        {
            // Make an instance (object) of your class and call your method
			// Use "dotnet run" in the terminal to play your game!
			Game theGame = new Game();
            theGame.Play();	

        }
    }
}