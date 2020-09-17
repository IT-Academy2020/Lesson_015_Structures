using System;

// Структури.

// Структури можуть містити статичні члени.

// Статичні структури неприпустимі.

namespace Structure
{
    struct MyStruct
    {
        public static int Field
        {
            get;
            set;
        }

        public static void Show()
        {
            Console.WriteLine(Field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Ініціалізація статичних полів необов'язкова.
            //MyStruct.Field = 1;

            MyStruct.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}