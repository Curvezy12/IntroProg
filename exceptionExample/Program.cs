using System;

namespace exceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            var input = Console.ReadLine();

            try {
                int Num = int.Parse(input);

                if(Num < 0) {
                    throw new NegativeNumberException("Negative number was detected");
                }
                Console.WriteLine(Num);

            } catch (FormatException e) {
                Console.WriteLine("You entered an input that cannot be converted into an integer: " + e.Message);
            } catch (NegativeNumberException e) {
                System.Console.WriteLine(e.Message);
            } catch (Exception e) {
                Console.WriteLine("Something whent wrong :( " + e.Message);
            } finally {
                Console.WriteLine("Thanks for using this program, please come again!");
            }
        }
        class NegativeNumberException: Exception {
            public NegativeNumberException(string message): base(message) {}
        }
    }
}
