namespace _04.SoftwareUniversityLearningSystem
{
    internal class CurrentStudent : Student
    {
        public CurrentStudent(
            string firstName, 
            string lastName, 
            int age, 
            int studentNumber, 
            double averageGrade, 
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Current course: {1}", base.ToString(), this.CurrentCourse);
        }
    }
}