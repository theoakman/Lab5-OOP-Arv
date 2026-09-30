using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Labrador : Dog
    {
        public bool IsGuideDog { get; set; } = true;

        public Labrador(string name) : base(name)
        {

        }

        public void Guideing()
        {
            Console.WriteLine($"{Name} is guideing their owner");
        }

        // Add the IsGuideDog property to the DisplayInfo method 

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Are they a guide dog: " + IsGuideDog);
        }

    }
}
