using System;

namespace Excercise2 {
    class Program {
        static void Main(string[] args) {

            String username;
            String password;

            Console.WriteLine("Enter Username: "); 
                username = Console.ReadLine();

            if (username == "Curvezy") {

                Console.WriteLine("Enter Password: "); 
                    password = Console.ReadLine();

                if (password == "103641460") {
                    Console.WriteLine("Login succesful!");

                } else {
                    Console.WriteLine("Login unsuccesful. Incorrect Password.");
                }
            } else {
                Console.WriteLine("Username doesnt exist.");
            }
        }
    }
}