using System;

namespace AssessmentTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to roll the dice?");
            string Start = Console.ReadLine();

            while (Start == "yes") {
                Console.WriteLine("How many times would you like to roll?");
                string Rolls = Console.ReadLine();
                
                if (int.TryParse(Rolls, out int NumOfRolls) && Rolls.Length > 0) {
                }

                Random random = new Random();

                int sum = 0;
                int Num = NumOfRolls;
                int[] DiceRoll;
                float average = 0.0F;
                DiceRoll = new int[Num];
                    for(int i = 0; i <= Num - 1; i++) {
                        DiceRoll[i] = random.Next(7);
                        sum +=  DiceRoll[i];
                    }
                    average = (float)sum / DiceRoll.Length;
                    if (Start == "yes") {
                        Console.WriteLine("The Dice rolled a " + string.Join(", ", DiceRoll));
                        Console.WriteLine("The Average was " + average);
                        Console.WriteLine("The total was " + sum);
                    }
                Console.WriteLine("Would you like to role again?");
                Start = Console.ReadLine();
            }
            Console.WriteLine("Okay Goodbye.");
        }
    }
}
