using System;

namespace _04.SoftwareUniversityLearningSystem
{
    class CurrentStudent : Student
    {
        public string CurrentCourse { get; set; }

        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            CurrentCourse = currentCourse;
        }

        public override string ToString()
        {
            return string.Format("{0}; Current course: {1}", base.ToString(), CurrentCourse);
        }
    }
}
