namespace _04.SoftwareUniversityLearningSystem
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("Full name: {0} {1}; Age: {2}", FirstName, LastName, Age);
        }
    }
}
