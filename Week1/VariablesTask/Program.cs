using System;

namespace VariablesTask {
    class Program {
        static void Main(string[] args) {
                // Gathering Information
                String Firstname;
                String Surname;
                String StudentID;
                String YOB;
                String CurrentYear;

                Console.WriteLine("First Name: "); {
                Firstname = Console.ReadLine();
                }
                Console.WriteLine("Surname: "); {
                Surname = Console.ReadLine();
                }
                Console.WriteLine("StudentID: "); {
                StudentID = Console.ReadLine();
                } 
                Console.WriteLine("Year Of Birth: "); {
                YOB = Console.ReadLine();
                } 
                Console.WriteLine("Current year: "); {
                CurrentYear = Console.ReadLine();
                }
                //converting into integers
                int YOBint;
                int CurrentYearint;

                YOBint = int.Parse(YOB);
                CurrentYearint = int.Parse(CurrentYear);

                // Displaying Information
               Console.WriteLine("Your Name: " + (Firstname + " " + Surname)); {
               }
               Console.WriteLine("Your Age: " + (CurrentYearint - YOBint)); {
               }
        }
    }
}