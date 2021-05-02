using System;

namespace GuessTheNumber {
<<<<<<< HEAD
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
                Console.WriteLine("You Won!\nThat took " + guesses + " guesse(s).");
            } else {
                Console.WriteLine("You Lose.\nThe number was " + Answer);
            } 
        }
    }
}
=======
    class RandomGenerator {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(26);
            Console.WriteLine("Guess the Number: ");
            string answer = Console.ReadLine();

            int.TryParse(answer, out int Answer_Int);
            int guesses = 6;


            if (Answer_Int == num) {
                guesses = 0;
            } do {
                if (Answer_Int > num) {
                    Console.WriteLine("Your guess was greater than the number.");
                } else {
                   Console.WriteLine("Your guess was less than the number.");
                }
                
                guesses--;
                Console.WriteLine("You have " + guesses + " guesses left.");
                Console.WriteLine("Enter a new guess: ");

            } while (guesses != 0);
            //Console.WriteLine("CONGRATS! \nYou Guessed the number!");
        }
    }
}
>>>>>>> 05399b614bd0d71842f27a328d2776a5227d4877
