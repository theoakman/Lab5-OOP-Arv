using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP_Arv
{
    internal class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; } = 5;
        public string Gender { get; set; } = "Unkown";
        public bool IsHungry { get; set; } = false;
        public double Weight { get; set; } = 4.5;

        
        public Animal(string name)
        {
            Name = name;
        }




        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("This text should not appear");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nThey are a {Gender}\nAre they hungry? {IsHungry}\nThey weigh {Weight} Kg\n\n");
        }

    }
}
