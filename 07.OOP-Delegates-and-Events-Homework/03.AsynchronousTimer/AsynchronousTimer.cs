namespace _03.AsynchronousTimer
{
    using System;
    using System.Windows.Forms;

    public static class AsynchronousTimer
    {
        private static int count = 1;

        public static void Main()
        {
            Console.WriteLine("Enter the number of times for the repeated action:");
            int ticks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the interval between repetitions(in milliseconds):");
            double interval = double.Parse(Console.ReadLine());
            Console.WriteLine("Press the 'Esc' key if you want to stop the program!");

            Action act = TimerMethod;
            AsyncTimer timer = new AsyncTimer(act, ticks, interval);
            timer.Run();

            int i = 1;
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.WriteLine("I'm an unstopable Main method {0}", i++);
            }
        }

        private static void TimerMethod()
        {
            MessageBox.Show(string.Format("I'm an AsyncTimer! Count: {0}", count++));
        }
    }
}
