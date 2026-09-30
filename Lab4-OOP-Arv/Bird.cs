using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab5_OOP_Arv
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

        // Add the FeatherColor property to the DisplayInfo method 

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"They have {FeatherColor} feathers");
        }

    }
}
