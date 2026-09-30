using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Animal
    {


        // Gives every property except for name a default value,
        // so when making a new object based on the Animal class you always have to at least give the object a Name value

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

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nThey are {Gender}\nAre they hungry? {IsHungry}\nThey weigh {Weight} Kg");
        }

    }
}
