﻿using System;

// Структури.

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Конструктори за замовчуванням не можна задавати явно.
        // public MyStruct ()
        // {
        //}

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
            // Створення екземпляра структурного типу, з викликом користувацького конструктора.
            MyStruct instance = new MyStruct(1);

            Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}