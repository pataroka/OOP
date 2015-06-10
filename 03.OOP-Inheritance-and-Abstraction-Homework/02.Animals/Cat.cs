namespace _02.Animals
{
    using System;

    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, string gender, string hairType)
            : base(name, age, gender)
        {
            this.HairType = hairType;
        }

        public string HairType { get; set; }

        public void Cleaning()
        {
            Console.WriteLine("{0} says: \"I'm cleaning myself with my tongue!\"", this.Name);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says: \"Myao!\"", this.Name);
        }
    }
}
