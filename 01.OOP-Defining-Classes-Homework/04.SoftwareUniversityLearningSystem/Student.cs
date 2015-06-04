namespace _04.SoftwareUniversityLearningSystem
{
    class Student : Person
    {
        public int StudentNumber { get; set; }
        public double AverageGrade { get; set; }

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            StudentNumber = studentNumber;
            AverageGrade = averageGrade;
        }

        public override string ToString()
        {
            return string.Format("{0}\nStudent number: {1}; Average grade: {2}", base.ToString(), StudentNumber, AverageGrade);
        }
    }
}
