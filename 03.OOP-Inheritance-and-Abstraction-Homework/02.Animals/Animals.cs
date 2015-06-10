namespace _02.Animals
{
    using System;

    public static class Animals
    {
        public static void Main()
        {
            Cat femaleCat = new Kitten("Masha", 2, "curly");
            Cat maleCat = new Tomcat("Garfield", 2, "straight");
            Dog dog = new Dog("Sharo", 3, "male", "Poduenska podobrena");
            Frog frog = new Frog("Kermitt", 25, "M", "green");

            Console.WriteLine(femaleCat);
            Console.WriteLine(maleCat);
            Console.WriteLine(dog);
            Console.WriteLine(frog);

            frog.Swim();
            maleCat.ProduceSound();
            femaleCat.Cleaning();
            dog.TailWag();
        }
    }
}
