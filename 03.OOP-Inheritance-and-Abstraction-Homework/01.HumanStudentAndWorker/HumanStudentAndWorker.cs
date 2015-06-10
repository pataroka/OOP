namespace _01.HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public static class HumanStudentAndWorker
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Student> students = new List<Student>()
                                       {
                                           new Student("Ivan", "Ivanov", "23a456f3D"),
                                           new Student("Petar", "Petrov", "4r3a456f"),
                                           new Student("Dimitar", "Dimitrov", "3423a456f"),
                                           new Student("Ivan", "Petrov", "a323a456f"),
                                           new Student("Ivan", "Dimitrov", "d623a456f"),
                                           new Student("Petar", "Ivanov", "gf723a456f"),
                                           new Student("Petar", "Dimitrov", "56r23a456f"),
                                           new Student("Dimitar", "Ivanov", "ty723a456f"),
                                           new Student("Dimitar", "Petrov", "z8323a456f"),
                                           new Student("Dragan", "Ivanov", "v5623a456f")
                                       };

            List<Worker> workers = new List<Worker>()
                                       {
                                           new Worker("Anton", "Antonov", 512.23m, 7),
                                           new Worker("Dragan", "Draganov", 438.23m, 8),
                                           new Worker("Zlatan", "Zlatanov", 328.98m, 12),
                                           new Worker("Dragan", "Antonov", 246.90m, 3),
                                           new Worker("Zlatan", "Antonov", 678.90m, 9),
                                           new Worker("Anton", "Draganov", 456.75m, 8),
                                           new Worker("Zlatan", "Draganov", 563.12m, 8),
                                           new Worker("Anton", "Zlatanov", 235.57m, 5),
                                           new Worker("Dragan", "Zlatanov", 456.78m, 7),
                                           new Worker("Zlatan", "Petrov", 222.89m, 2)
                                       };

            var sortedStudents = from st in students orderby st.FacultyNumber ascending select st;
            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }

            var sortedWorkers = from w in workers orderby w.MoneyPerHour() descending select w;
            foreach (var w in sortedWorkers)
            {
                Console.WriteLine(w);
            }

            List<Human> mergedHumans = new List<Human>();
            mergedHumans.AddRange(students);
            mergedHumans.AddRange(workers);
            var sortedHumans = from h in mergedHumans orderby h.FirstName, h.LastName select h;
            foreach (var h in sortedHumans)
            {
                Console.WriteLine(h);
            }
        }
    }
}
