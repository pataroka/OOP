namespace _04.SoftwareUniversityLearningSystem
{
    internal class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Full name: {0} {1}; Age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}