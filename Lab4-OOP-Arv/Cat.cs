using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Cat : DomesticatedAnimal
    {

        public int LivesLeft { get; set; } = 8;

        public Cat(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is meowing");
        }

        public void IsSleeping()
        {
            Console.WriteLine($"{Name} is sleeping");
        }


        // Add the LivesLeft property to the DisplayInfo method 

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"They have {LivesLeft} lives left...");
        }
    }
}
