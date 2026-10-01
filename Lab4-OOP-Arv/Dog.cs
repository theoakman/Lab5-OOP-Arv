using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab5_OOP_Arv
{
    internal class Dog : DomesticatedAnimal
    {
        public bool IsTrained { get; set; } = true;
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

        // Add the IsTrained property to the DisplayInfo method 

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Are they trained: " + IsTrained);
        }

    }
}
