using System;

// Структури. Статичний конструктор.

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Статичний конструктор завжди відпрацьовує першим.
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }

        // Якщо в структурі є призначений для користувача конструктор, то потрібно в ньому проініціалізувати усі поля.
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення екземпляра структурного типу, з викликом конструктора без параметрів і механізму ініціалізації обєкта.
            MyStruct instance = new MyStruct { field = 0 };

            Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}