using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Human : Mamals
    {
        public bool isEmployed { get; set; }

        public Human(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }

        public void FreeWill()
        {
            Console.WriteLine($"{Name} is expressing their free will");
        }

        // Add the isEmployed property to the DisplayInfo method 

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Are they employed: " + isEmployed);
        }
    }
}
