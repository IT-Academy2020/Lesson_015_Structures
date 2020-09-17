using System;

// Структури.

// У структурах можна створювати автоматично реалізовані властивості,
// при цьому потрібно використовувати конструктор при побудові екземпляра.

namespace Structure
{
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance = new MyStruct();

            instance.MyProperty = 1;
            Console.WriteLine(instance.MyProperty);

            // Delay.
            Console.ReadKey();
        }
    }
}