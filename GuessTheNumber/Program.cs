using System;

namespace GuessTheNumber {
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
                answer = Console.ReadLine(); 
            } while (guesses == 0);
            //Console.WriteLine("CONGRATS! \nYou Guessed the number!");
        }
    }
}
