namespace Lab4_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Next up:
            // Ett av djuren du skapat ovan ska du sedan dela
            // upp i två nya klasser som ärver från det djuret. 


            Cat cat = new Cat("Pyssen");
            Dog dog = new Dog("Lilly");
            Bird bird = new Bird("Polly");

            cat.MakeSound();
            cat.IsSleeping();
            cat.DisplayInfo();

            dog.MakeSound();
            dog.IsPlaying();
            dog.DisplayInfo();

            bird.MakeSound();
            bird.IsFlying();
            bird.DisplayInfo();

        }
    }
}
