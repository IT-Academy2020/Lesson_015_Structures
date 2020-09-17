using System;

// Структури. Наслідування.

// Наслідування (Реалізація) структур дозволено тільки від інтерфейсів.
// Наслідування структур, від класів і структур заборонено.

namespace Inheritance
{
    interface IInterface
    {
        void Method();
    }

    struct MyStruct : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance;

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}