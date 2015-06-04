using System;

namespace _04.SoftwareUniversityLearningSystem
{
    class DropoutStudent : Student
    {
        public string DropoutReason { get; set; }

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            DropoutReason = dropoutReason;
        }

        public string Reapply()
        {
            return String.Format("{0}; Droput reason: {1}", ToString(), DropoutReason);
        }
    }
}
