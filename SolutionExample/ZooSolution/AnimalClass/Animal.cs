using System;

namespace AnimalClass
{
    public class Animal {
        public string Name { get; set;}
        public string Sound { get; set;}


        public string GetInfo() {
            return $"{this.Name} {this.Sound}";
        }
    }
}
