namespace _01.Persons
{
    using System;

    internal class Person
    {
        private int age;

        private string email;

        private string name;

        public Person(string name, int age, string email = null)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    throw new ArgumentException("Name must have a value!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ArgumentException("Age must be an integer between 1 and 100!");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value != null)
                {
                    if (value == string.Empty || !value.Contains("@"))
                    {
                        throw new ArgumentException("Not a valid email!");
                    }
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person: {0}, {1}, {2}", this.Name, this.Age, this.Email ?? "No email");
        }
    }
}