namespace _02.EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public static class EnterNumbers
    {
        public static void Main()
        {
            int counter = 10;
            int start = 1;
            int end = 100;
            List<int> numbers = new List<int>();
            while (counter >= 1)
            {
                Console.WriteLine("Enter a new number in range [{0}..{1}]:", start, end);
                int number = 0;
                try
                {
                    number = ReadNumber(start, end);

                    if (number == end - 1 && counter > 1)
                    {
                        throw new ApplicationException("Program enters an infinite loop!");
                    }
                    
                    numbers.Add(number);
                    start = number;
                    counter--;
                }
                catch (ArgumentNullException)
                {
                    Console.Error.WriteLine("Input cannot be null or empty!");
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Input is not in the correct format!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("The input number has to be in range [{0}..{1}]", start, end);
                }
                catch (OverflowException)
                {
                    Console.Error.WriteLine("The input number exceeds the boundaries of the Int32 type!");
                }
                catch (ApplicationException)
                {
                    Console.Error.WriteLine("Program execution cannot continue!");
                    numbers.Add(number);
                    counter = 0;
                }
            }

            Console.WriteLine("{{ {0} }}", string.Join(", ", numbers));
        }

        private static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }

            int number = int.Parse(input);
            
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
