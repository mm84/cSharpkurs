using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {

            ValueTypes();

            for (; ; )
            {
                Greetings();
                Age();
                Settings();
            }

        }

        private static void ValueTypes()
        {
            
                int maxInt = int.MaxValue;
                int minInt = int.MinValue;
                long maxLong = long.MaxValue;
                long minLong = long.MinValue;

                Console.WriteLine("maxInt = " + maxInt);
                Console.WriteLine("minInt = " + minInt);
                Console.WriteLine("maxLong = " + maxLong);
                Console.WriteLine("minLong = " + minLong);
            
        }

        /// <summary>
        /// Ustawienie programu
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Badanie wieku użytkownika
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, jesteś pełnoletni - możesz wypić piwo");
                Console.ResetColor();
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("podaj poprawną wartość");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Możesz wypić mleko :)");
                Console.ResetColor();
            }
        }
        /// <summary>
        /// Przywitanie użytkownika
        /// </summary>
        private static void Greetings()
        {
            Console.ResetColor();
            Console.Write("Wprowadź swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
