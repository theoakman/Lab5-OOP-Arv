namespace Lab5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Making a cat object from the cat subclass and also assigns a new value over gender, overwriting the default "Unkown"

            Cat cat = new Cat("Mio");
            cat.Gender = "Female";

            // Making 3 dogs from 3 different subclasses, the specific breeds are also subclasses from the Dog subclass
            // I aslo try to overwrite the default values of the properties like Age and Gender

            Dog dog1 = new Dog("Lilly");
            dog1.Gender = "Female";
            dog1.Age = 6;

            GermanShepherd dog2 = new GermanShepherd("Fido");
            dog2.Gender = "Male";
            dog2.Age = 4;

            Labrador dog3 = new Labrador("Bruno");
            dog3.Gender = "Male";
            dog3.Age = 9;

            // Making a bird from the bird subclass
            // I aslo try to overwrite the default values of the weight property
            Bird bird = new Bird("Polly");
            bird.Weight = 0.2;



            dog1.MakeSound();
            dog1.IsPlaying();
            dog1.DisplayInfo();

            Console.WriteLine();

            dog2.MakeSound();
            dog2.IsPlaying();
            dog2.Working();
            dog2.DisplayInfo();

            Console.WriteLine();

            dog3.MakeSound();
            dog3.IsPlaying();
            dog3.Guideing();
            dog3.DisplayInfo();

            Console.WriteLine();

            cat.MakeSound();
            cat.IsSleeping();
            cat.DisplayInfo();

            Console.WriteLine();

            bird.MakeSound();
            bird.IsFlying();
            bird.DisplayInfo();

            Console.WriteLine();

            Human human = new Human("Harry");
            human.MakeSound();
            human.FreeWill();
            human.DisplayInfo();


        }
    }
}
