namespace _01.SquareRoot
{
    using System;

    public static class SquareRoot
    {
        public static void Main()
        {
            try
            {
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new ArgumentNullException();
                }

                int num = int.Parse(str);

                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double result = Math.Sqrt(num);
                Console.WriteLine(result);
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Input must have a value!");
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid format!\n" + fe.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Input cannot take negative value!");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Input exceeds the boundaries of the Int32 type!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
