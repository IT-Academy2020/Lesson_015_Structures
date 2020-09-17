using System;

// Структури.

// Якщо в структурі є члени, які звертаються до поля і немає конструктора який явно проініціалізовує усі поля,
// то потрібно при створенні екземпляра викликати конструктор за замовчуванням, щоб він проініціалізував значеннями по дефолту. (Інакше буде помилка.)

namespace Structure
{
    struct MyStruct
    {
        private int field;

        public int Field
        {
            get { return field; }
            set { field = value; }
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення примірника структурного типу з викликом конструктора за замовчуванням.
            MyStruct instance = new MyStruct();

            instance.Field = 1;

            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}