using System;

// Структури. Наслідування.

// Від структур не можна наслідуватись.

namespace Inheritance
{
    struct MyStruct
    {
        // Структури не можуть мати protected членів.
        // protected int field;
    }

    class MyClass //: MyStruct
    {
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Від структур не можна наслідуватись.");

            // Delay.
            Console.ReadKey();
        }
    }
}