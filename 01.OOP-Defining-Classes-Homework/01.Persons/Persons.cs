namespace _01.Persons
{
    using System;

    public static class Persons
    {
        public static void Main()
        {
            Person p = new Person("John", 32);

            Console.WriteLine(p.ToString());
        }
    }
}
