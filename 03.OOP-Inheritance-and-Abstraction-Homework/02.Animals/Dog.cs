namespace _02.Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender, string breed)
            : base(name, age, gender)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public void TailWag()
        {
            Console.WriteLine("{0} says: \"I'm wagging my tail!\"", this.Name);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says: \"Woof!\"", this.Name);
        }
    }
}