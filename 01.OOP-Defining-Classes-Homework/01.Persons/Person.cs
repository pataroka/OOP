using System;

namespace _01.Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Trim() == String.Empty || value == null)
                {
                    throw new ArgumentException("Name must have a value!");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ArgumentException("Age must be an integer between 1 and 100!");
                }
                age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value != null)
                {
                    if (value == String.Empty || !value.Contains("@"))
                    {
                        throw new ArgumentException("Not a valid email!");
                    }
                }
                email = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Person: {0}, {1}, {2}", Name, Age, Email ?? "No email");
        }
    }
}
