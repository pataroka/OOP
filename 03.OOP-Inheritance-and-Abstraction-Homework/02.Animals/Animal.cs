namespace _02.Animals
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal : ISoundProducible
    {
        private int age;

        private bool gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a positive number!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                if (this.gender)
                {
                    return "Male";
                }

                return "Female";
            }

            set
            {
                HashSet<string> checkM = new HashSet<string> { "male", "Male", "m", "M" };
                HashSet<string> checkF = new HashSet<string> { "female", "Female", "f", "F" };
                if (checkM.Contains(value))
                {
                    this.gender = true;
                }
                else if (checkF.Contains(value))
                {
                    this.gender = false;
                }
                else
                {
                    throw new ArgumentException("Must specify a correct gender!", "value");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.Gender);
        }

        public abstract void ProduceSound();
    }
}
