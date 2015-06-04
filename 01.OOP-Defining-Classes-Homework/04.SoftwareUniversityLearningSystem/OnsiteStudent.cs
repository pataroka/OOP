using System;

namespace _04.SoftwareUniversityLearningSystem
{
    class OnsiteStudent : CurrentStudent
    {
        public int NumberOfVisits { get; set; }

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            NumberOfVisits = numberOfVisits;
        }

        public override string ToString()
        {
            return String.Format("{0}; NumberOfVisits: {1}", base.ToString(), NumberOfVisits);
        }
    }
}
