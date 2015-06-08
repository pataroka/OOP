namespace _04.SoftwareUniversityLearningSystem
{
    internal class DropoutStudent : Student
    {
        public DropoutStudent(
            string firstName, 
            string lastName, 
            int age, 
            int studentNumber, 
            double averageGrade, 
            string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public string Reapply()
        {
            return string.Format("{0}; Droput reason: {1}", this.ToString(), this.DropoutReason);
        }
    }
}