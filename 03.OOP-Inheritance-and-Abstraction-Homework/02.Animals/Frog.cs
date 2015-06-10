namespace _02.Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, string gender, string color)
            : base(name, age, gender)
        {
            this.Color = color;
        }

        public string Color { get; set; }

        public void Swim()
        {
            Console.WriteLine("{0} says: \"I'm swimming!\"", this.Name);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says: \"Croak!\"", this.Name);
        }
    }
}