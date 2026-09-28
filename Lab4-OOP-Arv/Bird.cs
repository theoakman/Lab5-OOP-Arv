using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab4_OOP_Arv
{
    internal class Bird : Animal
    {
        public string FeatherColor { get; set; } = "Blue";

        public Bird(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is shirping");
        }

        public void IsFlying()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }
}
