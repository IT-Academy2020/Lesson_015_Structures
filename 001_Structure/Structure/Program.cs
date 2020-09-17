﻿using System;

// Структури.

// У структурах не можна ініціалізувати поля безпосередньо в місці створення.
// Ініціалізація статичних полів необов'язкова.

namespace Structure
{
    struct MyStruct
    {
        public int field;
    }

    class Program
    {
        static void Main()
        {
            // Створення екземпляра структурного типу, викликаючи конструктор без параметрів.
            MyStruct instance1 = new MyStruct();

            //Вище, об’єкт структури MyStruct створюється за допомогою ключового слова new.
            //Він викликає конструктор без параметрів що є за замовчуванням у структурі,
            //який ініціалізує всі члени значеннями за замовчуванням для вказаного типу даних.

            Console.WriteLine(instance1.field);

            // Створення екземпляра структурного типу, без виклику конструктора.
            MyStruct instance2;

            //Якщо ви оголосите змінну типу struct без використання ключового слова new,
            //програма не викличе жодного конструктора, тому всі члени залишаються непроініціалізовані.
            //Отже, ви повинні присвоїти значення кожному полю перед тим, як ви пробуєте отримати із них якесь значення,
            //інакше це призведе до помилки під час компіляції.

            instance2.field = 1; // Закоментувати.

            // Спроба вивести значення неініціалізованого поля призведе до помилки.
            Console.WriteLine(instance2.field);

            // Delay.
            Console.ReadKey();
        }
    }
}