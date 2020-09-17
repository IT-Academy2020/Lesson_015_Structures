using System;

// Структури. Конструктори.

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Користувацький конструктор з параметрами.
        public MyStruct(int value)
        {
            this.field = value;

            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення екземпляра структурного типу без виклику конструктора.
            MyStruct instance;


            // Не можна використовувати неініціалізувану змінну.
            // Так як конструктор не викликався змінна field залишилася неініціалізованою.

            //Console.WriteLine(instance.field); // Прибрати коментар.

            // Delay.
            Console.ReadKey();
        }
    }
}