using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class GermanShepherd : Dog
    {
        public bool IsPoliceDog { get; set; } = true;

        public GermanShepherd(string name) : base(name)
        {

        }

        public void Working()
        {
            Console.WriteLine($"{Name} is working");
        }


        // Add the IsPoliceDog property to the DisplayInfo method 

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Are they a police dog: " + IsPoliceDog);
        }

    }
}
