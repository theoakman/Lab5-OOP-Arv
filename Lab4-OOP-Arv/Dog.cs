using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab4_OOP_Arv
{
    internal class Dog : Animal
    {
        public string Species { get; set; } = "Maltese";
        public Dog(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is barking");
        }

        public void IsPlaying()
        {
            Console.WriteLine($"{Name} is playing");
        }

    }
}
