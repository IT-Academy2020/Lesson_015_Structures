using System;

// Nested structures.

// Структури можуть містити вкладені класи.

namespace Nested
{
    struct MyStruct
    {
        public class Nested
        {
            public void Method()
            {
                Console.WriteLine("Nested");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct.Nested instance = new MyStruct.Nested();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}