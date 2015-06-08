namespace _04.SoftwareUniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class SulsTest
    {
        private static void Main()
        {
            var people = new List<Person>();
            people.Add(new Person("Ivan", "Ivanov", 32));
            people.Add(new Person("Petar", "Petrov", 22));
            people.Add(new Student("Dragan", "Draganov", 33, 3456, 4.50));
            people.Add(new Student("Nikola", "Nikolov", 23, 2659, 3.50));
            people.Add(new CurrentStudent("Petar", "Nikolov", 23, 1259, 3.50, "OOP"));
            people.Add(new CurrentStudent("Petar", "Draganov", 23, 1659, 3.50, "Databases"));
            people.Add(new GraduateStudent("Ivan", "Petrov", 30, 7659, 4.50));
            people.Add(new DropoutStudent("Petar", "Ivanov", 20, 2623, 3.50, "drinking and gambling"));
            people.Add(new Trainer("Dragan", "Ivanov", 18));
            people.Add(new Trainer("Petar", "NIkolov", 18));
            people.Add(new SeniorTrainer("Dragan", "Petrov", 19));
            people.Add(new JuniorTrainer("Ivan", "Draganov", 19));
            people.Add(new OnlineStudent("Dragan", "Nikolov", 19, 9876, 5.50, "OOP"));
            people.Add(new OnlineStudent("Nikola", "Petrov", 23, 1234, 3.35, "Databases"));
            people.Add(new OnsiteStudent("Nikola", "Ivanov", 25, 2341, 4.80, "JavaScript Applications", 25));
            people.Add(new OnsiteStudent("Nikola", "Draganov", 24, 1235, 3.95, "Java Basics", 12));

            var currentStudents =
                people.Where(p => p is CurrentStudent).OrderBy(p => ((Student)p).AverageGrade).Select(p => p);

            foreach (var st in currentStudents)
            {
                Console.WriteLine(st);
            }

            /*var dropout = new DropoutStudent("Petar", "Ivanov", 20, 2623, 3.50, "drinking and gambling");
            Console.WriteLine(dropout.Reapply());*/
        }
    }
}