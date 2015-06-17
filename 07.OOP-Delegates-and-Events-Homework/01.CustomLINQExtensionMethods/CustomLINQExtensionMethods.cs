namespace _01.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CustomLinqExtensionMethods
    {
        public static void Main()
        {
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var oddNumbers = list.WhereNot(x => x % 2 == 0).ToList();

            Console.WriteLine(string.Join(", ", oddNumbers));

            List<Person> people = new List<Person>
                                      {
                                          new Person("Ivan", 21),
                                          new Person("Pesho", 32),
                                          new Person("Todor", 18),
                                          new Person("Minka", 16),
                                          new Person("Penka", 54)
                                      };

            Console.WriteLine(people.CustomMax(p => p.Age));
        }
    }
}
