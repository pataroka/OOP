namespace _04.SoftwareUniversityLearningSystem
{
    internal class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(
            string firstName, 
            string lastName, 
            int age, 
            int studentNumber, 
            double averageGrade, 
            string currentCourse, 
            int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; NumberOfVisits: {1}", base.ToString(), this.NumberOfVisits);
        }
    }
}