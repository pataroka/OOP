namespace _04.SoftwareUniversityLearningSystem
{
    internal class Student : Person
    {
        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber { get; set; }

        public double AverageGrade { get; set; }

        public override string ToString()
        {
            return string.Format(
                "{0}\nStudent number: {1}; Average grade: {2}", 
                base.ToString(), 
                this.StudentNumber, 
                this.AverageGrade);
        }
    }
}