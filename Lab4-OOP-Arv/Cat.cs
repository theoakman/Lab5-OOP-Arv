using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP_Arv
{
    internal class Cat : Animal
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
    }
}
