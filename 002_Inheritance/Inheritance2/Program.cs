using System;

// Структури. Наслідування.

// Всі структури неявно наслідуються від абстрактного класу - ValueType

namespace Inheritance
{
    struct MyStruct //: ValueType
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
            MyStruct instance = new MyStruct();

            ValueType valueType = instance as ValueType;

            Console.WriteLine("instance = {0}", instance.GetHashCode());
            Console.WriteLine("valueType = {0}", valueType.GetHashCode());

            // Delay.
            Console.ReadKey();
        }
    }
}