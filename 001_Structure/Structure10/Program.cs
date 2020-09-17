﻿using System;

// Структури.

// Приклад хорошого дизайну.

namespace Structure
{
    struct ZipCode
    {
        // Поля
        int fiveDigitCode;
        int plusFourExtension;

        // Конструктори.
        public ZipCode(int fiveDigitCode, int plusFourExtension)
        {
            this.fiveDigitCode = fiveDigitCode;
            this.plusFourExtension = plusFourExtension;
        }

        public ZipCode(int fiveDigitCode)
            : this(fiveDigitCode, 0)
        {
        }

        // Властивості.
        public int FiveDigitCode
        {
            get { return fiveDigitCode; }
        }

        public int PlusFourExtension
        {
            get { return plusFourExtension; }
        }
    }

    class Program
    {
        static void Main()
        {
            ZipCode zipCode = new ZipCode(12345, -1234);

            Console.WriteLine(zipCode.FiveDigitCode);
            Console.WriteLine(zipCode.PlusFourExtension);

            // Delay.
            Console.ReadKey();
        }
    }
}