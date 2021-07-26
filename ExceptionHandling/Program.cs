using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 15: ");
            var input = Console.ReadLine();

            try {
                int Num = int.Parse(input);
                int Sum = 0;

                if(Num < 0) {
                    throw new NegativeNumberException("Negative number was detected, Application Failed");
                }
                if(Num > 15) {
                    throw new Above15NumberException("Number Was above 15, Application Failed");
                }

                while (Num != 0) {
                Sum += Num % 10;
                Num /= 10;
                }
                Console.WriteLine("The Sum is " + Sum);

            } catch (FormatException e) {
                Console.WriteLine("You entered an input that cannot be converted into an integer: " + e.Message);
            } catch (NegativeNumberException e) {
                Console.WriteLine(e.Message);
            } catch (Above15NumberException e) {
                Console.WriteLine(e.Message);
            } finally {
                DateTime now = DateTime.Now;
                Console.WriteLine(DateTime.Now);
            }
        }
        class NegativeNumberException: Exception {
            public NegativeNumberException(string message): base(message) {}
        }
        class Above15NumberException: Exception {
            public Above15NumberException(string message): base(message) {}
        }
    }
}
