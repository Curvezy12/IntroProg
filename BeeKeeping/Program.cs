using System;
using System.Collections.Generic;

namespace BeeKeeping {
    class Program {
        static void Main(string[] args) {

            BeeHive One = new BeeHive(4);
            BeeHive Two = new BeeHive(3);

            Bee John = new Bee("John", 3.2f);
            Bee Paul = new Bee("Paul", 2.7f);
            Bee George = new Bee("George", 1.1f);
            Bee Ringo = new Bee("Ringo", 2.0f );

            One.Bees.Add(John);
            One.Bees.Add(Paul);
            One.Bees.Add(George);
            One.Bees.Add(Ringo);

            Bee Kurt = new Bee("Kurt", 2.3f);
            Bee Dave = new Bee("Dave", 7.4f);
            Bee Krist = new Bee("Krist", 1.5f);

            Two.Bees.Add(Kurt);
            Two.Bees.Add(Dave);
            Two.Bees.Add(Krist);

            Console.WriteLine("How many days has it been since harvested?");
            int Days = int.Parse(Console.ReadLine());
            Console.WriteLine("Beehive One Has " + One.CollectHoney(Days) + " Honey");
            Console.WriteLine("Beehive Two Has " + Two.CollectHoney(Days) + " Honey");
        }
    }
    public class BeeHive {
        public List<Bee> Bees {get; set;}
        public int MaxBees { get; set;}
        public BeeHive(int maxBees)
        {
            this.Bees = new List<Bee>();
            MaxBees = maxBees;
        }
        public int CollectHoney(int days) {
            //add bee size
            //amount expressed as float
            int amount = (int)(days * this.Bees.Count * 0.2);
            return amount;
        }
    }
    public class Bee {
        public string Name { get; set; }
        public float Size { get; set;}
        public Bee(string name, float size) {
            this.Name = name;
            this.Size = size;
        }
    }
}