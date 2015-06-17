namespace _04.StudentClass
{
    using System;

    public static class StudentClass
    {
        public static void Main()
        {
            var student = new Student("Pesho", 38);

            student.OnPropertyChanged += PropertyHandler;

            student.Name = "Ivan";
            student.Age = 22;

            student.OnPropertyChanged -= PropertyHandler;

            student.OnPropertyChanged += (sender, eventArgs) =>
                {
                    Console.WriteLine(
                        "Property changed: {0} (from {1} to {2})",
                        eventArgs.PropertyName,
                        eventArgs.OldValue,
                        eventArgs.NewValue);
                };
            student.Name = "Maria";
            student.Age = 19;

        }

        private static void PropertyHandler(object sender, PropertyChangedEventArgs eventArgs)
        {
            Console.WriteLine(
                "Property changed: {0} (from {1} to {2})",
                eventArgs.PropertyName,
                eventArgs.OldValue,
                eventArgs.NewValue);
        }
    }
}
