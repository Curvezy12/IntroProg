using System;
using Xunit;
using AnimalClass;

namespace ProjectTest
{
    public class AnimalTest
    {

        public Animal TestAnimal { get; set; }
        public AnimalTest() {
            this.TestAnimal = new Animal();
            this.TestAnimal.Name = "Lion";
            this.TestAnimal.Sound = "Roar";
        }

        [Fact]
        public void GetInfoTest()
        {
            Assert.Equal("Lion Roar", this.TestAnimal.GetInfo());
        }
    }
}
