using System;

namespace GuessTheNumber {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();

            int Answer = random.Next(26);
            int counter = 0;
            int guesses = 1;
            int WoL = 0;

            Console.WriteLine("Guess the number between 0 and 25");
            string Guess = Console.ReadLine();

            while (counter < 6) {
                int.TryParse(Guess, out int Guess_Int);
                if (Guess_Int != Answer) {
                    if (Guess_Int > Answer) {
                    Console.WriteLine("Guess is greater than the number");
                    } else {
                    Console.WriteLine("Guess is less than the number");
                    }
                ++counter;
                ++guesses;
                Console.WriteLine("New Guess: ");
                Guess = Console.ReadLine();
                } else {
                    counter = 6;
                    ++WoL;
                } 
            }
            Console.WriteLine("Game Over.");
            if (WoL == 1) {
                Console.WriteLine("You Won!\nThat took " + guesses + " guess(es).");
            } else {
                Console.WriteLine("You Lose.\nThe number was " + Answer);
            } 
        }
    }
}
