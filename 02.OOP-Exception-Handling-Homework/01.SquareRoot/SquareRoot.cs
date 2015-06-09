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
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("Input must have a value!\n" + ex.ToString());
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid format!\n" + fe.ToString());
            }
            catch (ArgumentOutOfRangeException or)
            {
                Console.Error.WriteLine("Input cannot take negative value!\n" + or.ToString());
            }
            catch (OverflowException oe)
            {
                Console.Error.WriteLine("Input exceeds the boundaries of the Int32 type!\n" + oe.ToString());
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
