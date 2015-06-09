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
                catch (ArgumentNullException ne)
                {
                    Console.Error.WriteLine("Input cannot be null or empty!\n" + ne.ToString());
                }
                catch (FormatException fe)
                {
                    Console.Error.WriteLine("Input is not in the correct format!\n" + fe.ToString());
                }
                catch (ArgumentOutOfRangeException or)
                {
                    Console.Error.WriteLine("The input number has to be in range [{0}..{1}]\n{2}", start, end, or.ToString());
                }
                catch (OverflowException of)
                {
                    Console.Error.WriteLine("The input number exceeds the boundaries of the Int32 type!\n" + of.ToString());
                }
                catch (ApplicationException ae)
                {
                    Console.Error.WriteLine("Program execution cannot continue!\n" + ae.ToString());
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
